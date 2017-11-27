namespace Decorator
{
    public class AttackCarDecorator : ICar
    {
        private readonly ICar _carToDecorate;

        public AttackCarDecorator(ICar carToDecorate)
        {
            _carToDecorate = carToDecorate;
        }

        public int Drive()
        {
            return _carToDecorate.Drive();
        }

        public int Attack()
        {
            return _carToDecorate.Attack() + 15;
        }

        public int Armor()
        {
            return _carToDecorate.Armor();
        }
    }
}