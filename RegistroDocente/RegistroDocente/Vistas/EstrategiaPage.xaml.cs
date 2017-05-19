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
    public partial class EstrategiaPage : ContentPage
    {
        public EstrategiaPage()
        {
            InitializeComponent();
        }

        public EstrategiaPage(string obj)
        {
            InitializeComponent();
            txtTexto.Text = obj;
            txtEstrategias.Text = "Focalización: Se formula una pregunta: ¿Por qué son importantes las máquinas? Exploración :Realización de diferentes actividades que permitan vivenciar la utilidad de las máquinas en la vida cotidiana, entre ellas: rasgar un círculo de papel con la mano y luego cortarlo con una tijera,  tratar de cortar con la mano un pedazo de hilo o lana, luego hacerlo con la tijera, realización de comparaciones en los que se evidencien las diferencias en las actividades realizadas, haciendo mención del objeto (máquina), que se utilizó  con el propósito de hacer más fácil esos trabajos, logrando involucrar a los estudiantes con el tema en cuestión. Contrastación: Se observa un video sobre la importancia de las máquinas en la vida cotidiana. Participación en una plenaria sobre el video observado, expresando su opinión sobre la actividad, dando respuesta a las interrogantes lanzadas por el docente, involucrando a los estudiantes con la importancia de las máquinas y la utilidad de estas al facilitarnos el trabajo cotidiano, comparando la vida real con la actividad realizada. Análisis: Trascripción de un pequeño texto sobre el tema en estudio, apoyado en la página 64 del libro Trampolín, ilustrado con ejemplos de máquinas utilizadas cotidianamente ( pala, destornillador, tajador, tijera, tornillo, cuchillo) indicando la utilidad que nos da cada una al realizar diferentes trabajos, anotando en su cuaderno  información sobre el contenido desarrollado. Denotación y connotación de una lámina facilitada por la docente, en la cual los estudiantes identifiquen las dificultades que presentan cada uno da las personas de la ilustración. Participación en un comentario en el cual los niños mencionen diferentes objetos (máquinas), que puedan utilizar esas personas con el propósito de hacer más fáciles esos trabajos, logrando evidenciar la comprensión del tema en cuestión. Participación en un comentario, haciendo mención del uso correcto que se le debe dar a estas máquinas, poniendo en práctica las medidas necesarias que favorezcan su salud integral y la de sus compañeros, promoviendo el uso correcto de estas.";
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(true);
        }

        private void btnCancelar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(true);
        }
    }
}