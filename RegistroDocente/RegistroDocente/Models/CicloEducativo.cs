using SQLite.Net.Attributes;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    //Referente a los ciclos (I Ciclo, II ciclo, III ciclo, IV ciclo, etc)
    public class CicloEducativo : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private string nombre;
        private int notaMinima;
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
        public int NotaMinima
        {
            get
            {
                return notaMinima;
            }
            set
            {
                if (notaMinima != value)
                {
                    notaMinima = value;
                    OnPropertyChanged("notaMinima");
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
