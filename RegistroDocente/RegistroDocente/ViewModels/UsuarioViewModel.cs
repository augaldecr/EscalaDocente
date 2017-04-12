using RegistroDocente.Controlador;
using RegistroDocente.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace RegistroDocente.ViewModels
{
    public class UsuarioViewModel : Usuario
    {
        #region Commands
        public ICommand Insert { get; private set; }
        public ICommand Update { get; private set; }
        public ICommand Delete { get; private set; }
        public ICommand New { get; private set; }
        #endregion

        #region Constructor
        public UsuarioViewModel()
        {
            Insert = new Command(() =>
            {
                Usuario p = new Usuario()
                {
                    User = User,
                    Password = Password,
                    Persona = Persona,
                    Defecto = Defecto
                };

                using (DataAccess db = new DataAccess())
                {
                    db.InsertUsuario(p);
                }
            });

            Update = new Command(() =>
            {
                Usuario p = new Usuario()
                {
                    ID = ID,
                    User = User,
                    Password = Password,
                    Persona = Persona,
                    Defecto = Defecto
                };

                using (DataAccess db = new DataAccess())
                {
                    db.UpdateUsuario(p);
                }
            });

            Delete = new Command(() =>
            {
                Usuario p = new Usuario()
                {
                    ID = ID,
                    User = User,
                    Password = Password,
                    Persona = Persona,
                    Defecto = Defecto
                };

                using (DataAccess db = new DataAccess())
                {
                    db.DeleteUsuario(p);
                }
            });

            New = new Command(() =>
            {
                Usuario p = new Usuario()
                {
                    User = string.Empty,
                    Password = string.Empty,
                    Persona = Persona,
                    Defecto = Defecto
                };
            });
        }
        #endregion

        #region Methods

        #endregion
    }
}
