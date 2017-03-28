using SQLite.Net.Interop;
using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(RegistroDocente.Droid.Config))]

namespace RegistroDocente.Droid
{
    public class Config : IConfig
    {
        private string directorioDB;

        private ISQLitePlatform plataforma;


        public string DirectorioDB
        {
            get
            {
                if (string.IsNullOrEmpty(directorioDB))
                {
                    directorioDB = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                }
                return directorioDB;
            }
        }

        public ISQLitePlatform Plataforma
        {
            get
            {
                if (plataforma == null)
                {
                    plataforma = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
                }
                return plataforma;
            }
        }
    }
}