using Microsoft.AspNetCore.Mvc;
using CarLib;
using CarLibRepository;


namespace CarRestAPI.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private static CarRepositoryList _repository = new CarRepositoryList();

        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return _repository.GetAllCars();
        }

        [HttpGet("{id}")]
        public ActionResult<Car> Get(int id)
        {
            var car = _repository.GetById(id);
            if (car == null)
            {
                return NotFound();
            }
            return car;
        }

    }
}
