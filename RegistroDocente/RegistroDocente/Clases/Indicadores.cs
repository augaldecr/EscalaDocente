using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
{
    public class Indicadores
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string NombreIndicadores { get; set; }
    }
}
