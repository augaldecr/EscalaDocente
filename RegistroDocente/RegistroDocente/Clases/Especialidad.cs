using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
{
    class Especialidad
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
    }
}
