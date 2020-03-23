
using System;

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
        public abstract void StartEngine();
        public abstract void StopEngine();
    }

    public enum Category
    {
        HatchBack,
        SUV,
        Sedan
    }


    public class HatchBackCar : Car
    {
        public HatchBackCar(string model, Category category) : base(model, category)
        {

        }

        public override void StartEngine()
        {
            Console.WriteLine($"Model: {Model}, Category: {Category} - Engine Started");
        }

        public override void StopEngine()
        {
            Console.WriteLine($"Model: {Model}, Category: {Category} - Engine Stopped");
        }
    }

    public class SUVCar : Car
    {
        public SUVCar(string model, Category category) : base(model, category)
        {

        }

        public override void StartEngine()
        {
            Console.WriteLine($"Model: {Model}, Category: {Category} - Engine Started");
        }

        public override void StopEngine()
        {
            Console.WriteLine($"Model: {Model}, Category: {Category} - Engine Stopped");
        }
    }

    public class SedanCar : Car
    {
        public SedanCar(string model, Category category) : base(model, category)
        {

        }

        public override void StartEngine()
        {
            Console.WriteLine($"Model: {Model}, Category: {Category} - Engine Started");
        }

        public override void StopEngine()
        {
            Console.WriteLine($"Model: {Model}, Category: {Category} - Engine Stopped");
        }
    }

}
