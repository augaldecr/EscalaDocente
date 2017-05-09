using SQLite.Net.Attributes;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    //Referente a los diferentes niveles del proceso educativo (1, 2, 3, 4, 5, 6, 7, 8, 9, etc.)
    public class Nivel : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private string nombre;
        private int cicloEducativo;
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
        public int CicloEducativo
        {
            get
            {
                return cicloEducativo;
            }
            set
            {
                if (cicloEducativo != value)
                {
                    cicloEducativo = value;
                    OnPropertyChanged("cicloEducativo");
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
