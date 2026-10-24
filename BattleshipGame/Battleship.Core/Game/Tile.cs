using Battleship.Core.Enums;
namespace Battleship.Core.Game
{
    public class Tile
    {
        public TileState State { get; private set; } = TileState.Water;

        public void MarkShip()
        {
            State = TileState.Ship;
        }

        public void MarkHit()
        {
            State = TileState.Hit;
        }

        public void MarkMiss()
        {
            State = TileState.Miss;
        }
    }
}
