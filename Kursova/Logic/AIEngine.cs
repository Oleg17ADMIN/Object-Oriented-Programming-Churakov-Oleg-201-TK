using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; // Додано для MessageBox

namespace Kursova.Logic
{
    public static class AIEngine
    {
        private static Random rnd = new Random();
        private const int WinScore = 1000000;
        private const int BlockWinScore = 50000;
        private const int CreateOpportunityScore = 1000;

        // Кеш для зберігання оцінок позицій
        private static Dictionary<string, int> evaluationCache = new Dictionary<string, int>();
        private static DateTime searchStartTime;

        public static (int, int) FindBestMove(Board board, char aiSymbol, int depth)
        {
            char opponent = aiSymbol == 'X' ? 'O' : 'X';
            int bestScore = int.MinValue;
            (int, int) bestMove = (0, 0);

            // Скидання кешу перед новим пошуком
            evaluationCache.Clear();
            searchStartTime = DateTime.Now;

            var moves = board.GetAvailableMoves()
                .OrderByDescending(m => EvaluateMovePriority(m, board, aiSymbol, opponent))
                .Take(GetMaxMovesForDepth(depth))
                .ToList();

            foreach (var move in moves)
            {
                // Перевірка часу виконання
                if ((DateTime.Now - searchStartTime).TotalSeconds > 5)
                {
                    MessageBox.Show("AI перевищив час обчислення. Повертаю найкращий знайдений хід.");
                    return bestMove;
                }

                board.PlaceSymbol(move.Item1, move.Item2, aiSymbol);
                int score = Minimax(board, depth - 1, false, aiSymbol, opponent, int.MinValue, int.MaxValue);
                board.RemoveSymbol(move.Item1, move.Item2);

                if (score > bestScore)
                {
                    bestScore = score;
                    bestMove = move;
                }
            }

            return bestMove;
        }

        private static int Minimax(Board board, int depth, bool isMaximizing,
                                  char aiSymbol, char opponentSymbol, int alpha, int beta)
        {
            // Генерація ключа для кешу
            string boardKey = GenerateBoardKey(board, aiSymbol, opponentSymbol);

            if (evaluationCache.TryGetValue(boardKey, out int cachedScore))
                return cachedScore;

            if (depth == 0 || IsTerminalNode(board))
                return EvaluateBoard(board, aiSymbol, opponentSymbol);

            var moves = board.GetAvailableMoves()
                .OrderByDescending(m => EvaluateMovePriority(m, board,
                                isMaximizing ? aiSymbol : opponentSymbol,
                                isMaximizing ? opponentSymbol : aiSymbol))
                .Take(GetMaxMovesForDepth(depth))
                .ToList();

            if (moves.Count == 0)
                return 0;

            int result;
            if (isMaximizing)
            {
                int maxEval = int.MinValue;
                foreach (var move in moves)
                {
                    board.PlaceSymbol(move.Item1, move.Item2, aiSymbol);
                    int eval = Minimax(board, depth - 1, false, aiSymbol, opponentSymbol, alpha, beta);
                    board.RemoveSymbol(move.Item1, move.Item2);

                    maxEval = Math.Max(maxEval, eval);
                    alpha = Math.Max(alpha, eval);
                    if (beta <= alpha) break;
                }
                result = maxEval;
            }
            else
            {
                int minEval = int.MaxValue;
                foreach (var move in moves)
                {
                    board.PlaceSymbol(move.Item1, move.Item2, opponentSymbol);
                    int eval = Minimax(board, depth - 1, true, aiSymbol, opponentSymbol, alpha, beta);
                    board.RemoveSymbol(move.Item1, move.Item2);

                    minEval = Math.Min(minEval, eval);
                    beta = Math.Min(beta, eval);
                    if (beta <= alpha) break;
                }
                result = minEval;
            }

            // Зберігаємо результат у кеш
            evaluationCache[boardKey] = result;
            return result;
        }

        private static string GenerateBoardKey(Board board, char ai, char opponent)
        {
            var sb = new StringBuilder();
            foreach (var cell in board.GetOccupiedCells())
            {
                char symbol = board.GetCell(cell.Item1, cell.Item2);
                sb.Append($"{cell.Item1},{cell.Item2}={(symbol == ai ? 'A' : symbol == opponent ? 'O' : 'E')};");
            }
            return sb.ToString();
        }

        private static int GetMaxMovesForDepth(int depth)
        {
            return depth switch
            {
                1 => 8,   // Легкий рівень
                2 => 12,  // Середній рівень
                _ => 15   // Складний рівень
            };
        }

        private static bool IsTerminalNode(Board board)
        {
            // Спрощена перевірка термінального стану
            return false;
        }

        private static int EvaluateBoard(Board board, char aiSymbol, char opponentSymbol)
        {
            int score = 0;
            var occupiedCells = board.GetOccupiedCells();

            foreach (var (x, y) in occupiedCells)
            {
                char symbol = board.GetCell(x, y);
                if (symbol == aiSymbol)
                    score += EvaluatePoint(board, x, y, aiSymbol, opponentSymbol);
                else
                    score -= EvaluatePoint(board, x, y, opponentSymbol, aiSymbol);
            }

            return score;
        }

        private static int EvaluatePoint(Board board, int x, int y, char symbol, char opponent)
        {
            int score = 0;
            (int dx, int dy)[] directions = { (1, 0), (0, 1), (1, 1), (1, -1) };

            foreach (var dir in directions)
            {
                score += EvaluateDirection(board, x, y, dir.dx, dir.dy, symbol, opponent);
            }

            return score;
        }

        private static int EvaluateDirection(Board board, int x, int y, int dx, int dy, char symbol, char opponent)
        {
            int count = 0;
            int openEnds = 0;

            // Перевірка в одному напрямку
            for (int i = 1; i <= 4; i++)
            {
                int nx = x + dx * i;
                int ny = y + dy * i;
                char cell = board.GetCell(nx, ny);

                if (cell == symbol) count++;
                else if (cell == '\0') { openEnds++; break; }
                else break;
            }

            // Перевірка в протилежному напрямку
            for (int i = 1; i <= 4; i++)
            {
                int nx = x - dx * i;
                int ny = y - dy * i;
                char cell = board.GetCell(nx, ny);

                if (cell == symbol) count++;
                else if (cell == '\0') { openEnds++; break; }
                else break;
            }

            // Оцінка позиції
            if (count >= 4) return 10000;
            if (count == 3 && openEnds == 2) return 5000;
            if (count == 3) return 1000;
            if (count == 2 && openEnds == 2) return 500;
            if (count == 2) return 100;
            return 0;
        }

        private static int EvaluateMovePriority((int, int) move, Board board, char symbol, char opponent)
        {
            int priority = 0;

            // Пріоритетність: можливість перемоги
            board.PlaceSymbol(move.Item1, move.Item2, symbol);
            if (board.CheckWin(move.Item1, move.Item2, symbol))
                priority += WinScore;
            board.RemoveSymbol(move.Item1, move.Item2);

            // Пріоритетність: блокування перемоги противника
            board.PlaceSymbol(move.Item1, move.Item2, opponent);
            if (board.CheckWin(move.Item1, move.Item2, opponent))
                priority += BlockWinScore;
            board.RemoveSymbol(move.Item1, move.Item2);

            // Пріоритетність: створення можливостей
            priority += EvaluatePoint(board, move.Item1, move.Item2, symbol, opponent);

            return priority;
        }
    }
}