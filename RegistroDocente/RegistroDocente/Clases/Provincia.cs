using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
{
    public class Provincia
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull]
        public int Pais { get; set; }
    }
}
