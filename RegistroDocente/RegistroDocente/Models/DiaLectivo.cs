using SQLite.Net.Attributes;
using System;
using System.ComponentModel;

using Xamarin.Forms;

namespace RegistroDocente.Models
{
    public class DiaLectivo : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private DateTime fecha;
        private int dia;
        private int periodo;
        private int seccion;
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
        public DateTime Fecha
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
        public int Dia
        {
            get
            {
                return dia;
            }
            set
            {
                if (dia != value)
                {
                    dia = value;
                    OnPropertyChanged("dia");
                }
            }
        }
        [NotNull]
        public int Periodo
        {
            get
            {
                return periodo;
            }
            set
            {
                if (periodo != value)
                {
                    periodo = value;
                    OnPropertyChanged("periodo");
                }
            }
        }
        [NotNull]
        public int Seccion
        {
            get
            {
                return seccion;
            }
            set
            {
                if (seccion != value)
                {
                    seccion = value;
                    OnPropertyChanged("seccion");
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