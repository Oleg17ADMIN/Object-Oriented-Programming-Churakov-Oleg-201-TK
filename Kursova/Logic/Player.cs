namespace Kursova.Logic
{
    public abstract class Player
    {
        public char Symbol { get; }

        protected Player(char symbol)
        {
            Symbol = symbol;
        }

        public abstract (int x, int y) MakeMove(Board board);
    }
}