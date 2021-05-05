using System;

namespace PiggyGonzales.StrategyPattern
{
    public class PositionIsBlindSpot : IMoveMasterPawnStrategy
    {
        public void MovePawn()
        {
            Console.WriteLine("Master pion dies");
        }
    }
}
