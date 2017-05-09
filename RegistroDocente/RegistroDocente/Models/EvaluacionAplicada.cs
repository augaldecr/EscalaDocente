using SQLite.Net.Attributes;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    public class EvaluacionAplicada : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private string evaluacion;
        private int matricula;
        private decimal puntajeObtenido;
        private decimal calificacion;
        private int observacion;
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
        public string Evaluacion
        {
            get
            {
                return evaluacion;
            }
            set
            {
                if (evaluacion != value)
                {
                    evaluacion = value;
                    OnPropertyChanged("evaluacion");
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
        public decimal PuntajeObtenido
        {
            get
            {
                return puntajeObtenido;
            }
            set
            {
                if (puntajeObtenido != value)
                {
                    puntajeObtenido = value;
                    OnPropertyChanged("puntajeObtenido");
                }
            }
        }
        [NotNull]
        public decimal Calificacion
        {
            get
            {
                return calificacion;
            }
            set
            {
                if (calificacion != value)
                {
                    calificacion = value;
                    OnPropertyChanged("calificacion");
                }
            }
        }
        //Linkea con la observación, en caso de ser cotidiano
        public int Observacion
        {
            get
            {
                return observacion;
            }
            set
            {
                if (observacion != value)
                {
                    observacion = value;
                    OnPropertyChanged("observacion");
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
