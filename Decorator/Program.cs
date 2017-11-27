using System;

namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICar car = new BaseCar();
            car = new AttackCarDecorator(car);
            car = new AttackCarDecorator(car);
            car = new AttackCarDecorator(car);
            car = new AttackCarDecorator(car);

            car = new RaceCarDecorator(car);
            car = new RaceCarDecorator(car);

            car = new ArmorCarDecorator(car);
            car = new ArmorCarDecorator(car);
            car = new ArmorCarDecorator(car);
            car = new ArmorCarDecorator(car);

            Console.WriteLine($"Car armor {car.Armor()}");
            Console.WriteLine($"Car speed {car.Drive()}");
            Console.WriteLine($"Car armor {car.Attack()}");

            Console.ReadLine();
        }
    }
}
