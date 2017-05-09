using SQLite.Net.Attributes;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    //Referente a la institucion educativa
    public class Institucion : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private string nombre;
        private int circuito;
        private string codigoPresupuestario;
        private int modalidad;
        private int director;
        private int distrito;
        private string direccion;
        private string emailInstitucion;
        #endregion

        #region Properties
        [PrimaryKey, AutoIncrement]
        public int ID
        {
            get { return iD; }
            set
            {
                if (iD != value)
                {
                    iD = value;
                    OnPropertyChanged("iD");
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
        public int Circuito
        {
            get
            {
                return circuito;
            }
            set
            {
                if (circuito != value)
                {
                    circuito = value;
                    OnPropertyChanged("circuito");
                }
            }
        }
        [NotNull]
        public string CodigoPresupuestario
        {
            get
            {
                return codigoPresupuestario;
            }
            set
            {
                if (codigoPresupuestario != value)
                {
                    codigoPresupuestario = value;
                    OnPropertyChanged("codigoPresupuestario");
                }
            }
        }
        [NotNull]
        public int Modalidad
        {
            get
            {
                return modalidad;
            }
            set
            {
                if (modalidad != value)
                {
                    modalidad = value;
                    OnPropertyChanged("modalidad");
                }
            }
        }
        [NotNull]
        public int Director
        {
            get
            {
                return director;
            }
            set
            {
                if (director != value)
                {
                    director = value;
                    OnPropertyChanged("director");
                }
            }
        }
        [NotNull]
        public int Distrito
        {
            get
            {
                return distrito;
            }
            set
            {
                if (distrito != value)
                {
                    distrito = value;
                    OnPropertyChanged("distrito");
                }
            }
        }
        public string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                if (direccion != value)
                {
                    direccion = value;
                    OnPropertyChanged("direccion");
                }
            }
        }
        public string EmailInstitucion
        {
            get
            {
                return emailInstitucion;
            }
            set
            {
                if (emailInstitucion != value)
                {
                    emailInstitucion = value;
                    OnPropertyChanged("emailInstitucion");
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
        #endregion
    }
}
