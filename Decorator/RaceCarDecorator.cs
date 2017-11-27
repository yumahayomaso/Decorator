namespace Decorator
{
    public class RaceCarDecorator : ICar
    {
        private readonly ICar _carToDecorate;

        public RaceCarDecorator(ICar carToDecorate)
        {
            _carToDecorate = carToDecorate;
        }

        public int Drive()
        {
            return _carToDecorate.Drive() + 20;
        }

        public int Attack()
        {
            return _carToDecorate.Attack();
        }

        public int Armor()
        {
            return _carToDecorate.Armor();
        }
    }
}