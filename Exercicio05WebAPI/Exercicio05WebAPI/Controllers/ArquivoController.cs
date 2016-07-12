﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Exercicio05WebAPI.Models;

namespace Exercicio05WebAPI.Controllers
{
    public class ArquivoController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Arquivo
        public IQueryable<Arquivo> GetArquivoes()
        {
            return db.Arquivoes;
        }

        // GET: api/Arquivo/5
        [ResponseType(typeof(Arquivo))]
        public async Task<IHttpActionResult> GetArquivo(Guid id)
        {
            Arquivo arquivo = await db.Arquivoes.FindAsync(id);
            if (arquivo == null)
            {
                return NotFound();
            }

            return Ok(arquivo);
        }

        // PUT: api/Arquivo/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutArquivo(Guid id, Arquivo arquivo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != arquivo.ArquivoId)
            {
                return BadRequest();
            }

            db.Entry(arquivo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArquivoExists(id))
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

        // POST: api/Arquivo
        [ResponseType(typeof(Arquivo))]
        public async Task<IHttpActionResult> PostArquivo(Arquivo arquivo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            arquivo.ArquivoId = Guid.NewGuid();

            db.Arquivoes.Add(arquivo);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ArquivoExists(arquivo.ArquivoId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = arquivo.ArquivoId }, arquivo);
        }

        // DELETE: api/Arquivo/5
        [ResponseType(typeof(Arquivo))]
        public async Task<IHttpActionResult> DeleteArquivo(Guid id)
        {
            Arquivo arquivo = await db.Arquivoes.FindAsync(id);
            if (arquivo == null)
            {
                return NotFound();
            }

            db.Arquivoes.Remove(arquivo);
            await db.SaveChangesAsync();

            return Ok(arquivo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ArquivoExists(Guid id)
        {
            return db.Arquivoes.Count(e => e.ArquivoId == id) > 0;
        }
    }
}