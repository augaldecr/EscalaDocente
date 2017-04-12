using SQLite.Net.Attributes;

namespace RegistroDocente.Models
{
    //Referente a la institucion educativa
    public class Institucion
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public int Circuito { get; set; }
        [NotNull]
        public string CodigoPresupuestario { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull]
        public int Modalidad { get; set; }
        [NotNull]
        public int Director { get; set; }
        [NotNull]
        public int Distrito { get; set; }
        public string Direccion { get; set; }
        public string EmailInstitucion { get; set; }
    }
}
