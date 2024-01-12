
using EightToTenCopy.Service.Minich8;
using EightToTenCopy.Service.Minich9;
using Microsoft.AspNetCore.Mvc;

namespace EightToTenCopy.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class Minich9Controller : ControllerBase
    {
    private IMinich9Service _minich9Service;

    public Minich9Controller(IMinich9Service minich9Service )
          {
            _minich9Service = minich9Service;
          }
          [HttpGet]
    [Route("MagicEight/{question}")]
    public string EightBall()
    {
        return _minich9Service.EightBall();
    }

    }
    
