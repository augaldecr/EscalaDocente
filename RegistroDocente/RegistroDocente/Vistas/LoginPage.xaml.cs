using RegistroDocente.Utils;
using RegistroDocente.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RegistroDocente.Vistas
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            UsuarioViewModel user = new UsuarioViewModel();
            if (user.DefaultUserExist())
            {
                user.GetIn();
            }
        }
    }
}