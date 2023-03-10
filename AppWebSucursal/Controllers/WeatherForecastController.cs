using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebSucursal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (Models.TestDBContext db =  new Models.TestDBContext()) {

                var lst = (from d in db.TipoMoneda
                          select d).ToList();

                return Ok(lst);
            }
               // return new string[] { "Value1", "Value2" };
        }
    }
}
