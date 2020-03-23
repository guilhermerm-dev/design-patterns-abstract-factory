using System.Collections.Generic;
using design_patterns_abstract_factory.Concrete;
using design_patterns_abstract_factory.Enum;

namespace design_patterns_abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {

            var carCatalog = new List<(string model, Category category)>
            {
                (model: "HB20", category: Category.HatchBack),
                (model: "HB20S", category: Category.Sedan),
                (model: "Tucson", category: Category.SUV)
            };

            var hyundaiFactory = new HyundaiFactory();
            var hyundai = new Hyundai(hyundaiFactory, carCatalog);
            hyundai.TestManufacturedCars();
        }

    }
}
