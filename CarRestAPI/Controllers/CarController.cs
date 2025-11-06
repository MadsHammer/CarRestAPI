using CarLib;
using CarLibRepository;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class CarController : ControllerBase
{
    private readonly CarRepositoryList _repository;

    public CarController(CarRepositoryList repository)
    {
        _repository = repository;
    }

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
