using design_patterns_abstract_factory.Abstract;
using design_patterns_abstract_factory.Enum;

namespace design_patterns_abstract_factory.Concrete
{
    public class HyundaiFactory : CarFactory
    {
        public override Car CreateCar(string model, Category category)
        {
            return CarCreator.Create(model, category);
        }
    }

}
