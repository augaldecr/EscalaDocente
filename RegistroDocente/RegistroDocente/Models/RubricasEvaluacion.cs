using SQLite.Net.Attributes;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    public class RubricasEvaluacion : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private int asignatura;
        private int cicloEducativo;
        private int porcCotidiano;
        private int porcPortafolio;
        private int porcExtraclase;
        private int porcProyecto;
        private int porcPruebas;
        private int porcConcepto;
        private int porcAsistencia;
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
        public int Asignatura
        {
            get { return asignatura; }
            set
            {
                if (asignatura != value)
                {
                    asignatura = value;
                    OnPropertyChanged("asignatura");
                }
            }
        }
        [NotNull]
        public int CicloEducativo
        {
            get { return cicloEducativo; }
            set
            {
                if (cicloEducativo != value)
                {
                    cicloEducativo = value;
                    OnPropertyChanged("cicloEducativo");
                }
            }
        }
        [NotNull]
        public int PorcCotidiano
        {
            get { return porcCotidiano; }
            set
            {
                if (porcCotidiano != value)
                {
                    porcCotidiano = value;
                    OnPropertyChanged("porcCotidiano");
                }
            }
        }
        public int PorcPortafolio
        {
            get { return porcPortafolio; }
            set
            {
                if (porcPortafolio != value)
                {
                    porcPortafolio = value;
                    OnPropertyChanged("porcPortafolio");
                }
            }
        }
        [NotNull]
        public int PorcExtraclase
        {
            get { return porcExtraclase; }
            set
            {
                if (porcExtraclase != value)
                {
                    porcExtraclase = value;
                    OnPropertyChanged("porcExtraclase");
                }
            }
        }
        [NotNull]
        public int PorcProyecto
        {
            get { return porcProyecto; }
            set
            {
                if (porcProyecto != value)
                {
                    porcProyecto = value;
                    OnPropertyChanged("porcProyecto");
                }
            }
        }
        [NotNull]
        public int PorcPruebas
        {
            get { return porcPruebas; }
            set
            {
                if (porcPruebas != value)
                {
                    porcPruebas = value;
                    OnPropertyChanged("porcPruebas");
                }
            }
        }
        [NotNull]
        public int PorcConcepto
        {
            get { return porcConcepto; }
            set
            {
                if (porcConcepto != value)
                {
                    porcConcepto = value;
                    OnPropertyChanged("porcConcepto");
                }
            }
        }
        [NotNull]
        public int PorcAsistencia
        {
            get { return porcAsistencia; }
            set
            {
                if (porcAsistencia != value)
                {
                    porcAsistencia = value;
                    OnPropertyChanged("porcAsistencia");
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
