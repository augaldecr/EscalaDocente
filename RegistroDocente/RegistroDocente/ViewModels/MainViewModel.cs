using RegistroDocente.Vistas;
using System.Windows.Input;
using Xamarin.Forms;

namespace RegistroDocente.ViewModels
{
    public class MainViewModel
    {
        #region Attributtes
        public ICommand Periodos { get; set; }
        public ICommand Instituciones { get; set; }
        public ICommand Asignaturas { get; set; }
        public ICommand Secciones { get; set; }
        public ICommand Horarios { get; set; }
        public ICommand Porcentajes { get; set; }
        public ICommand Ajustes { get; set; }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            Periodos = new Command(() => {
                PeriodosCommand();
            });
            Instituciones = new Command(() => {
                App.Current.MainPage.DisplayAlert("Aviso", "Tu puta madre", "Aceptar");
            });
            Asignaturas = new Command(() => {
                App.Current.MainPage.DisplayAlert("Aviso", "Tu puta madre", "Aceptar");
            });
            Secciones = new Command(() => {
                App.Current.MainPage.DisplayAlert("Aviso", "Tu puta madre", "Aceptar");
            });
            Horarios = new Command(() => {
                App.Current.MainPage.DisplayAlert("Aviso", "Tu puta madre", "Aceptar");
            });
            Porcentajes = new Command(() => {
                App.Current.MainPage.DisplayAlert("Aviso", "Tu puta madre", "Aceptar");
            });
            Ajustes = new Command(() => {
                App.Current.MainPage.DisplayAlert("Aviso", "Tu puta madre", "Aceptar");
            });
        }
        #endregion

        #region Commands
        private async void PeriodosCommand()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new PeriodosPage());
        }
        #endregion
    }
}
