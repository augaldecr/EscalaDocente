using RegistroDocente.Controlador;
using RegistroDocente.Models;
using RegistroDocente.Vistas;
using System;
using System.Collections.ObjectModel;
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
        private ObservableCollection<Persona> ListadoPersonas;
        private Persona SelectedPerson;
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
                Application.Current.MainPage.Navigation.PopModalAsync();
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
                Application.Current.MainPage.Navigation.PopModalAsync();
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
                Application.Current.MainPage.Navigation.PopModalAsync();
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

        #region Properties
        public ObservableCollection<Persona> listadoPersonas
        {
            get
            {
                if (ListadoPersonas == null)
                {
                    llenarListadoPersonas();
                }
                return ListadoPersonas;
            }
            set
            {
                ListadoPersonas = value;
            }
        }

        public Persona selectedPerson
        {
            get
            {
                return SelectedPerson;
            }
            set
            {
                if (SelectedPerson != value)
                {
                    SelectedPerson = value;
                    OnPropertyChanged("SelectedPerson");

                    editPersonaPage(SelectedPerson);
                }
            }
        }
        #endregion

        #region Methods

        private async void editPersonaPage(Persona person)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new PersonaPage(person));
        }

        private async void openUsuarioPage(string ced)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new UsuarioPage(ced));
        }

        private async void openAlert(string title, string message, string button)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, button);
        }

        public void llenarListadoPersonas()
        {
            using (DataAccess db = new DataAccess())
            {
                ObservableCollection<Persona> personas = new ObservableCollection<Persona>(db.GetPersonas());
                ListadoPersonas = personas;
            }
        }
        #endregion
    }
}
