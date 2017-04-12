using SQLite.Net.Attributes;

namespace RegistroDocente.Models
{
    //Referente al funcionario del MEP
    public class Funcionario
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public int Persona { get; set; }
        [NotNull]
        public int Puesto { get; set; }
        public int CategoriaDocente { get; set; }
    }
}
