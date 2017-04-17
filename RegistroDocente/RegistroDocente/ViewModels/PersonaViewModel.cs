using RegistroDocente.Controlador;
using RegistroDocente.Models;
using RegistroDocente.Vistas;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace RegistroDocente.ViewModels
{
    public class PersonaViewModel : Persona
    {
        #region Commands
        public ICommand Insert { get; private set; }
        public ICommand Update { get; private set; }
        public ICommand Delete { get; private set; }
        public ICommand New { get; private set; }
        public ICommand NewUserPerson { get; private set; }
        #endregion

        #region Constructor
        public PersonaViewModel()
        {
            Insert = new Command(() =>
            {
                Persona p = new Persona()
                {
                    Cedula = Cedula,
                    Nombre = Nombre,
                    Apellido1 = Apellido1,
                    Apellido2 = Apellido2,
                    FechaNacimiento = FechaNacimiento,
                    Genero = Genero,
                    Email = Email,
                    Celular = Celular,
                    Telefono = Telefono
                };

                using (DataAccess db = new DataAccess())
                {
                    try
                    {
                        db.InsertPersona(p);
                    }
                    catch (Exception ex)
                    {
                        Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Aceptar");
                    }
                }
            });

            Update = new Command(() =>
            {
                Persona p = new Persona()
                {
                    ID = ID,
                    Cedula = Cedula,
                    Nombre = Nombre,
                    Apellido1 = Apellido1,
                    Apellido2 = Apellido2,
                    FechaNacimiento = FechaNacimiento,
                    Genero = Genero,
                    Email = Email,
                    Celular = Celular,
                    Telefono = Telefono
                };

                using (DataAccess db = new DataAccess())
                {
                    try
                    {
                        db.UpdatePersona(p);
                    }
                    catch (Exception ex)
                    {
                        Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Aceptar");
                    }
                }
            });

            Delete = new Command(() =>
            {
                Persona p = new Persona()
                {
                    ID = ID,
                    Cedula = Cedula,
                    Nombre = Nombre,
                    Apellido1 = Apellido1,
                    Apellido2 = Apellido2,
                    FechaNacimiento = FechaNacimiento,
                    Genero = Genero,
                    Email = Email,
                    Celular = Celular,
                    Telefono = Telefono
                };

                using (DataAccess db = new DataAccess())
                {
                    try
                    {
                        db.DeletePersona(p);
                    }
                    catch (Exception ex)
                    {
                        Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Aceptar");
                    }
                }
            });

            New = new Command(() =>
            {
                Persona p = new Persona()
                {
                    Cedula = string.Empty,
                    Nombre = string.Empty,
                    Apellido1 = string.Empty,
                    Apellido2 = string.Empty,
                    FechaNacimiento = DateTime.Now,
                    Genero = 0,
                    Email = string.Empty,
                    Celular = string.Empty,
                    Telefono = string.Empty
                };
            });

            NewUserPerson = new Command(() =>
            {
                Persona p = new Persona()
                {
                    Cedula = Cedula,
                    Nombre = Nombre,
                    Apellido1 = Apellido1,
                    Apellido2 = Apellido2,
                    FechaNacimiento = FechaNacimiento,
                    Genero = Genero,
                    Email = Email,
                    Celular = Celular,
                    Telefono = Telefono
                };

                using (DataAccess db = new DataAccess())
                {
                    try
                    {
                        db.InsertPersona(p);
                        openUsuarioPage(p.Cedula);
                    }
                    catch (Exception ex)
                    {
                        openAlert("Error", Utils.Utils.extractException(ex.Message), "Aceptar");
                    }
                }
            });
        }
        #endregion

        #region Methods
        private async void openUsuarioPage(string ced)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new UsuarioPage(ced));
        }

        private async void openAlert(string title, string message, string button)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, button);
        }
        #endregion
    }
}
