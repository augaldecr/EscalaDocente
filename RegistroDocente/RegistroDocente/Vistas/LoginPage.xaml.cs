using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RegistroDocente.Vistas
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public static bool logueado = false;
        public LoginPage()
        {
            InitializeComponent();

            btnIngresar.Clicked += BtnIngresar_Clicked;
            btnRegistrarse.Clicked += BtnRegistrarse_Clicked;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (logueado == true)
            {
                BtnIngresar_Clicked(null, null);
            }
        }

        private async void BtnRegistrarse_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegistraUsuarioPage());
        }

        private async void BtnIngresar_Clicked(object sender, EventArgs e)
        {
            logueado = true;
            await Navigation.PushModalAsync(new HomePage());
            elStack.IsVisible = false;
        }
    }
}
