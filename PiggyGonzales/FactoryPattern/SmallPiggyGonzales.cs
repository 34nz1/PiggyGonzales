namespace PiggyGonzales.FactoryPattern
{
    public class SmallPiggyGonzales : FactoryPattern.PiggyGonzales
    {
        public override FactoryPattern.PiggyGonzales CreatePaggyGonzales()
        {
            return new SmallPiggyGonzales();
        }
    }
}
