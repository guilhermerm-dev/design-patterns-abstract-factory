using System;
using design_patterns_abstract_factory.Abstract;

namespace design_patterns_abstract_factory
{
    public class FordFactory : CarFactory
    {
        public override Car CreateCar()
        {
            return new Fusion();
        }
    }

    public class Fusion : Car
    {
        public Fusion()
        {
            CarName = "Ford Fusion";
        }

        public override void StartEngine()
        {
            Console.WriteLine("Engine Started OK");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Engine Stopped OK");
        }
    }
}
