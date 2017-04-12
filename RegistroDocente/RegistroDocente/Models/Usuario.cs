using SQLite.Net.Attributes;

namespace RegistroDocente.Models
{
    //Clase referente a usuario de registro, normalmente un usuario único
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string User { get; set; }
        [NotNull]
        public string Password { get; set; }
        [NotNull]
        public int Persona { get; set; }
        [NotNull, Default(value: false)]
        public bool Defecto { get; set; }
    }
}
