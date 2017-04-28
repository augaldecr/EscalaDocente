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
    public class AsignaturaViewModel : Asignatura
    {
        #region Commands
        public ICommand Insert { get; private set; }
        public ICommand Update { get; private set; }
        public ICommand Delete { get; private set; }
        public ICommand New { get; private set; }
        public ObservableCollection<Persona> ListadoAsignaturas;
        #endregion

        #region Constructor
        public AsignaturaViewModel()
        {
            Insert = new Command(() =>
            {
                Asignatura obj = new Asignatura()
                {
                    Nombre = Nombre,
                    Especialidad = Especialidad,
                    TipoAsignatura = TipoAsignatura,
                };

                using (DataAccess db = new DataAccess())
                {
                    try
                    {
                        db.InsertAsignatura(obj);
                    }
                    catch (Exception ex)
                    {
                        Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Aceptar");
                    }
                }
            });

            Update = new Command(() =>
            {
                Asignatura obj = new Asignatura()
                {
                    ID = ID,
                    Nombre = Nombre,
                    Especialidad = Especialidad,
                    TipoAsignatura = TipoAsignatura,
                };

                using (DataAccess db = new DataAccess())
                {
                    try
                    {
                        db.UpdateAsignatura(obj);
                    }
                    catch (Exception ex)
                    {
                        Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Aceptar");
                    }
                }
            });

            Delete = new Command(() =>
            {
                Asignatura p = new Asignatura()
                {
                    ID = ID,
                    Nombre = Nombre,
                    Especialidad = Especialidad,
                    TipoAsignatura = TipoAsignatura,
                };

                using (DataAccess db = new DataAccess())
                {
                    try
                    {
                        db.DeleteAsignatura(p);
                    }
                    catch (Exception ex)
                    {
                        Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Aceptar");
                    }
                }
            });

            New = new Command(() =>
            {
                Asignatura p = new Asignatura()
                {
                    Nombre = string.Empty,
                    Especialidad = 0,
                    TipoAsignatura = 0,
                };
            });
        }
        #endregion

        #region Properties
        public ObservableCollection<Asignatura> listadoAsignaturas
        {
            get
            {
                if (ListadoAsignaturas == null)
                {
                    llenarListadoAsignaturas();
                }
                return ListadoAsignaturas;
            }
            set
            {
                ListadoAsignaturas = value;
            }
        }
        #endregion

        #region Methods
        private async void openAlert(string title, string message, string button)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, button);
        }

        public void llenarListadoAsignaturas()
        {
            using (DataAccess db = new DataAccess())
            {
                ObservableCollection<Asignatura> asignaturas = new ObservableCollection<Asignatura>(db.GetAsignatura());
                ListadoAsignaturas = asignaturas;
            }
        }
        #endregion
    }
}
