
using design_patterns_abstract_factory.Concrete;

namespace design_patterns_abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var hyundaiFactory = new HyundaiFactory();
            var hyundaiIndustrialPole = new IndustrialPole(hyundaiFactory);
            hyundaiIndustrialPole.TestCars();
        }
    }
}
