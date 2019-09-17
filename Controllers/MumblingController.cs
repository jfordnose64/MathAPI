using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mathapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class MumblingController : ControllerBase
  {
    // GET api/mumble


    [HttpGet("{s}")]
    public ActionResult<string> Sum(string s)
    {
      return String.Join("-", s.Select((c, i) => Char.ToUpper(c) + new String(Char.ToLower(c), i)));
    }
  }
}