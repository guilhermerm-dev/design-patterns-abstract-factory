using System;
using design_patterns_abstract_factory.Abstract;

namespace design_patterns_abstract_factory
{
    public class CarIndustry
    {

        private Car _car;

        public CarIndustry(CarFactory factory)
        {
            _car = factory.CreateCar();
        }

        public void TestCar()
        {
            Console.WriteLine($"Starting {_car.CarName} Engine test");
            _car.StartEngine();
            _car.StopEngine();
            Console.WriteLine($" {_car.CarName} engine test end\n");
        }
    }
}
