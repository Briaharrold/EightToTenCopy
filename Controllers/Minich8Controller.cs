
using EightToTenCopy.Service.Minich8;
using Microsoft.AspNetCore.Mvc;
namespace EightToTenCopy.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class Minich8Controller : ControllerBase
  {
        private readonly IMinich8Service _minich8Service;
    public Minich8Controller(IMinich8Service minich8Service)
    {
            _minich8Service = minich8Service;
    } 
    
     [HttpGet]
    [Route("GuessIt/Easy/{guess}")]
    public string GuessItEasy(string guess)
    {
        return _minich8Service.GuessItEasy(guess);
    } 
    

    [HttpGet]
    [Route("GuessIt/Medium/{guess}")]
    public string GuessItMedium(string guess)
    {
         return _minich8Service.GuessItMedium(guess);
    }

    [HttpGet]
    [Route("GuessIt/Hard/{guess}")]
    public string GuessItHard(string guess)
    {
        return _minich8Service.GuessItHard(guess);
    }
  }

