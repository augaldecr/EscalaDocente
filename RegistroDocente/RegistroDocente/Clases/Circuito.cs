using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
{
    //Referente al circuito educativo, perteneciente a la dirección regional
    public class Circuito
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull]
        public int Regional { get; set; }
        public string supervisor { get; set; }
    }
}
