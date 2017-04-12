using System;
using SQLite.Net.Attributes;

namespace RegistroDocente.Models
{
    public class PaseDeLista
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public DateTime Fecha { get; set; }
        [NotNull]
        public int Estudiante { get; set; }
        public string Observacion { get; set; }
    }
}
