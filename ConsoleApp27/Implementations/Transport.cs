using ConsoleApp27.Interfaces;

namespace ConsoleApp27.Implementations
{
    public class Transport :
    IMyCloneable<Transport>,
    ICloneable
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public Transport(
            string brand,
            string model,
            int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public virtual Transport MyClone()
        {
            return new Transport(
                Brand,
                Model,
                Year);
        }

        public object Clone()
        {
            return MyClone();
        }

        public override string ToString()
        {
            return $"Brand: {Brand}, " +
                   $"Model: {Model}, " +
                   $"Year: {Year}";
        }
    }
}
