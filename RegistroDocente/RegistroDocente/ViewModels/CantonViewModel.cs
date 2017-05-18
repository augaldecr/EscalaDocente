using RegistroDocente.Controlador;
using RegistroDocente.Models;
using RegistroDocente.Vistas;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace RegistroDocente.ViewModels
{
    public class CantonViewModel : Canton
    {
        #region Commands
        public ICommand Insert { get; private set; }
        public ICommand Update { get; private set; }
        public ICommand Delete { get; private set; }
        public ICommand New { get; private set; }
        public ICommand NewCanton { get; private set; }
        public ICommand Cancel { get; private set; }
        private ObservableCollection<Canton> ListadoCantones;
        private Canton SelectedCanton;
        #endregion

        #region Constructor
        public CantonViewModel()
        {
            Comandos();
        }

        public CantonViewModel(Canton canton)
        {
            Comandos();
            this.Nombre = canton.Nombre;
        }
        #endregion

        #region Properties
        public ObservableCollection<Canton> listadoAnhos
        {
            get
            {
                if (ListadoCantones == null)
                {
                    llenarListadoCantones();
                }
                return ListadoCantones;
            }
            set
            {
                ListadoCantones = value;
            }
        }

        public Canton selectedCanton
        {
            get
            {
                return SelectedCanton;
            }
            set
            {
                if (SelectedCanton != value)
                {
                    SelectedCanton = value;
                    OnPropertyChanged("SelectedCanton");

                    editCantonPage(SelectedCanton);
                }
            }
        }
        #endregion

        #region Methods

        private async void editCantonPage(Canton canton)
        {
            //await Application.Current.MainPage.Navigation.PushModalAsync(new CantonPage(canton));
        }

        private async void openNewCantonPage()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new AnhoPage());
        }

        private async void openAlert(string title, string message, string button)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, button);
        }

        public void llenarListadoCantones()
        {
            using (DataAccess db = new DataAccess())
            {
                ObservableCollection<Canton> Cantones = new ObservableCollection<Canton>(db.GetCantones());
                ListadoCantones = Cantones;
            }
        }

        private void Comandos()
        {
            Insert = new Command(() =>
            {
                Canton obj = new Canton()
                {
                    Nombre = Nombre,
                };

                using (DataAccess db = new DataAccess())
                {
                    try
                    {
                        db.InsertCanton(obj);
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
                Canton obj = new Canton()
                {
                    ID = ID,
                    Nombre = Nombre,
                };

                using (DataAccess db = new DataAccess())
                {
                    try
                    {
                        db.UpdateCanton(obj);
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
                Canton obj = new Canton()
                {
                    ID = ID,
                    Nombre = Nombre,
                };
                using (DataAccess db = new DataAccess())
                {
                    try
                    {
                        db.DeleteCanton(obj);
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
                Canton obj = new Canton()
                {
                    Nombre = string.Empty,
                };
            });

            NewCanton = new Command(() => {
                openNewCantonPage();
            });


            Cancel = new Command(() =>
            {
                Application.Current.MainPage.Navigation.PopModalAsync();
            });
        }
        #endregion

    }
}
