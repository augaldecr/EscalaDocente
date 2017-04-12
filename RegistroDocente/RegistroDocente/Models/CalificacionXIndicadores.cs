using SQLite.Net.Attributes;

namespace RegistroDocente.Models
{
    public class CalificacionXIndicadores
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public int Evaluacion { get; set; }
        [NotNull]
        public int Indicadores { get; set; }
    }
}
