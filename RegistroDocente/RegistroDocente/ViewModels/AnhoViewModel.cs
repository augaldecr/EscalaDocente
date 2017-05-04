using RegistroDocente.Controlador;
using RegistroDocente.Models;
using RegistroDocente.Vistas;
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
    public class AnhoViewModel : Anho
    {
        #region Commands
        public ICommand Insert { get; private set; }
        public ICommand Update { get; private set; }
        public ICommand Delete { get; private set; }
        public ICommand New { get; private set; }
        public ICommand NewAnho { get; private set; }
        public ICommand Cancel { get; private set; }
        private ObservableCollection<Anho> ListadoAnhos;
        private Anho SelectedAnho;
        #endregion

        #region Constructor
        public AnhoViewModel()
        {
            Comandos();
        }

        public AnhoViewModel(Anho anho)
        {
            Comandos();
            this.Nombre = anho.Nombre;
        }
        #endregion

        #region Properties
        public ObservableCollection<Anho> listadoAnhos
        {
            get
            {
                if (ListadoAnhos == null)
                {
                    llenarListadoAnhos();
                }
                return ListadoAnhos;
            }
            set
            {
                ListadoAnhos = value;
            }
        }

        public Anho selectedAnho
        {
            get
            {
                return SelectedAnho;
            }
            set
            {
                if (SelectedAnho != value)
                {
                    SelectedAnho = value;
                    OnPropertyChanged("SelectedAnho");

                    editAnhoPage(SelectedAnho);
                }
            }
        }
        #endregion

        #region Methods

        private async void editAnhoPage(Anho anho)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new AnhoPage(anho));
        }

        private async void openNewAnhoPage()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new AnhoPage());
        }

        private async void openAlert(string title, string message, string button)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, button);
        }

        public void llenarListadoAnhos()
        {
            using (DataAccess db = new DataAccess())
            {
                ObservableCollection<Anho> Anhos = new ObservableCollection<Anho>(db.GetAnhos());
                ListadoAnhos = Anhos;
            }
        }

        private void Comandos()
        {
            Insert = new Command(() =>
            {
                Anho obj = new Anho()
                {
                    Nombre = Nombre,
                };

                using (DataAccess db = new DataAccess())
                {
                    try
                    {
                        db.InsertAnho(obj);
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
                Anho obj = new Anho()
                {
                    ID = ID,
                    Nombre = Nombre,
                };

                using (DataAccess db = new DataAccess())
                {
                    try
                    {
                        db.UpdateAnho(obj);
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
                Anho obj = new Anho()
                {
                    ID = ID,
                    Nombre = Nombre,
                };
                using (DataAccess db = new DataAccess())
                {
                    try
                    {
                        db.DeleteAnho(obj);
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
                Anho obj = new Anho()
                {
                    Nombre = string.Empty,
                };
            });

            NewAnho = new Command(() => {
                openNewAnhoPage();
            });


            Cancel = new Command(() =>
            {
                Application.Current.MainPage.Navigation.PopModalAsync();
            });
        }
        #endregion
    }
}
