using SQLite.Net.Attributes;

namespace RegistroDocente.Models
{
    public class Indicador
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull]
        public int Indicadores { get; set; }
    }
}
