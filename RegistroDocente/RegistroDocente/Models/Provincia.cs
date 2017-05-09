using SQLite.Net.Attributes;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    public class Provincia : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private string nombre;
        private int pais;
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
        public int Pais
        {
            get
            {
                return pais;
            }
            set
            {
                if (pais != value)
                {
                    pais = value;
                    OnPropertyChanged("pais");
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
