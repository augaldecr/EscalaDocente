using SQLite.Net.Attributes;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    //Referente al curso lectivo (2015, 2016, 2017, etc)
    public class CursoLectivo : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private string nombre;
        public bool activo;
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
        [NotNull, Default(value: false)]
        public bool Activo
        {
            get
            {
                return activo;
            }
            set
            {
                if (activo != value)
                {
                    activo = value;
                    OnPropertyChanged("activo");
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
