using ConsoleApp27.Interfaces;

namespace ConsoleApp27.Implementations
{
    public class Truck :
    Transport,
    IMyCloneable<Truck>
    {
        public int LoadCapacity { get; set; }

        public Truck(
            string brand,
            string model,
            int year,
            int loadCapacity)
            : base(
                brand,
                model,
                year)
        {
            LoadCapacity =
                loadCapacity;
        }

        public override Transport MyClone()
        {
            return new Truck(
                Brand,
                Model,
                Year,
                LoadCapacity);
        }

        Truck IMyCloneable<Truck>.MyClone()
        {
            return new Truck(
                Brand,
                Model,
                Year,
                LoadCapacity);
        }

        public override string ToString()
        {
            return base.ToString() +
                   $", Capacity: {LoadCapacity} tons";
        }
    }
}

