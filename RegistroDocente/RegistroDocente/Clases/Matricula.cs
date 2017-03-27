using SQLite.Net.Attributes;
using System;

namespace RegistroDocente.Clases
{
    public class Matricula
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string CursoLectivo { get; set; }
        [NotNull]
        public int Estudiante { get; set; }
        [NotNull]
        public int Asignatura { get; set; }
        [NotNull]
        public int Seccion { get; set; }
        [NotNull]
        public int TipoMatricula { get; set; }
        public string EmailEncargado { get; set; }
        public int TipoSalida { get; set; }
        [NotNull]
        public DateTime modificado { get; set; }
    }
}
