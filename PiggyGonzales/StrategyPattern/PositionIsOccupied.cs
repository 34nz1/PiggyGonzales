using System;

namespace PiggyGonzales.StrategyPattern
{
    public class PositionIsOccupied: IMoveMasterPawnStrategy
    {
        public void MovePawn()
        {
            Console.WriteLine("Master Pawn stays alive");
        }
    }
}
