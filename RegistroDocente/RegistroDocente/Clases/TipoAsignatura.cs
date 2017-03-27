using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
{
    //Referente al tipo o modalidad de la asignatura 
    // (Académica, Taller exploratorio, Subárea, Tecnología, etc.)
    public class TipoAsignatura  
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
    }
}
