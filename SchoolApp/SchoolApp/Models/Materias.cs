using System;
using System.Collections.Generic;

namespace SchoolApp.Models
{
    public partial class Materias
    {
        public int IdMaterias { get; set; }
        public int IdCurso { get; set; }
        public string Profesor { get; set; }
        public string Materia { get; set; }
        public string Horario { get; set; }
        public string Duracion { get; set; }

        public virtual Curso IdCursoNavigation { get; set; }
    }
}
