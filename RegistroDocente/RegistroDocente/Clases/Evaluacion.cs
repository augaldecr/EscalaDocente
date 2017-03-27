using SQLite.Net.Attributes;
using System;

namespace RegistroDocente.Clases
{
    public class Evaluacion
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull]
        public int Periodo { get; set; }
        [NotNull]
        public int TipoEvaluacion { get; set; }
        [NotNull]
        public int Estudiante { get; set; }
        [NotNull]
        public int Seccion { get; set; }
        [NotNull]
        public DateTime FechaAplicacion { get; set; } 
        [NotNull]
        public decimal Porcentaje { get; set; }
        [NotNull]
        public decimal Puntos { get; set; }
        public decimal PuntajeObtenido { get; set; }
        public decimal Calificacion { get; set; }
        public string Observacion { get; set; }
    }
}
