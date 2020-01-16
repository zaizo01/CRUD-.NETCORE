using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolApp.Models;

namespace SchoolApp.Controllers
{
    [Route("api/Curso")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private SchoolContext db = new SchoolContext();
        [Produces("application/json")]
        [HttpGet]
        public ActionResult Get()
        {
            var lst = db.Curso.ToList();
            return Ok(lst);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Curso>> GetCurso(int id)
        {
            var curs = db.Curso.Find(id);

            if (curs == null)
            {
                return NotFound();
            }

            return curs;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Curso cur)
        {
           
                Models.Curso curso = new Models.Curso();
                curso.Grado = cur.Grado;
                curso.Seccion = cur.Seccion;
                curso.CantDeEstudiantes = cur.CantDeEstudiantes;
                curso.ProfesorEncargado = cur.ProfesorEncargado;

                db.Curso.Add(curso);
                db.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public ActionResult Put(Curso cur)
        {
          
                Models.Curso curso = db.Curso.Find(cur.IdCurso);
                curso.Grado = cur.Grado;
                curso.Seccion = cur.Seccion;
                curso.CantDeEstudiantes = cur.CantDeEstudiantes;
                curso.ProfesorEncargado = cur.ProfesorEncargado;

                db.Entry(curso).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete(Curso cur)
        {

                Models.Curso curso = db.Curso.Find(cur.IdCurso);
                db.Curso.Remove(curso);
                db.SaveChanges();

            return Ok();
        }
        
    }
}