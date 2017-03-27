using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
{
    //Referente a puesto desempeñado(Director, docente, Bibliotecologo, etc)
    public class Puesto
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
    }
}
