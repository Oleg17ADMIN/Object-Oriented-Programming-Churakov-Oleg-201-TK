namespace Kursova.Logic
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(char symbol) : base(symbol) { }

        public override (int x, int y) MakeMove(Board board)
        {
            return (-1, -1); // Хід відбувається через натискання кнопок
        }
    }
}