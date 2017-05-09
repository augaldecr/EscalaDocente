using SQLite.Net.Attributes;
using System;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    //Referente al período per se, por curso lectivo
    public class Periodo : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private string nombre;
        //Linkea a curso lectivo
        private int cursoLectivo;
        private DateTime fechaInicio;
        private DateTime fechaFin;
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
        public int CursoLectivo
        {
            get
            {
                return cursoLectivo;
            }
            set
            {
                if (cursoLectivo != value)
                {
                    cursoLectivo = value;
                    OnPropertyChanged("cursoLectivo");
                }
            }
        }
        [NotNull]
        public DateTime FechaInicio
        {
            get
            {
                return fechaInicio;
            }
            set
            {
                if (fechaInicio != value)
                {
                    fechaInicio = value;
                    OnPropertyChanged("fechaInicio");
                }
            }
        }
        [NotNull]
        public DateTime FechaFin
        {
            get
            {
                return fechaFin;
            }
            set
            {
                if (fechaFin != value)
                {
                    fechaFin = value;
                    OnPropertyChanged("fechaFin");
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
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }
        #endregion
    }
}
