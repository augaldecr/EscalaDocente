using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
{
    public class IndicadorAplicado
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        //Calificacion por indicadores
        public int CalificacionAplicada { get; set; }
        [NotNull]
        public int Indicador { get; set; }
        [NotNull]
        public int PuntajeAsignado { get; set; }
        [NotNull]
        public int PuntajeObtenido { get; set; }
    }
}
