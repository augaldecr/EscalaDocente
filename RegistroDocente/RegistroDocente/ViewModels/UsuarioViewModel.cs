using RegistroDocente.Controlador;
using RegistroDocente.Models;
using RegistroDocente.Vistas;
using System.Windows.Input;
using Xamarin.Forms;
using System;

namespace RegistroDocente.ViewModels
{
    public class UsuarioViewModel : Usuario
    {
        #region Commands
        public ICommand Insert { get; private set; }
        public ICommand Update { get; private set; }
        public ICommand Delete { get; private set; }
        public ICommand New { get; private set; }
        public ICommand Login { get; private set; }
        public ICommand Register { get; private set; }
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
                    Defecto = Defecto,
                    PasswordConfirm = PasswordConfirm
                    
                };

                if (Password == PasswordConfirm)
                {
                    try
                    {
                        using (DataAccess db = new DataAccess())
                        {
                            db.InsertUsuario(p);
                            openAlert("Éxito", "Usuario registrado de manera correcta", "Aceptar");
                            goBack();
                            goBack();
                        }
                    }
                    catch (Exception ex)
                    {
                        openAlert("Error", Utils.Utils.extractException(ex.Message), "Aceptar");
                    }
                }
                else
                {
                    openAlert("Aviso", "Las contraseñas no coinciden, reintente", "Aceptar");
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

            Login = new Command(() => { LoginIn(); });

            Register = new Command(() => { RegisterNewUser(); });
        }

        #endregion

        #region Methods
        private async void LoginIn()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new HomePage());
        }

        private async void RegisterNewUser()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new PersonaUsuarioPage());
        }

        private async void openAlert(string title, string message, string button)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, button);
        }

        private async void goBack()
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }
        #endregion
    }
}
