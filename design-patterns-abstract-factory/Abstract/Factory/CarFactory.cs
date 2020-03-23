
using System.Collections.Generic;

namespace design_patterns_abstract_factory.Abstract
{
    public abstract class CarFactory
    {
        public Dictionary<string, Category> CarCatalog;
        public abstract Car CreateCar(string model, Category category);
    }
}
