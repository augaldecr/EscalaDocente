using RegistroDocente.Controlador;
using RegistroDocente.Models;
using RegistroDocente.Vistas;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace RegistroDocente.ViewModels
{
    public class DistritoViewModel : Distrito
    {
        #region Commands
        public ICommand Insert { get; private set; }
        public ICommand Update { get; private set; }
        public ICommand Delete { get; private set; }
        public ICommand New { get; private set; }
        public ICommand Cancel { get; private set; }
        private ObservableCollection<Distrito> ListadoDistritos;
        private Distrito SelectedDistrito;
        #endregion

        #region Constructor
        public DistritoViewModel()
        {
            Insert = new Command(() =>
            {
                Distrito p = new Distrito()
                {
                    Nombre = Nombre,
                    Canton = Canton,
                };

                using (DataAccess db = new DataAccess())
                {
                    try
                    {
                        db.InsertDistrito(p);
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
                Distrito p = new Distrito()
                {
                    ID = ID,
                    Nombre = Nombre,
                    Canton = Canton,
                };

                using (DataAccess db = new DataAccess())
                {
                    try
                    {
                        db.UpdateDistrito(p);
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
                Distrito p = new Distrito()
                {
                    ID = ID,
                    Nombre = Nombre,
                    Canton = Canton,
                };
                    using (DataAccess db = new DataAccess())
                    {
                        try
                        {
                            db.DeleteDistrito(p);
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
                Distrito p = new Distrito()
                {
                    Nombre = string.Empty,
                    Canton = 0,
                };
            });

            Cancel = new Command(() =>
            {
                Application.Current.MainPage.Navigation.PopModalAsync();
            });
        }
        #endregion

        #region Properties
        public ObservableCollection<Distrito> listadoDistrito
        {
            get
            {
                if (ListadoDistritos == null)
                {
                    llenarListadoDistrito();
                }
                return ListadoDistritos;
            }
            set
            {
                ListadoDistritos = value;
            }
        }

        public Distrito selectedDistrito
        {
            get
            {
                return SelectedDistrito;
            }
            set
            {
                if (SelectedDistrito != value)
                {
                    SelectedDistrito = value;
                    OnPropertyChanged("SelectedDistrito");

                    //editPersonaPage(SelectedDistrito);
                }
            }
        }
        #endregion

        #region Methods

        private async void editDistritoPage(Distrito distrito)
        {
            //await Application.Current.MainPage.Navigation.PushModalAsync(new DistritoPage(distrito));
        }

        private async void openAlert(string title, string message, string button)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, button);
        }

        public void llenarListadoDistrito()
        {
            using (DataAccess db = new DataAccess())
            {
                ObservableCollection<Distrito> distritos = new ObservableCollection<Distrito>(db.GetDistritos());
                ListadoDistritos = distritos;
            }
        }
        #endregion
    }
}
