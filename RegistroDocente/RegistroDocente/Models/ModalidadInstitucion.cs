using SQLite.Net.Attributes;

namespace RegistroDocente.Models
{
    //Referente a la modalidad de la institucion (Primaria, Secundaria académica, 
    // Secundaria técnica diurna, secundaria técnica nocturna, etc.
    public class ModalidadInstitucion
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
    }
}
