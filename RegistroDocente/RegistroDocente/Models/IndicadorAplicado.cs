using SQLite.Net.Attributes;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    public class IndicadorAplicado : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private int observacion;
        private int indicador;
        private int matricula;
        private int puntajeAsignado;
        private int puntajeObtenido;
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
        public int Observacion
        {
            get { return observacion; }
            set
            {
                if (observacion != value)
                {
                    observacion = value;
                    OnPropertyChanged("observacion");
                }
            }
        }
        [NotNull]
        public int Indicador
        {
            get { return indicador; }
            set
            {
                if (indicador != value)
                {
                    indicador = value;
                    OnPropertyChanged("indicador");
                }
            }
        }
        [NotNull]
        public int Matricula
        {
            get { return matricula; }
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
        public int PuntajeAsignado
        {
            get { return puntajeAsignado; }
            set
            {
                if (puntajeAsignado != value)
                {
                    puntajeAsignado = value;
                    OnPropertyChanged("puntajeAsignado");
                }
            }
        }
        [NotNull]
        public int PuntajeObtenido
        {
            get { return puntajeObtenido; }
            set
            {
                if (puntajeObtenido != value)
                {
                    puntajeObtenido = value;
                    OnPropertyChanged("puntajeObtenido");
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
