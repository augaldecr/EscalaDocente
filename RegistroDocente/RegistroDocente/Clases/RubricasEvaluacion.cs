using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
{
    public class RubricasEvaluacion
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public int Asignatura { get; set; }
        [NotNull]
        public int CicloEducativo { get; set; }
        [NotNull]
        public int PorcCotidiano { get; set; }
        public int PorcPortafolio { get; set; }
        [NotNull]
        public int PorcExtraclase { get; set; }
        [NotNull]
        public int PorcProyecto { get; set; }
        [NotNull]
        public int PorcPruebas { get; set; }
        [NotNull]
        public int PorcConcepto { get; set; }
        [NotNull]
        public int PorcAsistencia { get; set; }
    }
}
