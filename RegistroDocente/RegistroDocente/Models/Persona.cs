using SQLite.Net.Attributes;
using System;
using System.ComponentModel;

namespace RegistroDocente.Models
{ 
    //Referente a persona base de los diferentes individuos en el registro
    public class Persona : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private string cedula;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private DateTime fechaNacimiento;
        private int genero;
        private string email;
        private string celular;
        private string telefono;
        #endregion

        #region Properties
        [PrimaryKey, AutoIncrement]
        public int ID
        {
            get
            {
                return iD;
            }
            set
            {
                if (iD != value)
                {
                    iD = value;
                    OnPropertyChanged("iD");
                }
            }
        }
        [Unique, NotNull]
        public string Cedula
        {
            get
            {
                return cedula;
            }
            set
            {
                if (cedula != value)
                {
                    cedula = value;
                    OnPropertyChanged("cedula");
                }
            }
        }
        [NotNull]
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (nombre != value)
                {
                    nombre = value;
                    OnPropertyChanged("nombre");
                }
            }
        }
        [NotNull]
        public string Apellido1
        {
            get
            {
                return apellido1;
            }
            set
            {
                if (apellido1 != value)
                {
                    apellido1 = value;
                    OnPropertyChanged("apellido1");
                }
            }
        }
        public string Apellido2
        {
            get
            {
                return apellido2;
            }
            set
            {
                if (apellido2 != value)
                {
                    apellido2 = value;
                    OnPropertyChanged("apellido2");
                }
            }
        }
        [NotNull]
        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
            set
            {
                if (fechaNacimiento != value)
                {
                    fechaNacimiento = value;
                    OnPropertyChanged("fechaNacimiento");
                }
            }
        }
        [NotNull]
        public int Genero
        {
            get
            {
                return genero;
            }
            set
            {
                if (genero != value)
                {
                    genero = value;
                    OnPropertyChanged("genero");
                }
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (email != value)
                {
                    email = value;
                    OnPropertyChanged("email");
                }
            }
        }
        public string Celular
        {
            get
            {
                return celular;
            }
            set
            {
                if (celular != value)
                {
                    celular = value;
                    OnPropertyChanged("celular");
                }
            }
        }
        public string Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                if (telefono != value)
                {
                    telefono = value;
                    OnPropertyChanged("telefono");
                }
            }
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Methods

        protected virtual void OnPropertyChanged(string propiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }

        public string NombreCompleto
        {
            get
            {
                return string.Format("{0} {1} {2}", this.Apellido1, this.Apellido2, this.Nombre);
            }
        }
        #endregion
    }
}
