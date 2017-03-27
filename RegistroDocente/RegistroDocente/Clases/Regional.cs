using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
{
    //Referente a Dirección Regional
    public class Regional
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
    }
}
