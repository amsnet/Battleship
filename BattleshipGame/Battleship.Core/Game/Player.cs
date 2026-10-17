namespace Battleship.Core.Game
{
    public class Player(string name, Board board)
    {
        public string Name { get; } = name;
        public Board Board { get; } = board;
    }
}