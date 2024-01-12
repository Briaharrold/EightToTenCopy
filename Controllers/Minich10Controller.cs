
using EightToTenCopy.Service.Minich10;
using Microsoft.AspNetCore.Mvc;

namespace EightToTenCopy.Controllers
{
    [ApiController]
    [Route("[controller]/{category}")]
    public class Minich10Controller : ControllerBase
    {
        private IMinich10Service _minich10Service;

        public Minich10Controller(IMinich10Service minich10Service)
{
    _minich10Service = minich10Service;
}

    [HttpGet]
    [Route("MexicanThaiOrMongolian")]
    public string RestarauntPicker(string category){
        return _minich10Service.RestarauntPicker(category);
    }
    }
  
    }
    
