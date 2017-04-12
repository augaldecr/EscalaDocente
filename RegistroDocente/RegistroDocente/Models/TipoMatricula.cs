using SQLite.Net.Attributes;

namespace RegistroDocente.Models
{
    public class TipoMatricula
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
    }
}
