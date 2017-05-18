using RegistroDocente.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RegistroDocente.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndicadoresPage : ContentPage
    {
        ObservableCollection<string> indicadores = new ObservableCollection<string>();
        public IndicadoresPage()
        {
            InitializeComponent();
            lstIndicadores.ItemsSource = indicadores;
        }

        public IndicadoresPage(string objetivo)
        {
            InitializeComponent();
            lstIndicadores.ItemsSource = indicadores;
            lblIndicador.Text = objetivo;

            string ind1 = "Señala la importancia de las máquinas en el quehacer cotidiano mediante fichas de trabajo.";
            string ind2 = "Menciona objetos o máquinas que pueden hacer más fácil los trabajos.";
            string ind3 = "Explica la importancia de las máquinas.";

            indicadores.Add(ind1);
            indicadores.Add(ind2);
            indicadores.Add(ind3);
        }

        private void lstIndicadores_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            abreIndicadorPage(e.SelectedItem.ToString());
        }

        private async void abreIndicadorPage(string obj)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new IndicadorPage(obj));
        }
    }
}