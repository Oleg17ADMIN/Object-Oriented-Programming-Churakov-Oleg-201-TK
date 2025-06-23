using System;
using System.Collections.Generic;
using System.Linq;

namespace Kursova.Logic
{
    public class Board
    {
        private Dictionary<(int, int), char> cells = new Dictionary<(int, int), char>();
        private const int AnalysisRadius = 3;

        public char GetCell(int x, int y)
        {
            return cells.ContainsKey((x, y)) ? cells[(x, y)] : '\0';
        }

        public void PlaceSymbol(int x, int y, char symbol)
        {
            cells[(x, y)] = symbol;
        }

        public void RemoveSymbol(int x, int y)
        {
            if (cells.ContainsKey((x, y)))
                cells.Remove((x, y));
        }

        public bool IsEmpty(int x, int y)
        {
            return !cells.ContainsKey((x, y));
        }

        public bool CheckWin(int x, int y, char symbol)
        {
            (int dx, int dy)[] directions = { (1, 0), (0, 1), (1, 1), (1, -1) };
            int winLength = 5;

            foreach (var dir in directions)
            {
                int consecutive = 1;  // Поточна клітинка вже містить символ

                // Перевірка в прямому напрямку
                for (int i = 1; i < winLength; i++)
                {
                    int nx = x + dir.dx * i;
                    int ny = y + dir.dy * i;

                    if (GetCell(nx, ny) != symbol) break;
                    consecutive++;
                }

                // Перевірка в зворотному напрямку
                for (int i = 1; i < winLength; i++)
                {
                    int nx = x - dir.dx * i;
                    int ny = y - dir.dy * i;

                    if (GetCell(nx, ny) != symbol) break;
                    consecutive++;
                }

                if (consecutive >= winLength) return true;
            }
            return false;
        }

        public List<(int, int)> GetAvailableMoves()
        {
            var result = new HashSet<(int, int)>();

            if (cells.Count == 0)
            {
                result.Add((7, 7)); // Початковий хід у центр
                return result.ToList();
            }

            foreach (var pos in cells.Keys)
            {
                for (int dx = -AnalysisRadius; dx <= AnalysisRadius; dx++)
                {
                    for (int dy = -AnalysisRadius; dy <= AnalysisRadius; dy++)
                    {
                        var p = (pos.Item1 + dx, pos.Item2 + dy);
                        if (IsEmpty(p.Item1, p.Item2))
                        {
                            result.Add(p);
                        }
                    }
                }
            }

            return result.ToList();
        }

        public List<(int, int)> GetOccupiedCells()
        {
            return new List<(int, int)>(cells.Keys);
        }
    }
}