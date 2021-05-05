

namespace PiggyGonzales.FactoryPattern
{
    public class PiggyGonzalesFactory
    {
        protected PiggyGonzalesFactory()
        {
                
        }
        public static FactoryPattern.PiggyGonzales CreateAPiggyGonzales(PiggyGonzalesType type)
        {
            FactoryPattern.PiggyGonzales piggyGonzales = null;
            switch (type)
            {
                case PiggyGonzalesType.Small:
                    piggyGonzales = new SmallPiggyGonzales { Name = "Small PiggyGonzales" };
                    break;

                case PiggyGonzalesType.Medium:
                    piggyGonzales = new MediumPiggyGonzales { Name = "Medium PiggyGonzales" };
                    break;

                case PiggyGonzalesType.Large:
                    piggyGonzales = new LargePiggyGonzales {Name = "Large PiggyGonzales" };
                    break;
            }

            return piggyGonzales;
        }
    }
}
