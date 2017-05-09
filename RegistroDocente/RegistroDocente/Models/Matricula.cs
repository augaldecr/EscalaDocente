using SQLite.Net.Attributes;
using System;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    public class Matricula
    {
        #region Attributes
        private int iD;
        private int estudiante;
        private int seccion;
        private int tipoMatricula;
        private string emailEncargado;
        private int tipoSalida;
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
        public int Estudiante
        {
            get { return estudiante; }
            set
            {
                if (estudiante != value)
                {
                    estudiante = value;
                    OnPropertyChanged("estudiante");
                }
            }
        }
        [NotNull]
        public int Seccion
        {
            get { return seccion; }
            set
            {
                if (seccion != value)
                {
                    seccion = value;
                    OnPropertyChanged("seccion");
                }
            }
        }
        [NotNull]
        public int TipoMatricula
        {
            get { return tipoMatricula; }
            set
            {
                if (tipoMatricula != value)
                {
                    tipoMatricula = value;
                    OnPropertyChanged("tipoMatricula");
                }
            }
        }
        public string EmailEncargado
        {
            get { return emailEncargado; }
            set
            {
                if (emailEncargado != value)
                {
                    emailEncargado = value;
                    OnPropertyChanged("emailEncargado");
                }
            }
        }
        public int TipoSalida
        {
            get { return tipoSalida; }
            set
            {
                if (tipoSalida != value)
                {
                    tipoSalida = value;
                    OnPropertyChanged("tipoSalida");
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
