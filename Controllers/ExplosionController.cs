using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mathapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class ExplosionController : ControllerBase
  {
    //Get api/expolosion
    [HttpGet("{s}")]
    public ActionResult<string> Sum(string s)
    {
      var x = String.Join("", s.Select((letter, i) => String.Join("", Enumerable.Repeat(letter, (int)Char.GetNumericValue(letter)))));
      return x;
    }
  }
}