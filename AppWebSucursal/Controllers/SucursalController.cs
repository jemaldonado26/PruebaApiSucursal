using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebSucursal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("permitir")]
    public class SucursalController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (Models.TestDBContext db = new Models.TestDBContext())
            {

                var lst = (from d in db.Sucursals
                           select d).ToList();

                return Ok(lst);
            }

        }

        [HttpPost]
        public ActionResult Post([FromBody] Models.Request.Sucursal model)
        {
            using (Models.TestDBContext db = new Models.TestDBContext())
            {
                Models.Sucursal vSucursal = new Models.Sucursal();
                vSucursal.Descripcion = model.descripcion;
                vSucursal.Direccion = model.direccion;
                vSucursal.Identificacion = model.identificacion;
                vSucursal.FechaCreacion = DateTime.Today;
                vSucursal.IdMoneda = model.moneda;
                db.Sucursals.Add(vSucursal);
                db.SaveChanges();
            }

            return Ok();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Models.Request.SucursalEdit model)
        {
            using (Models.TestDBContext db = new Models.TestDBContext())
            {
                Models.Sucursal vSucursal = db.Sucursals.Find(model.id);
                vSucursal.Descripcion = model.descripcion;
                vSucursal.Direccion = model.direccion;
                vSucursal.Identificacion = model.identificacion;
                //vSucursal.FechaCreacion = DateTime.Today;
                vSucursal.IdMoneda = model.moneda;
                db.Entry(vSucursal).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }

            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] Models.Request.SucursalEdit model)
        {
            using (Models.TestDBContext db = new Models.TestDBContext())
            {
                Models.Sucursal vSucursal = db.Sucursals.Find(model.id);
                db.Sucursals.Remove(vSucursal);
                db.SaveChanges();
            }

            return Ok();
        }
    }
}
