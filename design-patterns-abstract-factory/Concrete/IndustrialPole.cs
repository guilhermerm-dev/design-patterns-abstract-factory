using System;
using System.Collections.Generic;
using System.Linq;
using design_patterns_abstract_factory.Abstract;

namespace design_patterns_abstract_factory.Concrete
{
    public class IndustrialPole
    {
        private List<Car> _cars;

        public IndustrialPole(CarFactory factory)
        {
            _cars = new List<Car>();
            ManufactoryCars(factory);
        }

        private void ManufactoryCars(CarFactory factory)
        {
            factory.CarCatalog.ToList().ForEach(car =>
            {
                _cars.Add(factory.CreateCar(car.Key, car.Value));
            });
        }

        public void TestCars()
        {
            Console.WriteLine("Testing cars...");
            _cars.ForEach(car =>
            {
                car.StartEngine();
                car.StopEngine();
            });
            Console.WriteLine("Cars test end...\n");
        }

    }
}
