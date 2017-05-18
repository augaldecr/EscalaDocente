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
    public partial class IndicadorPage : ContentPage
    {
        public IndicadorPage()
        {
            InitializeComponent();
        }

        public IndicadorPage(string obj)
        {
            InitializeComponent();
            txtTexto.Text = obj;
        }
    }
}