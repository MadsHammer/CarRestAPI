using System;
using CarLib;

namespace CarLibRepository
{
    public class CarRepositoryList
    {
        private int _nextId = 1;
        private List<Car> _cars = new List<Car>();

        public CarRepositoryList()
        {


        }

        public Car? GetById(int id)
        {
            return _cars.FirstOrDefault(car => car.Id == id);
        }

        public List<Car> GetAllCars()
        {
            return new List<Car>(_cars);
        }

        public IEnumerable<Car> GetCarsByMake(string make)
        {
            return _cars.Where(car => car.Make.Equals(make, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Car> GetCarsByModel(string model)
        {
            return _cars.Where(car => car.Model.Equals(model, StringComparison.OrdinalIgnoreCase));
        }

        public Car Add(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car), "Car cannot be null.");
            }
            car.Id = _nextId++;
            _cars.Add(car);
            return car;


        }

        public Car Remove(int id)
        {
            var car = _cars.FirstOrDefault(c => c.Id == id);
            if (car == null)
            {
                throw new ArgumentException($"No car found with Id {id}.", nameof(id));
            }
            _cars.Remove(car);

            return car;
        }
    }
}
