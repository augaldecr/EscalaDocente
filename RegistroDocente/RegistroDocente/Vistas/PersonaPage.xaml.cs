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
            #region Persona2PersonaViewModel
            PersonaViewModel p = new PersonaViewModel()
            {
                ID = person.ID,
                Cedula = person.Cedula,
                Nombre = person.Nombre,
                Apellido1 = person.Apellido1,
                Apellido2 = person.Apellido2,
                FechaNacimiento = person.FechaNacimiento,
                Genero = person.Genero,
                Email = person.Email,
                Celular = person.Celular,
                Telefono = person.Telefono,
            };
            #endregion
            InitializeComponent();
            BindingContext = p;
        }
    }
}
