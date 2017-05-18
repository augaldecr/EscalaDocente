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
        }

        private void lstIndicadores_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}