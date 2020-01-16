using System;
using System.Collections.Generic;

namespace SchoolApp.Models
{
    public partial class Estudiantes
    {
        public int IdEstudiantes { get; set; }
        public int IdCurso { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public int? Edad { get; set; }
        public string Codigo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public virtual Curso IdCursoNavigation { get; set; }
    }
}
