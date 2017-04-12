using SQLite.Net.Attributes;

namespace RegistroDocente.Models
{
    public class TipoEvaluacion
    {
        //Referente a los diferentes tipo de Evaluaciones cuantitativas (Cotidian, Extraclase, prueba, etc)
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
    }
}
