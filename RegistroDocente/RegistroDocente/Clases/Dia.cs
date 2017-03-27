using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
{
    public class Dia
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
    }
}
