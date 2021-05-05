
namespace PiggyGonzales.FactoryPattern
{
    public abstract class PiggyGonzales
    {
        public string Name { get; set; }
        protected PiggyGonzales()
        {
                
        }

        public abstract PiggyGonzales CreatePaggyGonzales();
    }
}
