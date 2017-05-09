using SQLite.Net.Attributes;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    public class MatriculaAsignatura : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private int matricula;
        private int asignatura;
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
        public int Asignatura
        {
            get
            {
                return asignatura;
            }
            set
            {
                if (asignatura != value)
                {
                    asignatura = value;
                    OnPropertyChanged("asignatura");
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
