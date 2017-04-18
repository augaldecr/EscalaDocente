using SQLite.Net.Attributes;
using System.ComponentModel;

namespace RegistroDocente.Models
{
    //Clase referente a usuario de registro, normalmente un usuario único
    public class Usuario : INotifyPropertyChanged
    {
        #region Attributes
        private int iD;
        private string user;
        private string password;
        private string passwordConfirm;
        private int persona;
        private bool defecto;
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
        public string User
        {
            get
            {
                return user;
            }
            set
            {
                if (user != value)
                {
                    user = value;
                    OnPropertyChanged("user");
                }
            }
        }
        [NotNull]
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged("password");
                }
            }
        }
        public string PasswordConfirm
        {
            get
            {
                return passwordConfirm;
            }
            set
            {
                if (passwordConfirm != value)
                {
                    passwordConfirm = value;
                    OnPropertyChanged("passwordConfirm");
                }
            }
        }
        [NotNull]
        public int Persona
        {
            get
            {
                return persona;
            }
            set
            {
                if (persona != value)
                {
                    persona = value;
                    OnPropertyChanged("persona");
                }
            }
        }
        [NotNull, Default(value: false)]
        public bool Defecto
        {
            get
            {
                return defecto;
            }
            set
            {
                if (defecto != value)
                {
                    defecto = value;
                    OnPropertyChanged("defecto");
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
