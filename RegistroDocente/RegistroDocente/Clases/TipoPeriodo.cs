using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
{
    public class TipoPeriodo
    { 
        //Referente al nombre de los diferentes períodos (Primer período, Segundo período, etc.)
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
    }
}
