using System;
using System.Collections.Generic;
using System.Linq;
using design_patterns_abstract_factory.Abstract;
using design_patterns_abstract_factory.Enum;

namespace design_patterns_abstract_factory
{

    public class Hyundai
    {
        private readonly IList<Car> _cars;

        public IReadOnlyCollection<Car> Cars => _cars.ToArray();

        public Hyundai(CarFactory carFactory, List<(string model, Category category)> carCatalog)
        {
            _cars = new List<Car>();
            _cars = ManufactoryCars(carFactory, carCatalog);
        }

        private List<Car> ManufactoryCars(CarFactory carFactory, List<(string model, Category category)> carCatalog)
        {
            return carCatalog.Select(car => carFactory.CreateCar(car.model, car.category)).ToList();
        }

        public void TestManufacturedCars()
        {
            _cars.ToList().ForEach(car =>
            {
                Console.WriteLine($"Starting Testing Process for model: {car.Model} - Category {car.Category}");
                car.StartEngine();
                car.StopEngine();
                Console.WriteLine("Finalizing test\n");
            });
        }

    }
}
