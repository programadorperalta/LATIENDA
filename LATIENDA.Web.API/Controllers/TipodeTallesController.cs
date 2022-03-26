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
    public class TipodeTallesController : ApiController
    {
        private LATIENDAContext db = new LATIENDAContext();

        // GET: api/TipodeTalles
        public IQueryable<TipodeTalle> GetTipodeTalles()
        {
            return db.TipodeTalles;
        }

        // GET: api/TipodeTalles/5
        [ResponseType(typeof(TipodeTalle))]
        public IHttpActionResult GetTipodeTalle(int id)
        {
            TipodeTalle tipodeTalle = db.TipodeTalles.Find(id);
            if (tipodeTalle == null)
            {
                return NotFound();
            }

            return Ok(tipodeTalle);
        }

        // PUT: api/TipodeTalles/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTipodeTalle(int id, TipodeTalle tipodeTalle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipodeTalle.ID)
            {
                return BadRequest();
            }

            db.Entry(tipodeTalle).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipodeTalleExists(id))
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

        // POST: api/TipodeTalles
        [ResponseType(typeof(TipodeTalle))]
        public IHttpActionResult PostTipodeTalle(TipodeTalle tipodeTalle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TipodeTalles.Add(tipodeTalle);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tipodeTalle.ID }, tipodeTalle);
        }

        // DELETE: api/TipodeTalles/5
        [ResponseType(typeof(TipodeTalle))]
        public IHttpActionResult DeleteTipodeTalle(int id)
        {
            TipodeTalle tipodeTalle = db.TipodeTalles.Find(id);
            if (tipodeTalle == null)
            {
                return NotFound();
            }

            db.TipodeTalles.Remove(tipodeTalle);
            db.SaveChanges();

            return Ok(tipodeTalle);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipodeTalleExists(int id)
        {
            return db.TipodeTalles.Count(e => e.ID == id) > 0;
        }
    }
}