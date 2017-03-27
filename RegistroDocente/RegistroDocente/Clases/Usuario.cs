using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
{
    //Clase referente a usuario de registro, normalmente un usuario único
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string usuario { get; set; }
        [NotNull]
        public string password { get; set; }
        [NotNull]
        public string email { get; set; }
        [NotNull]
        public int persona { get; set; }
        [NotNull, Default(value: false)]
        public bool defecto { get; set; }
    }
}
