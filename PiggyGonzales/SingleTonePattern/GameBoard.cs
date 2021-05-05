using PiggyGonzales.Enums;
using PiggyGonzales.FactoryPattern;
using PiggyGonzales.StrategyPattern;

namespace PiggyGonzales.SingleTonePattern
{
    public class GameBoard
    {
        public int Length { get; set; }
        public int Width { get; set; }
        protected GameBoard()
        {
        }

        public static GameBoard CreateGameBoard(int length, int width)
        {
            return new GameBoard
            {
                Length = length,
                Width = width
            };
        }

        public  static void StartGame(Position position)
        {
            CreatePiggyGonzales();
            Move(position);
        }

        private static void CreatePiggyGonzales()
        {
            PiggyGonzalesFactory.CreateAPiggyGonzales(PiggyGonzalesType.Large);
        }

        private static void Move(Position position)
        {
            IMoveMasterPawnStrategy moveMasterPawnStrategy;
            switch (position)
            {
                case Position.BlindSpot:
                    moveMasterPawnStrategy = new PositionIsBlindSpot();
                    moveMasterPawnStrategy.MovePawn();
                    break;;

                case Position.Occupied:
                    moveMasterPawnStrategy = new PositionIsOccupied();
                    moveMasterPawnStrategy.MovePawn();
                    break;
            }

        }

    }
}
