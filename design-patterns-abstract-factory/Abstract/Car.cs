
using System;
using design_patterns_abstract_factory.Enum;

namespace design_patterns_abstract_factory.Abstract
{
    public abstract class Car
    {
        protected Car(string model, Category category)
        {
            Model = model;
            Category = category;
        }

        public string Model { get; set; }
        public Category Category { get; set; }
        public void StartEngine() => Console.WriteLine($"Model: {Model}, Category: {Category} - Engine Started");
        public void StopEngine() => Console.WriteLine($"Model: {Model}, Category: {Category} - Engine Stopped");
    }

    public class HatchBackCar : Car
    {
        public HatchBackCar(string model, Category category) : base(model, category)
        {

        }
    }

    public class SUVCar : Car
    {
        public SUVCar(string model, Category category) : base(model, category)
        {

        }
    }

    public class SedanCar : Car
    {
        public SedanCar(string model, Category category) : base(model, category)
        {

        }
    }

    public class CarCreator
    {
        public static Car Create(string model, Category category)
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
                    throw new ApplicationException("Category not found");
            }
        }
    }

}
