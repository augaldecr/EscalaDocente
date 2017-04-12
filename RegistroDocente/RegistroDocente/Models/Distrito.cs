using SQLite.Net.Attributes;

namespace RegistroDocente.Models
{
    public class Distrito
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull]
        public int Canton { get; set; }
    }
}
