using SQLite.Net.Attributes;
using System;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    public class FechasNoLectivas : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private string fecha;
        private string motivo;
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
        public string Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                if (fecha != value)
                {
                    fecha = value;
                    OnPropertyChanged("fecha");
                }
            }
        }
        [NotNull]
        public string Motivo
        {
            get
            {
                return motivo;
            }
            set
            {
                if (motivo != value)
                {
                    motivo = value;
                    OnPropertyChanged("motivo");
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
