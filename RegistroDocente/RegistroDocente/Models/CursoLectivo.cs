using SQLite.Net.Attributes;

namespace RegistroDocente.Models
{
    //Referente al curso lectivo (2015, 2016, 2017, etc)
    public class CursoLectivo
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull, Default(value:false)]
        public bool Activo { get; set; }
    }
}
