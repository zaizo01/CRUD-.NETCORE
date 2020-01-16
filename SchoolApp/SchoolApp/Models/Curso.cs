using System;
using System.Collections.Generic;

namespace SchoolApp.Models
{
    public partial class Curso
    {
        public Curso()
        {
            Estudiantes = new HashSet<Estudiantes>();
            Materias = new HashSet<Materias>();
        }

        public int IdCurso { get; set; }
        public string Grado { get; set; }
        public string Seccion { get; set; }
        public int? CantDeEstudiantes { get; set; }
        public string ProfesorEncargado { get; set; }

        public virtual ICollection<Estudiantes> Estudiantes { get; set; }
        public virtual ICollection<Materias> Materias { get; set; }
    }
}
