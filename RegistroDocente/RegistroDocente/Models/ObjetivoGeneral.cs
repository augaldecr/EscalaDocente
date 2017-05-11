using SQLite.Net.Attributes;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    public class ObjetivoGeneral : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        //El orden en el que se encuentran los objetivos en el programa de estudios
        private int orden;
        private string nombre;
        private int nivel;
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
        public int Orden
        {
            get { return orden; }
            set
            {
                if (orden != value)
                {
                    orden = value;
                    OnPropertyChanged("orden");
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
        public int Nivel
        {
            get { return nivel; }
            set
            {
                if (nivel != value)
                {
                    nivel = value;
                    OnPropertyChanged("nivel");
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
