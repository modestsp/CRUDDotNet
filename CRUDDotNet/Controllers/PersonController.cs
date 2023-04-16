using CRUDDotNet.Data;
using Microsoft.AspNetCore.Mvc;

namespace CRUDDotNet.Controllers;


[ApiController]
[Route("api/[controller]")]
public class PersonController : Controller
{
    private readonly DataContext _dataContext;

    public PersonController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }


    [HttpGet]
    public IActionResult GetPersons()
    {
        var persons = _dataContext.Persons.ToList();
        return Ok(persons);
    }
    [HttpPost]
    public IActionResult AddPerson(datos )
    {
        agrego guid
    }

}

