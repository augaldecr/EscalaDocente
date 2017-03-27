using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
{
    //Referente a los ciclos (I Ciclo, II ciclo, III ciclo, IV ciclo, etc)
    public class CicloEducativo
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull]
        public int NotaMinima { get; set; }
    }
}
