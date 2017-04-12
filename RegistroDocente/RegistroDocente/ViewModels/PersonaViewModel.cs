using RegistroDocente.Controlador;
using RegistroDocente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RegistroDocente.ViewModels
{
    public class PersonaViewModel : Persona
    {
        #region Commands
        public ICommand Insert { get; private set; }
        public ICommand Update { get; private set; }
        public ICommand Delete { get; private set; }
        public ICommand New { get; private set; }
        #endregion

        #region Constructor
        public PersonaViewModel()
        {
            Insert = new Command(() =>
            {
                Persona p = new Persona()
                {
                    Cedula = Cedula,
                    Nombre = Nombre,
                    Apellido1 = Apellido1,
                    Apellido2 = Apellido2,
                    FechaNacimiento = FechaNacimiento,
                    Genero = Genero,
                    Email = Email,
                    Celular = Celular,
                    Telefono = Telefono
                };

                using(DataAccess db = new DataAccess())
                {
                    db.InsertPersona(p);
                }
            });

            Update = new Command(() =>
            {
                Persona p = new Persona()
                {
                    ID = ID,
                    Cedula = Cedula,
                    Nombre = Nombre,
                    Apellido1 = Apellido1,
                    Apellido2 = Apellido2,
                    FechaNacimiento = FechaNacimiento,
                    Genero = Genero,
                    Email = Email,
                    Celular = Celular,
                    Telefono = Telefono
                };

                using (DataAccess db = new DataAccess())
                {
                    db.UpdatePersona(p);
                }
            });

            Delete = new Command(() =>
            {
                Persona p = new Persona()
                {
                    ID = ID,
                    Cedula = Cedula,
                    Nombre = Nombre,
                    Apellido1 = Apellido1,
                    Apellido2 = Apellido2,
                    FechaNacimiento = FechaNacimiento,
                    Genero = Genero,
                    Email = Email,
                    Celular = Celular,
                    Telefono = Telefono
                };

                using (DataAccess db = new DataAccess())
                {
                    db.DeletePersona(p);
                }
            });

            New = new Command(() =>
            {
                Persona p = new Persona()
                {
                    Cedula = string.Empty,
                    Nombre = string.Empty,
                    Apellido1 = string.Empty,
                    Apellido2 = string.Empty,
                    FechaNacimiento = DateTime.Now,
                    Genero = 0,
                    Email = string.Empty,
                    Celular = string.Empty,
                    Telefono = string.Empty
                };
            });
        }
        #endregion

        #region Methods

        #endregion
    }
}
