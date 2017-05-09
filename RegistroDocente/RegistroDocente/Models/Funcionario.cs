using SQLite.Net.Attributes;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    //Referente al funcionario del MEP
    public class Funcionario : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private int persona { get; set; }
        private int puesto { get; set; }
        private int categoriaDocente { get; set; }
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
        public int Persona
        {
            get { return persona; }
            set
            {
                if (persona != value)
                {
                    persona = value;
                    OnPropertyChanged("persona");
                }
            }
        }
        [NotNull]
        public int Puesto
        {
            get { return puesto; }
            set
            {
                if (puesto != value)
                {
                    puesto = value;
                    OnPropertyChanged("puesto");
                }
            }
        }
        public int CategoriaDocente
        {
            get { return categoriaDocente; }
            set
            {
                if (categoriaDocente != value)
                {
                    categoriaDocente = value;
                    OnPropertyChanged("categoriaDocente");
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
