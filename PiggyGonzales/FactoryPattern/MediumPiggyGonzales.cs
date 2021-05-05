namespace PiggyGonzales.FactoryPattern
{
    public class MediumPiggyGonzales : PiggyGonzales
    {
        public override PiggyGonzales CreatePaggyGonzales()
        {
            return new MediumPiggyGonzales();
        }
    }
}
