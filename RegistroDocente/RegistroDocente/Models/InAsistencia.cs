using SQLite.Net.Attributes;
using System;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    public class InAsistencia : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private int matricula;
        private DateTime fecha;
        private int tipo;
        private int cantidad;
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
        public int Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                if (matricula != value)
                {
                    matricula = value;
                    OnPropertyChanged("matricula");
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
        public int Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                if (tipo != value)
                {
                    tipo = value;
                    OnPropertyChanged("tipo");
                }
            }
        }
        [NotNull]
        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                if (cantidad != value)
                {
                    cantidad = value;
                    OnPropertyChanged("cantidad");
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
