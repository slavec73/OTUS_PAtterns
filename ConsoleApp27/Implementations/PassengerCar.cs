using ConsoleApp27.Interfaces;

namespace ConsoleApp27.Implementations
{
    public class PassengerCar :
    Car,
    IMyCloneable<PassengerCar>
    {
        public int PassengerCapacity { get; set; }

        public PassengerCar(
            string brand,
            string model,
            int year,
            int passengerCapacity)
            : base(
                brand,
                model,
                year,
                4)
        {
            PassengerCapacity =
                passengerCapacity;
        }

        public override Transport MyClone()
        {
            return new PassengerCar(
                Brand,
                Model,
                Year,
                PassengerCapacity);
        }

        PassengerCar IMyCloneable<PassengerCar>.MyClone()
        {
            return new PassengerCar(
                Brand,
                Model,
                Year,
                PassengerCapacity);
        }

        public override string ToString()
        {
            return base.ToString() +
                   $", Passengers: {PassengerCapacity}";
        }
    }

}
