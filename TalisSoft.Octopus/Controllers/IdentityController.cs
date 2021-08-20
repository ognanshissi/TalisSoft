using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TalisSoft.Octopus.Controllers
{
  [ApiController]
  [Route("api/identity")]
  [Authorize]
  public class IdentityController: ControllerBase
  {

    [HttpGet]
    public ActionResult Get()
    {
      return Ok(from c in User.Claims select new {c.Type, c.Value});
    }
    
  }
}