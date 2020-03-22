using System;
using design_patterns_abstract_factory.Abstract;

namespace design_patterns_abstract_factory
{
    public class HyundaiFactory : CarFactory
    {
        public override Car CreateCar()
        {
            return new I30();
        }
    }

    public class I30 : Car
    {
        public I30()
        {
            CarName = "Hyundai I30";
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
