namespace PiggyGonzales.FactoryPattern
{
    public class LargePiggyGonzales: PiggyGonzales
    {
        public override PiggyGonzales CreatePaggyGonzales()
        {
            return new LargePiggyGonzales();
        }
    }
}
