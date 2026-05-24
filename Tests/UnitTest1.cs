using ConsoleApp27.Implementations;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void PassengerCarClone_ShouldCreateIndependentObject()
        {
            // Arrange
            PassengerCar original = new(
                "BMW",
                "X5",
                2023,
                5);

            // Act
            PassengerCar clone = (PassengerCar)original.MyClone();

            clone.Model = "X6";

            // Assert
            Assert.NotSame(original, clone);

            Assert.Equal("X5", original.Model);
            Assert.Equal("X6", clone.Model);

            Assert.Equal(original.Brand, clone.Brand);
            Assert.Equal(original.Year, clone.Year);
        }

        [Fact]
        public void TruckClone_ShouldCopyProperties()
        {
            // Arrange
            Truck original = new(
                "Volvo",
                "FH16",
                2020,
                25);

            // Act
            Truck clone = (Truck)original.MyClone();

            // Assert
            Assert.NotSame(original, clone);

            Assert.Equal(original.Brand, clone.Brand);
            Assert.Equal(original.Model, clone.Model);
            Assert.Equal(original.Year, clone.Year);
            Assert.Equal(original.LoadCapacity, clone.LoadCapacity);
        }
    }
}