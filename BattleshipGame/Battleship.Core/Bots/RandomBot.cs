using Battleship.Core.Models;

namespace Battleship.Core.Bots
{
    public class RandomBot : IBot
    {
        public Coordinate ChooseAttack(List<Coordinate> previousAttacks)
        {
            Coordinate target;

            do
            {
                target = new Coordinate(Random.Shared.Next(10), Random.Shared.Next(10));
            } 
            while (previousAttacks.Contains(target));

            return target;
        }
    }
}
