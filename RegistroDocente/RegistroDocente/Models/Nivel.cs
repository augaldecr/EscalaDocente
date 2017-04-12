using SQLite.Net.Attributes;

namespace RegistroDocente.Models
{
    //Referente a los diferentes niveles del proceso educativo (1, 2, 3, 4, 5, 6, 7, 8, 9, etc.)
    public class Nivel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull]
        public int CicloEducativo { get; set; }
        [NotNull, Default(value:false)]
        public bool activo { get; set; }
    }
}
