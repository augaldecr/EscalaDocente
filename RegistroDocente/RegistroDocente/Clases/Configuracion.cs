using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
{
    public class Configuracion
    {
        [NotNull, Default(value:false)]
        public bool Listo { get; set; }
        [NotNull,Default(value:false)]
        public bool DatosBasicos { get; set; }
    }
}
