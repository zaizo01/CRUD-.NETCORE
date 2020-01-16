using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolApp.Models;

namespace SchoolApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriasController : ControllerBase
    {
        private SchoolContext db = new SchoolContext();
        [Produces("application/json")]
        [HttpGet("all")]
        public ActionResult Get()
        {

            var lst = db.Materias.ToList();
            return Ok(lst);

        }

        [HttpPost]
        public ActionResult Post(Materias mat)
        {
        
                Models.Materias materias = new Models.Materias();
                materias.IdCurso = mat.IdCurso;
                materias.Profesor = mat.Profesor;
                materias.Materia = mat.Materia;
                materias.Horario = mat.Horario;
                materias.Duracion = mat.Duracion;

                db.Materias.Add(materias);
                db.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public ActionResult Put(Materias mat)
        {
           
                Models.Materias materias = db.Materias.Find(mat.IdMaterias);
                materias.IdCurso = mat.IdCurso;
                materias.Profesor = mat.Profesor;
                materias.Materia = mat.Materia;
                materias.Horario = mat.Horario;
                materias.Duracion = mat.Duracion;

                db.Entry(materias).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete(Materias mat)
        {
          
                Models.Materias materias = db.Materias.Find(mat.IdMaterias);
                db.Materias.Remove(materias);
                db.SaveChanges();

            return Ok();
        }
    }
}