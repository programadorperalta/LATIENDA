using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using LATIENDA.Dominio.Entidades;
using LATIENDA.Web.API;

namespace LATIENDA.Web.API.Controllers
{
    public class RubrosController : ApiController
    {
        private LATIENDAContext db = new LATIENDAContext();

        // GET: api/Rubros
        public IQueryable<Rubro> GetRubros()
        {
            return db.Rubros;
        }

        // GET: api/Rubros/5
        [ResponseType(typeof(Rubro))]
        public IHttpActionResult GetRubro(int id)
        {
            Rubro rubro = db.Rubros.Find(id);
            if (rubro == null)
            {
                return NotFound();
            }

            return Ok(rubro);
        }

        // PUT: api/Rubros/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRubro(int id, Rubro rubro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rubro.ID)
            {
                return BadRequest();
            }

            db.Entry(rubro).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RubroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Rubros
        [ResponseType(typeof(Rubro))]
        public IHttpActionResult PostRubro(Rubro rubro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Rubros.Add(rubro);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = rubro.ID }, rubro);
        }

        // DELETE: api/Rubros/5
        [ResponseType(typeof(Rubro))]
        public IHttpActionResult DeleteRubro(int id)
        {
            Rubro rubro = db.Rubros.Find(id);
            if (rubro == null)
            {
                return NotFound();
            }

            db.Rubros.Remove(rubro);
            db.SaveChanges();

            return Ok(rubro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RubroExists(int id)
        {
            return db.Rubros.Count(e => e.ID == id) > 0;
        }
    }
}