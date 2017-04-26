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
                            OpenAlert("Éxito", "Usuario registrado de manera correcta", "Aceptar");
                            GoBack();
                            GoBack();
                        }
                    }
                    catch (Exception ex)
                    {
                        OpenAlert("Error", Utils.Utils.extractException(ex.Message), "Aceptar");
                    }
                }
                else
                {
                    OpenAlert("Aviso", "Las contraseñas no coinciden, reintente", "Aceptar");
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

            Login = new Command(() => {
                GetIn();
            });

            Register = new Command(() => { RegisterNewUser(); });
        }
        #endregion

        #region Methods
        private async void LoginIn(Usuario user)
        {
            using (DataAccess db1 = new DataAccess())
            {
                try
                {
                    if (db1.TryUsuario(user.User, user.Password))
                    {
                        Usuario theUser = db1.GetUsuarioXUser(user.User);
                        theUser.Defecto = user.Defecto;
                        db1.UpdateUsuario(theUser);
                        await Application.Current.MainPage.Navigation.PushModalAsync(new HomePage());
                    }
                    else
                    {
                        OpenAlert("Error", "Ingreso incorrecto", "Aceptar");
                    }
                }
                catch (Exception ex)
                {
                    OpenAlert("Error",ex.Message, "Aceptar");
                }
            }
        }

        private async void RegisterNewUser()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new PersonaUsuarioPage());
        }

        public void GetIn()
        {
            using (DataAccess db = new DataAccess())
            {
                if (db.GetUsuariosDefault())
                {
                    LoginIn(db.GetUsuarioDefault());
                }
                else
                {
                    /*Usuario user = new Usuario()
                    {
                        User = User,
                        Password = Password,
                        Defecto = Defecto,
                    };
                    LoginIn(user);*/
                    OpenAlert("Error", "Ingreso incorrecto", "Aceptar");
                    return;
                }
            }
        }

        private async void OpenAlert(string title, string message, string button)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, button);
        }

        private async void GoBack()
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }

        public bool DefaultUserExist()
        {
            using(DataAccess db = new DataAccess())
            {
                if (db.GetUsuariosDefault())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion
    }
}
