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
    public partial class MatriculasPage : ContentPage
    {
        ObservableCollection<Persona> estudiantes = new ObservableCollection<Persona>();
        public MatriculasPage()
        {
            InitializeComponent();
            lstMatricula.ItemsSource = estudiantes;
        }

        private void pckInstituciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pckInstituciones.SelectedIndex == -1)
            {
                pckSecciones.Items.Clear();
                pckSecciones.Items.Add("Seleccione una institución");
            }
            else if (pckInstituciones.SelectedIndex == 0)
            {
                pckSecciones.Items.Clear();
                pckSecciones.Items.Add("2-1");
                pckSecciones.Items.Add("2-2");
            }
            else if (pckInstituciones.SelectedIndex == 1)
            {
                pckSecciones.Items.Clear();
                pckSecciones.Items.Add("3-1");
                pckSecciones.Items.Add("4-2");
            }
            else if (pckInstituciones.SelectedIndex == 2)
            {
                pckSecciones.Items.Clear();
                pckSecciones.Items.Add("7-1");
                pckSecciones.Items.Add("7-2");
                pckSecciones.Items.Add("7-3");
                pckSecciones.Items.Add("7-4");
                pckSecciones.Items.Add("7-5");
                pckSecciones.Items.Add("7-6");
                pckSecciones.Items.Add("7-7");
            }
        }

        private void pckSecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pckInstituciones.SelectedIndex == 0)
            {
                if (pckSecciones.SelectedIndex==0)
                {
                    estudiantes.Clear();
                    estudiantes.Add(new Persona { Cedula = "1-0111-0111", Apellido1 = "Perez", Apellido2 = "Perez", Nombre = "Carlos",
                                                  FechaNacimiento = new DateTime(2008, 02, 01), Genero = 0 });
                    estudiantes.Add(new Persona { Cedula = "2-0222-0222", Apellido1 = "Suarez", Apellido2 = "Suarez", Nombre = "Ana",
                                                  FechaNacimiento = new DateTime(2008,02,01), Genero = 1 });
                    estudiantes.Add(new Persona { Cedula = "3-0333-0333", Apellido1 = "Brenes", Apellido2 = "Brenes", Nombre = "José",
                                                  FechaNacimiento = new DateTime(2008, 02, 01), Genero = 1 });
                }
                else if (pckSecciones.SelectedIndex == 1)
                {
                    estudiantes.Clear();
                    estudiantes.Add(new Persona
                    {
                        Cedula = "4-0444-0444",
                        Apellido1 = "Ibrahimovic",
                        Apellido2 = "Ibrahimovic",
                        Nombre = "Slathan",
                        FechaNacimiento = new DateTime(2008, 02, 01),
                        Genero = 0
                    });
                    estudiantes.Add(new Persona
                    {
                        Cedula = "5-0555-0555",
                        Apellido1 = "Gaucho",
                        Apellido2 = "Gaucho",
                        Nombre = "Ronaldinho",
                        FechaNacimiento = new DateTime(2008, 02, 01),
                        Genero = 1
                    });
                    estudiantes.Add(new Persona
                    {
                        Cedula = "6-0661-0661",
                        Apellido1 = "Lagos",
                        Apellido2 = "Lagos",
                        Nombre = "Cristhian",
                        FechaNacimiento = new DateTime(2008, 02, 01),
                        Genero = 1
                    });
                }
            }
            else if (pckInstituciones.SelectedIndex == 1)
            {
                estudiantes.Clear();
            }
            else if (pckInstituciones.SelectedIndex == 2)
            {
                estudiantes.Clear();
            }
        }
    }
}