using ConsoleApp27.Interfaces;

namespace ConsoleApp27.Implementations
{
    public class Car :
    Transport,
    IMyCloneable<Car>
    {
        public int DoorCount { get; set; }

        public Car(
            string brand,
            string model,
            int year,
            int doorCount)
            : base(
                brand,
                model,
                year)
        {
            DoorCount = doorCount;
        }

        public override Transport MyClone()
        {
            return new Car(
                Brand,
                Model,
                Year,
                DoorCount);
        }

        Car IMyCloneable<Car>.MyClone()
        {
            return new Car(
                Brand,
                Model,
                Year,
                DoorCount);
        }

        public override string ToString()
        {
            return base.ToString() +
                   $", Doors: {DoorCount}";
        }
    }
}
