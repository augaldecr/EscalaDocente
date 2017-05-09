using SQLite.Net.Attributes;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    public class Seccion : INotifyPropertyChanged
    {
        #region Atttributes
        private int iD;
        private int nivel;
        private string grupo;
        private int institucion;
        private int cursoLectivo;
        private string subGrupo;
        private int profesorGuia;
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
        public int Nivel
        {
            get
            {
                return nivel;
            }
            set
            {
                if (nivel != value)
                {
                    nivel = value;
                    OnPropertyChanged("nivel");
                }
            }
        }
        [NotNull, MaxLength(2)]
        public string Grupo
        {
            get
            {
                return grupo;
            }
            set
            {
                if (grupo != value)
                {
                    grupo = value;
                    OnPropertyChanged("grupo");
                }
            }
        }
        [NotNull]
        public int Institucion
        {
            get
            {
                return institucion;
            }
            set
            {
                if (institucion != value)
                {
                    institucion = value;
                    OnPropertyChanged("institucion");
                }
            }
        }
        [NotNull]
        public int CursoLectivo
        {
            get
            {
                return cursoLectivo;
            }
            set
            {
                if (cursoLectivo != value)
                {
                    cursoLectivo = value;
                    OnPropertyChanged("cursoLectivo");
                }
            }
        }
        [MaxLength(1)]
        public string SubGrupo
        {
            get
            {
                return subGrupo;
            }
            set
            {
                if (subGrupo != value)
                {
                    subGrupo = value;
                    OnPropertyChanged("subGrupo");
                }
            }
        }
        //Linkeado a Funcionario
        public int ProfesorGuia
        {
            get
            {
                return profesorGuia;
            }
            set
            {
                if (profesorGuia != value)
                {
                    profesorGuia = value;
                    OnPropertyChanged("profesorGuia");
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
