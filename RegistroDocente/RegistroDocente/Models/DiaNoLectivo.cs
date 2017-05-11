using System;
using SQLite.Net.Attributes;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    public class DiaNoLectivo : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private int diaLectivo;
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
        public int DiaLectivo
        {
            get
            {
                return diaLectivo;
            }
            set
            {
                if (diaLectivo != value)
                {
                    diaLectivo = value;
                    OnPropertyChanged("diaLectivo");
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
