using RegistroDocente.Controlador;
using RegistroDocente.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace RegistroDocente.ViewModels
{
    public class PeriodosViewModel : Periodo
    {
        #region Atributtes
        public ICommand Insert { get; private set; }
        public ICommand Update { get; private set; }
        public ICommand Delete { get; private set; }
        public ICommand New { get; private set; }
        public ObservableCollection<Periodo> ListadoPeriodos;
        #endregion

        #region Constructors
        public PeriodosViewModel()
        {
            Insert = new Command(() =>
            {
                Periodo p = new Periodo()
                {
                    Nombre = Nombre,
                    CursoLectivo = CursoLectivo,
                    FechaInicio = FechaInicio,
                    FechaFin = FechaFin,
                };

                using (DataAccess db = new DataAccess())
                {
                    db.InsertPeriodo(p);
                }
            });

            Update = new Command(() =>
            {
                Periodo p = new Periodo()
                {
                    ID = ID,
                    Nombre = Nombre,
                    CursoLectivo = CursoLectivo,
                    FechaInicio = FechaInicio,
                    FechaFin = FechaFin,
                };

                using (DataAccess db = new DataAccess())
                {
                    db.UpdatePeriodo(p);
                }
            });

            Delete = new Command(() =>
            {
                Periodo p = new Periodo()
                {
                    ID = ID,
                    Nombre = Nombre,
                    CursoLectivo = CursoLectivo,
                    FechaInicio = FechaInicio,
                    FechaFin = FechaFin,
                };

                using (DataAccess db = new DataAccess())
                {
                    db.DeletePeriodo(p);
                }
            });

            New = new Command(() =>
            {
                Periodo p = new Periodo()
                {
                    ID = 0,
                    Nombre = string.Empty,
                    CursoLectivo = 0,
                    FechaInicio = DateTime.Now,
                    FechaFin = DateTime.Now,
                };
            });
        }
        #endregion

        #region Properties
        public ObservableCollection<Periodo> listadoPeriodos
        {
            get
            {
                if (ListadoPeriodos==null)
                {
                    llenarListadoPeriodos();
                }
                return ListadoPeriodos;
            }
            set
            {
                ListadoPeriodos = value;
            }
        }
        #endregion

        #region Methods
        public void llenarListadoPeriodos()
        {
            using (DataAccess db = new DataAccess())
            {
                ObservableCollection<Periodo> periodos = new ObservableCollection<Periodo>(db.GetPeriodos());
                ListadoPeriodos = periodos;
            }
        }
        #endregion
    }
}
