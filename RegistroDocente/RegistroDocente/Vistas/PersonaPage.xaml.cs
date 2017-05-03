using RegistroDocente.Models;
using RegistroDocente.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RegistroDocente.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonaPage : ContentPage
    {
        public PersonaPage()
        {
            InitializeComponent();
        }

        public PersonaPage(Persona person)
        {
            InitializeComponent();
            BindingContext = person;
        }
    }
}
