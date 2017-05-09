using SQLite.Net.Attributes;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    public class EscalaNodo : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private string nombre;
        private int escala;
        private int valor;
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
        public int Escala
        {
            get
            {
                return escala;
            }
            set
            {
                if (escala != value)
                {
                    escala = value;
                    OnPropertyChanged("escala");
                }
            }
        }
        [NotNull]
        public int Valor
        {
            get
            {
                return valor;
            }
            set
            {
                if (valor != value)
                {
                    valor = value;
                    OnPropertyChanged("valor");
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
