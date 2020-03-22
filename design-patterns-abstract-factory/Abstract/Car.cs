
namespace design_patterns_abstract_factory.Abstract
{
    public abstract class Car
    {
        public virtual string CarName { get; set; }
        public abstract void StartEngine();
        public abstract void StopEngine();
    }
}
