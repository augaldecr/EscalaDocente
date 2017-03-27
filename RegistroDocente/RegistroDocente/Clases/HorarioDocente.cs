using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
{
    public class HorarioDocente
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public int Asignatura { get; set; }
        [NotNull]
        public int Seccion { get; set; }
        [NotNull]
        public int Dia { get; set; }
        [NotNull]
        public int CantidadLecciones { get; set; }
    }
}
