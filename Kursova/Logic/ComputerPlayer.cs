using System;
using System.Threading;

namespace Kursova.Logic
{
    public class ComputerPlayer : Player
    {
        private AIDifficulty difficulty;

        public ComputerPlayer(char symbol, AIDifficulty difficultyLevel = AIDifficulty.Medium)
            : base(symbol)
        {
            this.difficulty = difficultyLevel;
        }

        public override (int x, int y) MakeMove(Board board)
        {
            Thread.Sleep(300);

            int depth = difficulty switch
            {
                AIDifficulty.Easy => 1,
                AIDifficulty.Medium => 3,
                AIDifficulty.Hard => 5,
                _ => 3
            };

            // Адаптивна глибина: зменшуємо на пізніх стадіях гри
            int moveCount = board.GetOccupiedCells().Count;
            if (moveCount > 30) depth = Math.Min(depth, 3);
            if (moveCount > 50) depth = Math.Min(depth, 2);

            return AIEngine.FindBestMove(board, Symbol, depth);
        }
    }
}