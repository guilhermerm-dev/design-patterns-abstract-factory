

using design_patterns_abstract_factory.Enum;

namespace design_patterns_abstract_factory.Abstract
{
    public abstract class CarFactory
    { 
        public abstract Car CreateCar(string model, Category category);
    }
}
