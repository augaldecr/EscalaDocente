using SQLite.Net.Attributes;
using System;
using System.ComponentModel;

namespace RegistroDocente.Models 
{
    public class Evaluacion : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private int nombre;
        private int periodo;
        private int tipoEvaluacion;
        private DateTime fechaAplicacion;
        private decimal porcentaje;
        private decimal puntos;
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
        public int Nombre
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
        public int TipoEvaluacion
        {
            get
            {
                return tipoEvaluacion;
            }
            set
            {
                if (tipoEvaluacion != value)
                {
                    tipoEvaluacion = value;
                    OnPropertyChanged("tipoEvaluacion");
                }
            }
        }
        [NotNull]
        public DateTime FechaAplicacion
        {
            get
            {
                return fechaAplicacion;
            }
            set
            {
                if (fechaAplicacion != value)
                {
                    fechaAplicacion = value;
                    OnPropertyChanged("fechaAplicacion");
                }
            }
        }
        [NotNull]
        public decimal Porcentaje
        {
            get
            {
                return porcentaje;
            }
            set
            {
                if (porcentaje != value)
                {
                    porcentaje = value;
                    OnPropertyChanged("porcentaje");
                }
            }
        }
        [NotNull]
        public decimal Puntos
        {
            get
            {
                return puntos;
            }
            set
            {
                if (puntos != value)
                {
                    puntos = value;
                    OnPropertyChanged("puntos");
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
