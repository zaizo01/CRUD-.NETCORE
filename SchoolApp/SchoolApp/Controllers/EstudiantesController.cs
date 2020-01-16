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
    public class EstudiantesController : ControllerBase
    {
        private SchoolContext db = new SchoolContext();
        [Produces("application/json")]
        [HttpGet("all")]

        public ActionResult Get()
        {
            var lst = db.Estudiantes.ToList();       
            return Ok(lst);

        }

        [HttpPost]

        public ActionResult Post(Estudiantes estu)
        {
                Models.Estudiantes estudiantes = new Models.Estudiantes();
                estudiantes.IdCurso = estu.IdCurso;
                estudiantes.Nombre = estu.Nombre;
                estudiantes.Apellido = estu.Apellido;
                estudiantes.Sexo = estu.Sexo;
                estudiantes.Edad = estu.Edad;
                estudiantes.Codigo = estu.Codigo;
                estudiantes.Telefono = estu.Telefono;
                estudiantes.Direccion = estu.Direccion;

                db.Add(estudiantes);
                db.SaveChanges();

            return Ok();
        }

        [HttpPut]

        public ActionResult Put(Estudiantes estu)
        {
           
                Models.Estudiantes estudiantes = db.Estudiantes.Find(estu.IdEstudiantes);
                estudiantes.IdCurso = estu.IdCurso;
                estudiantes.Nombre = estu.Nombre;
                estudiantes.Apellido = estu.Apellido;
                estudiantes.Sexo = estu.Sexo;
                estudiantes.Edad = estu.Edad;
                estudiantes.Codigo = estu.Codigo;
                estudiantes.Telefono = estu.Telefono;
                estudiantes.Direccion = estu.Direccion;


                db.Entry(estudiantes).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();

            return Ok();
        }

        public ActionResult Delete(Estudiantes estu)
        {
           
                Models.Estudiantes estudiantes = db.Estudiantes.Find(estu.IdEstudiantes);
                db.Remove(estudiantes);
                db.SaveChanges();

            return Ok();
        }
        
    }
}