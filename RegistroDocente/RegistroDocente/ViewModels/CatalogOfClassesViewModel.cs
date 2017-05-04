using RegistroDocente.Models;
using RegistroDocente.Vistas;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace RegistroDocente.ViewModels
{
    public class CatalogOfClassesViewModel
    {
        #region Commands
        public ICommand Anho { get; set; }
        public ICommand Persona { get; set; }
        public ICommand Periodo { get; set; }
        public ICommand Institucione { get; set; }
        public ICommand Asignatura { get; set; }
        public ICommand Seccione { get; set; }
        public ICommand Horario { get; set; }
        public ICommand Porcentaje { get; set; }
        #endregion

        #region Constructors
        public CatalogOfClassesViewModel()
        {
            Anho = new Command(() => {
                AnhosCommand();
            });
            Persona = new Command(() => {
                PersonasCommand();
            });
            Periodo = new Command(() => {
                PeriodosCommand();
            });
        }
        #endregion

        #region Methods
        private async void AnhosCommand()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new AnhosPage());
        }

        private async void PersonasCommand()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new PersonasPage());
        }

        private async void PeriodosCommand()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new PeriodosPage());
        }
        #endregion
    }
}
