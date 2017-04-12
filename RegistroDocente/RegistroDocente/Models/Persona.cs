using SQLite.Net.Attributes;
using System;

namespace RegistroDocente.Models
{ 
    //Referente a persona base de los diferentes individuos en el registro
    public class Persona
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [Unique, NotNull]
        public string Cedula { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull]
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        [NotNull]
        public DateTime FechaNacimiento { get; set; }
        [NotNull]
        public int Genero { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }

        public string NombreCompleto
        {
            get
            {
                return string.Format("{0} {1} {2}",this.Apellido1, this.Apellido2, this.Nombre);
            }
        }
    }
}
