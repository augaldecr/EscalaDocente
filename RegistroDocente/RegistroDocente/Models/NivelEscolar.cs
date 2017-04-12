using SQLite.Net.Attributes;

namespace RegistroDocente.Models
{ 
    //Referente al nivel escolar (Primaria, Secundaria)
    public class NivelEscolar
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
    }
}
