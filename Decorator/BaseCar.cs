namespace Decorator
{
    public class BaseCar : ICar
    {
        public int Drive()
        {
            return 10;
        }

        public int Attack()
        {
            return 10;
        }

        public int Armor()
        {
            return 10;
        }
    }
}
