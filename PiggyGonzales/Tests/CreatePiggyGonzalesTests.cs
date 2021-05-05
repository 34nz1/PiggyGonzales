using System.Collections.Generic;
using PiggyGonzales;
using PiggyGonzales.FactoryPattern;
using Xunit;

namespace Tests
{
    public class CreatePiggyGonzalesTests
    {
        public static IEnumerable<object[]> GetObjects
        {
            get
            {
                return new[]
                {
                    new object[]
                    {
                        PiggyGonzalesType.Large,
                        new LargePiggyGonzales {Name = "Large PiggyGonzales" }

                    },

                    new object[]
                    {
                        PiggyGonzalesType.Medium,
                        new MediumPiggyGonzales {Name = "Medium PiggyGonzales" }

                    },

                    new object[]
                    {
                        PiggyGonzalesType.Small,
                        new SmallPiggyGonzales {Name = "Small PiggyGonzales" }
                    },
                };
            }
        }

        [Theory]
        [MemberData(nameof(GetObjects))]
        public void CreateAPiggyGonzales_ReturnsACorrectTypeOfPiggyGonzales(PiggyGonzalesType type,PiggyGonzales.FactoryPattern.PiggyGonzales expected)
        {
            var actual = PiggyGonzalesFactory.CreateAPiggyGonzales(type);
            
            Assert.Same(expected.Name, actual.Name);
        }
    }
}
