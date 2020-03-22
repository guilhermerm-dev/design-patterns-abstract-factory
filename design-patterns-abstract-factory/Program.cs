
namespace design_patterns_abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var hyundaiFactory = new HyundaiFactory();
            var hyundaiCarIndustry = new CarIndustry(hyundaiFactory);
            hyundaiCarIndustry.TestCar();


            var fordFactory = new FordFactory();
            var fordCarIndustry = new CarIndustry(fordFactory);
            fordCarIndustry.TestCar();
        }
    }
}
