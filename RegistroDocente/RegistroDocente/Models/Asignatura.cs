using SQLite.Net.Attributes;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    //Referente a las asignaturas
    public class Asignatura : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private string nombre;
        private int tipoAsignatura;
        private int especialidad;
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
        public int TipoAsignatura
        {
            get
            {
                return tipoAsignatura;
            }
            set
            {
                if (tipoAsignatura != value)
                {
                    tipoAsignatura = value;
                    OnPropertyChanged("tipoAsignatura");
                }
            }
        }
        public int Especialidad
        {
            get
            {
                return especialidad;
            }
            set
            {
                if (especialidad != value)
                {
                    especialidad = value;
                    OnPropertyChanged("especialidad");
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
