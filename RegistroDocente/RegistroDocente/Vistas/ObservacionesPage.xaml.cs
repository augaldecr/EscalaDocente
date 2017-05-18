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
    public partial class ObservacionesPage : ContentPage
    {
        ObservableCollection<ObjetivoGeneral> objetivos = new ObservableCollection<ObjetivoGeneral>();
        ObservableCollection<string> indicadores = new ObservableCollection<string>();
        public ObservacionesPage()
        {
            InitializeComponent();
            lstIndicadores.ItemsSource = indicadores;
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

        private void pckMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pckMaterias.SelectedIndex == 0)
            {
                indicadores.Clear();
                indicadores.Add("Aplicación de estrategias que buscan fomentar la lectura apreciativa de textos literarios y no literarios al leer y producir en forma habitual variedad de textos. (2.1)");
                indicadores.Add("Interpretación de la lectura de textos literarios: cuentos, poemas, fábulas, leyendas, otros. (3.1)");
                indicadores.Add("Audición comprensiva de textos literarios: cuentos, fábulas, leyendas, poemas, piezas musicales, entre otras con temáticas significativas, interesándose y disfrutando de la literatura; habituándose a ella. (3.1)");
                indicadores.Add("Reconstrucción de diversos textos literarios: cuentos, poemas, leyendas, otros, a partir de aspectos evidenciados en la portada, las ilustraciones, entre otros. (2.1)");
            }
            else if (pckMaterias.SelectedIndex == 1)
            {
                indicadores.Clear();
                indicadores.Add("Relacionar los cambios de estados del agua con el calor.");
                indicadores.Add("Inferir la relación del sol y los cambios de estado del agua que ocurren en la naturaleza.");
                indicadores.Add("Reconocer algunos ejemplos de máquinas y su uso en la vida cotidiana.");
                indicadores.Add("Formular la noción de máquina, a partir de la importancia del uso de las máquinas en el quehacer humano. ");
            }
            else if (pckMaterias.SelectedIndex == 2 || pckMaterias.SelectedIndex == 3 ||
                     pckMaterias.SelectedIndex == 4 || pckMaterias.SelectedIndex == 5)
            {
                indicadores.Clear();
            }
        }

        private void pckObjetivos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstIndicadores_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}