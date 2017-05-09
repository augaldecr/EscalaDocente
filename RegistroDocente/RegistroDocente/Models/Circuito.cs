using SQLite.Net.Attributes;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    //Referente al circuito educativo, perteneciente a la dirección regional
    public class Circuito : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private string nombre;
        private int regional;
        private string supervisor;
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
        public int Regional
        {
            get
            {
                return regional;
            }
            set
            {
                if (regional != value)
                {
                    regional = value;
                    OnPropertyChanged("regional");
                }
            }
        }
        public string Supervisor
        {
            get
            {
                return supervisor;
            }
            set
            {
                if (supervisor != value)
                {
                    supervisor = value;
                    OnPropertyChanged("supervisor");
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
