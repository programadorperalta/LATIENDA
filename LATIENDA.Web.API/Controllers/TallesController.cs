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
    public class TallesController : ApiController
    {
        private LATIENDAContext db = new LATIENDAContext();

        public TallesController()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }

        // GET: api/Talles
        public IQueryable<Talle> GetTalles()
        {
            return db.Talles;
        }

        // GET: api/Talles/5
        [ResponseType(typeof(Talle))]
        public IHttpActionResult GetTalle(int id)
        {
            Talle talle = db.Talles.Find(id);
            if (talle == null)
            {
                return NotFound();
            }

            return Ok(talle);
        }

        // PUT: api/Talles/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTalle(int id, Talle talle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != talle.ID)
            {
                return BadRequest();
            }

            db.Entry(talle).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TalleExists(id))
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

        // POST: api/Talles
        [ResponseType(typeof(Talle))]
        public IHttpActionResult PostTalle(Talle talle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Talles.Add(talle);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = talle.ID }, talle);
        }

        // DELETE: api/Talles/5
        [ResponseType(typeof(Talle))]
        public IHttpActionResult DeleteTalle(int id)
        {
            Talle talle = db.Talles.Find(id);
            if (talle == null)
            {
                return NotFound();
            }

            db.Talles.Remove(talle);
            db.SaveChanges();

            return Ok(talle);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TalleExists(int id)
        {
            return db.Talles.Count(e => e.ID == id) > 0;
        }
    }
}