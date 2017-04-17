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

        #region Periodo
        public void InsertPeriodo(Periodo obj)
        {
            try
            {
                connection.Insert(obj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdatePeriodo(Periodo obj)
        {
            try
            {
                connection.Update(obj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeletePeriodo(Periodo obj)
        {
            try
            {
                connection.Delete(obj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Periodo GetPeriodo(int id)
        {
            try
            {
                return connection.Table<Periodo>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Periodo> GetPeriodos()
        {
            try
            {
                return connection.Table<Periodo>().OrderBy(x => x.FechaInicio).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Persona
        public void InsertPersona(Persona obj)
        {
            try
            {
                connection.Insert(obj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdatePersona(Persona obj)
        {
            try
            {
                connection.Update(obj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeletePersona(Persona obj)
        {
            try
            {
                connection.Delete(obj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Persona GetPersona(string cedula)
        {
            try
            {
                return connection.Table<Persona>().FirstOrDefault(x => x.Cedula == cedula);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Persona> GetPersonas()
        {
            try
            {
                return connection.Table<Persona>().OrderBy(x => x.Apellido1).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Usuario
        public void InsertUsuario(Usuario obj)
        {
            try
            {
                connection.Insert(obj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateUsuario(Usuario obj)
        {
            try
            {
                connection.Update(obj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteUsuario(Usuario obj)
        {
            try
            {
                connection.Delete(obj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Usuario GetUsuario(int ID)
        {
            try
            {
                return connection.Table<Usuario>().FirstOrDefault(x => x.ID == ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Usuario GetUsuarioXUser(string user)
        {
            try
            {
                return connection.Table<Usuario>().FirstOrDefault(x => x.User == user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool GetUsuariosDefault()
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Usuario> GetUsuarios()
        {
            try
            {
                return connection.Table<Usuario>().OrderBy(x => x.User).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
            con.CreateTable<PaseDeLista>();*/
            con.CreateTable<Periodo>();
            /*con.CreateTable<PlanEvaluativo>();
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
