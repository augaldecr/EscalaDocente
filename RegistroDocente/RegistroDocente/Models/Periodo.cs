using SQLite.Net.Attributes;
using System;

namespace RegistroDocente.Models
{
    //Referente al período per se, por curso lectivo
    public class Periodo
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull]
        public int CursoLectivo { get; set; }
        [NotNull]
        public DateTime FechaInicio { get; set; }
        [NotNull]
        public DateTime FechaFin { get; set; }
    }
}
