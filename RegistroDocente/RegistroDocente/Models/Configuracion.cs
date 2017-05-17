using SQLite.Net.Attributes;

namespace RegistroDocente.Models
{
    public class Configuracion
    {
    	[PrimaryKey]
        public int ID { get; set; }
        [NotNull, Default(value:false)]
        public bool Listo { get; set; }
        [NotNull,Default(value:false)]
        public bool DatosBasicos { get; set; }
    }
}
