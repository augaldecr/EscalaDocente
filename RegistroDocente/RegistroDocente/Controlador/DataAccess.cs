using RegistroDocente.Models;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;

namespace RegistroDocente.Controlador
{
    public class DataAccess : IDisposable
    {
        private SQLiteConnection connection;

        public DataAccess()
        {
            var config = DependencyService.Get<IConfig>();
            connection = new SQLiteConnection(config.Plataforma,
                Path.Combine(config.DirectorioDB, "RegistroDocente.db3"));
            CreaTablas(connection);
        }

        #region Persona
        public void InsertPersona(Persona obj)
        {
            connection.Insert(obj);
        }

        public void UpdatePersona(Persona obj)
        {
            connection.Update(obj);
        }

        public void DeletePersona(Persona obj)
        {
            connection.Delete(obj);
        }

        public Persona GetPersona(string cedula)
        {
            return connection.Table<Persona>().FirstOrDefault(x => x.Cedula == cedula);
        }

        public List<Persona> GetPersonas()
        {
            return connection.Table<Persona>().OrderBy(x => x.Apellido1).ToList();
        }
        #endregion

        #region Usuario
        public void InsertUsuario(Usuario obj)
        {
            connection.Insert(obj);
        }

        public void UpdateUsuario(Usuario obj)
        {
            connection.Update(obj);
        }

        public void DeleteUsuario(Usuario obj)
        {
            connection.Delete(obj);
        }

        public Usuario GetUsuario(int ID)
        {
            return connection.Table<Usuario>().FirstOrDefault(x => x.ID == ID);
        }

        public Usuario GetUsuarioXUser(string user)
        {
            return connection.Table<Usuario>().FirstOrDefault(x => x.User == user);
        }

        public bool GetUsuariosDefault()
        {
            bool contiene = false;

            foreach (var item in connection.Table<Usuario>().OrderBy(x => x.User).ToList())
            {
                if (item.Defecto)
                {
                    contiene = true;
                }
            }
            return contiene;
        }

        public List<Usuario> GetUsuarios()
        {
            return connection.Table<Usuario>().OrderBy(x => x.User).ToList();
        }
        #endregion

        public void Dispose()
        {
            connection.Dispose();
        }

        private void CreaTablas(SQLiteConnection con)
        {
            con.CreateTable<Persona>();
            con.CreateTable<Usuario>();
            /*con.CreateTable<AdecuacionCurricular>();
            con.CreateTable<Anho>();
            con.CreateTable<Asignatura>();
            con.CreateTable<CalificacionXIndicadores>();
            con.CreateTable<Canton>();
            con.CreateTable<CategoriaDocente>();
            con.CreateTable<CicloEducativo>();
            con.CreateTable<Circuito>();
            con.CreateTable<ComponentesPlanEval>();
            con.CreateTable<CursoLectivo>();
            con.CreateTable<Dia>();
            con.CreateTable<Distrito>();
            con.CreateTable<Especialidad>();
            con.CreateTable<Evaluacion>();
            con.CreateTable<FechasNoLectivas>();
            con.CreateTable<Funcionario>();
            con.CreateTable<Genero>();
            con.CreateTable<HorarioDocente>();
            con.CreateTable<InAsistencia>();
            con.CreateTable<Indicador>();
            con.CreateTable<IndicadorAplicado>();
            con.CreateTable<Indicadores>();
            con.CreateTable<Institucion>();
            con.CreateTable<Matricula>();
            con.CreateTable<ModalidadInstitucion>();
            con.CreateTable<Nivel>();
            con.CreateTable<NivelEscolar>();
            con.CreateTable<Pais>();
            con.CreateTable<PaseDeLista>();
            con.CreateTable<Periodo>();
            con.CreateTable<PlanEvaluativo>();
            con.CreateTable<Provincia>();
            con.CreateTable<Puesto>();
            con.CreateTable<Regional>();
            con.CreateTable<Seccion>();
            con.CreateTable<TipoAsignatura>();
            con.CreateTable<TipoEvaluacion>();
            con.CreateTable<TipoInAsistencia>();
            con.CreateTable<TipoMatricula>();
            con.CreateTable<TipoPeriodicidadAsignatura>();
            con.CreateTable<TipoPeriodo>();*/
        }
    }
}
