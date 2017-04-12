using SQLite.Net.Attributes;

namespace RegistroDocente.Models
{
    public class Canton
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull]
        public int Provincia { get; set; }
    }
}
