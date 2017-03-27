using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
{
    //Referente a la categoría docente (MT2, MT3, VT5, ET3, etc)
    public class CategoriaDocente
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Categoria { get; set; }
    }
}
