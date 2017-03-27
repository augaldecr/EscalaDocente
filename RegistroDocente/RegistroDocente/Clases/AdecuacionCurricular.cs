using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
{
    public class AdecuacionCurricular
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public int Matricula { get; set; }
        public int IPeriodoFuncionamiento { get; set; }
        public int IIPeriodoFuncionamiento { get; set; }
        public int IIIPeriodoFuncionamiento { get; set; }
    }
}
 