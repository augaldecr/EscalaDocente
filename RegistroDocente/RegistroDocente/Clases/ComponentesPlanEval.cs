using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
{
    //Referente a cada componente del plan evaluativo por aplicar
    // (Cotidiano, Extraclase, proyecto, prueba, etc)
    public class ComponentesPlanEval
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public int PlanEvaluativo { get; set; }
        [NotNull]
        public int TipoEvaluacion { get; set; }
        [NotNull]
        public int Cantidad { get; set; }
        [NotNull]
        public int PorcentajeAsignado { get; set; }
    }
}
