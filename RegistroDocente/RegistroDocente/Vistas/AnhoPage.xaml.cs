using RegistroDocente.Models;
using RegistroDocente.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RegistroDocente.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnhoPage : ContentPage
    {
        public AnhoPage()
        {
            InitializeComponent();
            btnActualizar.IsVisible = false;
            btnDelete.IsVisible = false;
        }

        public AnhoPage(Anho anho)
        {
            AnhoViewModel a = new AnhoViewModel(anho);
            InitializeComponent();
            btnGuardar.IsVisible = false;
            btnNew.IsVisible = false;
            BindingContext = a;
        }
    }
}
