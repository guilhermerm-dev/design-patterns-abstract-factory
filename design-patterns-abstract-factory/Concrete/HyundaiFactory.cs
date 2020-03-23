using System;
using System.Collections.Generic;
using design_patterns_abstract_factory.Abstract;

namespace design_patterns_abstract_factory.Concrete
{
    public class HyundaiFactory : CarFactory
    {
        public HyundaiFactory()
        {
            CarCatalog = InitializeCarsCatalog();
        }

        private Dictionary<string, Category> InitializeCarsCatalog()
        {
            return new Dictionary<string, Category>
            {
                { "I30", Category.HatchBack},
                {"Tucson", Category.SUV },
                {"HB20S", Category.Sedan }
            };
        }

        public override Car CreateCar(string model, Category category)
        {
            switch (category)
            {
                case Category.HatchBack:
                    return new HatchBackCar(model, category);

                case Category.Sedan:
                    return new SedanCar(model, category);

                case Category.SUV:
                    return new SUVCar(model, category);

                default:
                    throw new ApplicationException("Car category not found");
            }
        }
    }
}
