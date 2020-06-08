using System;
using System.Collections.Generic;

namespace ObjektGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ObjectGenerator generator = new ObjectGenerator();
            Car car = generator.GetNewObject<Car>();
            List<Car> newList = generator.GetNewObjects<Car>(5);
        }
    }
}
