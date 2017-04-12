using SQLite.Net.Attributes;

namespace RegistroDocente.Models
{
    class AsignaturaEvaluada
    {
        [AutoIncrement, PrimaryKey]
        public int ID { get; set; }
        [NotNull]
        public int Asignatura { get; set; }
        [NotNull]
        public int CursoLectivo { get; set; }
    }
}
