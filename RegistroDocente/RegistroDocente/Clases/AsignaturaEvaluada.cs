using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
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
