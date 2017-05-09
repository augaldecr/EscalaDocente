using SQLite.Net.Attributes;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    public class AdecuacionCurricular : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private int matricula;
        private int tipoAdecuacion;
        private int funcionamientoIPeriodo;
        private int funcionamientoIIPeriodo;
        private int funcionamientoIIIPeriodo;
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
        public int TipoAdecuacion
        {
            get { return tipoAdecuacion; }
            set
            {
                if (tipoAdecuacion != value)
                {
                    tipoAdecuacion = value;
                    OnPropertyChanged("tipoAdecuacion");
                }
            }
        }
        public int FuncionamientoIPeriodo
        {
            get { return funcionamientoIPeriodo; }
            set
            {
                if (funcionamientoIPeriodo != value)
                {
                    funcionamientoIPeriodo = value;
                    OnPropertyChanged("funcionamientoIPeriodo");
                }
            }
        }
        public int FuncionamientoIIPeriodo
        {
            get { return funcionamientoIIPeriodo; }
            set
            {
                if (funcionamientoIIPeriodo != value)
                {
                    funcionamientoIIPeriodo = value;
                    OnPropertyChanged("funcionamientoIIPeriodo");
                }
            }
        }
        public int FuncionamientoIIIPeriodo
        {
            get { return funcionamientoIIIPeriodo; }
            set
            {
                if (funcionamientoIIIPeriodo != value)
                {
                    funcionamientoIIIPeriodo = value;
                    OnPropertyChanged("funcionamientoIIIPeriodo");
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
 