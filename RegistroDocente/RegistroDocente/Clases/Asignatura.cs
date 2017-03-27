using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
{
    //Referente a las asignaturas
    public class Asignatura
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull]
        public int TipoAsignatura { get; set; }
        [NotNull]
        public int Especialidad { get; set; }
    }
}
