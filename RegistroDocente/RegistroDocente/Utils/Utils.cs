using System.Linq;
using Xamarin.Forms;

namespace RegistroDocente.Utils
{
    public class Utils
    {
        public static string extractException(string excep)
        {
            ResourceDictionary dict = Application.Current.Resources;

            string word = excep.Split(' ').Last().Split('.').Last();
            string message = dict["MissingText"].ToString();
            return string.Format("{0} {1}", message, word);
        }

        private async void openAlert(string title, string message, string button)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, button);
        }
    }
}
