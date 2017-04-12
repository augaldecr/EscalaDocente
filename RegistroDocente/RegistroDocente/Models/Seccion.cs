using SQLite.Net.Attributes;

namespace RegistroDocente.Models
{
    public class Seccion
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public int Nivel { get; set; }
        [NotNull, MaxLength(2)]
        public string Grupo { get; set; }
        [MaxLength(1)]
        public string SubGrupo { get; set; }
        //Linkeado a Funcionario
        public int ProfesorGuia { get; set; }
    }
}
