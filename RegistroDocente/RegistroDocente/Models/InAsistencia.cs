using SQLite.Net.Attributes;
using System;

namespace RegistroDocente.Models
{
    public class InAsistencia
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public int Estudiante { get; set; }
        [NotNull]
        public DateTime Fecha { get; set; }
        [NotNull]
        public int Tipo { get; set; }
        [NotNull]
        public int Cantidad { get; set; }
    }
}
