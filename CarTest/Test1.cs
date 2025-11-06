namespace CarTest
{
    [TestClass]
    public sealed class CarTest
    {
        [TestMethod]
        public void TestInitialize()
        {
            // Arrange
            var repository = new CarLibRepository.CarRepositoryList();
            // Act
            var cars = repository.GetAllCars();
            // Assert
            Assert.IsNotNull(cars);
            Assert.AreEqual(3, cars.Count());
        }
    }
}
