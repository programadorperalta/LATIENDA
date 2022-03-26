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
    public class TipodePagosController : ApiController
    {
        private LATIENDAContext db = new LATIENDAContext();

        // GET: api/TipodePagos
        public IQueryable<TipodePago> GetTipodePagos()
        {
            return db.TipodePagos;
        }

        // GET: api/TipodePagos/5
        [ResponseType(typeof(TipodePago))]
        public IHttpActionResult GetTipodePago(int id)
        {
            TipodePago tipodePago = db.TipodePagos.Find(id);
            if (tipodePago == null)
            {
                return NotFound();
            }

            return Ok(tipodePago);
        }

        // PUT: api/TipodePagos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTipodePago(int id, TipodePago tipodePago)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipodePago.ID)
            {
                return BadRequest();
            }

            db.Entry(tipodePago).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipodePagoExists(id))
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

        // POST: api/TipodePagos
        [ResponseType(typeof(TipodePago))]
        public IHttpActionResult PostTipodePago(TipodePago tipodePago)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TipodePagos.Add(tipodePago);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tipodePago.ID }, tipodePago);
        }

        // DELETE: api/TipodePagos/5
        [ResponseType(typeof(TipodePago))]
        public IHttpActionResult DeleteTipodePago(int id)
        {
            TipodePago tipodePago = db.TipodePagos.Find(id);
            if (tipodePago == null)
            {
                return NotFound();
            }

            db.TipodePagos.Remove(tipodePago);
            db.SaveChanges();

            return Ok(tipodePago);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipodePagoExists(int id)
        {
            return db.TipodePagos.Count(e => e.ID == id) > 0;
        }
    }
}