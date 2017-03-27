using SQLite.Net.Attributes;
using System;

namespace RegistroDocente.Clases
{
    public class FechasNoLectivas
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public DateTime Fecha { get; set; }
        [NotNull]
        public string Motivo { get; set; }
    }
}
