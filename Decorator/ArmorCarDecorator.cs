namespace Decorator
{
    public class ArmorCarDecorator : ICar
    {
        private readonly ICar _carToDecorate;

        public ArmorCarDecorator(ICar carToDecorate)
        {
            _carToDecorate = carToDecorate;
        }

        public int Drive()
        {
            return _carToDecorate.Drive();
        }

        public int Attack()
        {
            return _carToDecorate.Attack();
        }

        public int Armor()
        {
            return _carToDecorate.Armor() + 10;
        }
    }
}
