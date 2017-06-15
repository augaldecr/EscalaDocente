using RegistroDocente.Controlador;
using RegistroDocente.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RegistroDocente.ViewModels
{
    public class PaisesViewModel : Pais
    {
        #region Commands
        public ICommand Insert { get; private set; }
        public ICommand Update { get; private set; }
        public ICommand Delete { get; private set; }
        public ICommand New { get; private set; }
        public ICommand Cancel { get; private set; }
        private ObservableCollection<Pais> ListadoPaises;
        private Pais SelectedPais;
        #endregion

        #region Constructor
        public PaisesViewModel()
        {
            Insert = new Command(() =>
            {
                Pais p = new Pais()
                {
                     Nombre = Nombre,
                };

                using (DataAccess db = new DataAccess())
                {
                    try
                    {
                        db.InsertPais(p);
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
                Pais p = new Pais()
                {
                    ID = ID,
                    Nombre = Nombre,
                };

                using (DataAccess db = new DataAccess())
                {
                    try
                    {
                        db.UpdatePais(p);
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
                Pais p = new Pais()
                {
                    ID = ID,
                    Nombre = Nombre,
                };

                    using (DataAccess db = new DataAccess())
                    {
                        try
                        {
                            db.DeletePais(p);
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
                    Nombre = string.Empty,
                };
            });
        }
        #endregion

        #region Properties
        public ObservableCollection<Pais> listadoPaises
        {
            get
            {
                if (ListadoPaises == null)
                {
                    llenarListadoPersonas();
                }
                return ListadoPaises;
            }
            set
            {
                ListadoPaises = value;
            }
        }

        public Pais selectedPais
        {
            get
            {
                return selectedPais;
            }
            set
            {
                if (selectedPais != value)
                {
                    selectedPais = value;
                    OnPropertyChanged("SelectedPais");

                    //editPaisPage(SelectedPais);
                }
            }
        }
        #endregion

        #region Methods

        private async void editPaisPage(Pais pais)
        {
            //await Application.Current.MainPage.Navigation.PushModalAsync(new PaisPage(pais));
        }

        private async void openAlert(string title, string message, string button)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, button);
        }

        public void llenarListadoPaises()
        {
            using (DataAccess db = new DataAccess())
            {
                ObservableCollection<Pais> paises = new ObservableCollection<Pais>(db.GetPais());
                ListadoPaises = paises;
            }
        }
        #endregion
    }
}
