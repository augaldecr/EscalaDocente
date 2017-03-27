using SQLite.Net.Attributes;

namespace RegistroActividadesDocentes.Models
{
    public class PlanEvaluativo
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public int Periodo { get; set; }
        [NotNull]
        public int Seccion { get; set; }
        [NotNull]
        public int TipoPeriodicidadAsignatura { get; set; }
        [NotNull]
        public int CantidadLecciones { get; set; }
    }
}
