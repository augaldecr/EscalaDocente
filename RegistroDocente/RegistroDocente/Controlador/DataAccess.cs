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

        #region CRUDOfClasses
        #region Anho
        public void InsertAnho(Anho obj)
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

        public void UpdateAnho(Anho obj)
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

        public void DeleteAnho(Anho obj)
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

        public Anho GetAnho(int id)
        {
            try
            {
                return connection.Table<Anho>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Anho> GetAnhos()
        {
            try
            {
                return connection.Table<Anho>().OrderBy(x => x.Nombre).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Asignatura
        public void InsertAsignatura(Asignatura obj)
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

        public void UpdateAsignatura(Asignatura obj)
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

        public void DeleteAsignatura(Asignatura obj)
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

        public Asignatura GetAsignatura(int id)
        {
            try
            {
                return connection.Table<Asignatura>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Asignatura> GetAsignatura()
        {
            try
            {
                return connection.Table<Asignatura>().OrderBy(x => x.Nombre).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region CategoriaDocente
        public void InsertCategoriaDocente(CategoriaDocente obj)
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

        public void UpdateCategoriaDocente(CategoriaDocente obj)
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

        public void DeleteCategoriaDocente(CategoriaDocente obj)
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

        public CategoriaDocente GetCategoriaDocente(int id)
        {
            try
            {
                return connection.Table<CategoriaDocente>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<CategoriaDocente> GetCategoriasDocentes()
        {
            try
            {
                return connection.Table<CategoriaDocente>().OrderBy(x => x.Nombre).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region CursoLectivo
        public void InsertCursoLectivo(CursoLectivo obj)
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

        public void UpdateCursoLectivo(CursoLectivo obj)
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

        public void DeleteCursoLectivo(CursoLectivo obj)
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

        public CursoLectivo GetCursoLectivo(int id)
        {
            try
            {
                return connection.Table<CursoLectivo>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<CursoLectivo> GetCursosLectivos()
        {
            try
            {
                return connection.Table<CursoLectivo>().OrderBy(x => x.Nombre).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Distrito
        public void InsertDistrito(Distrito obj)
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

        public void UpdateDistrito(Distrito obj)
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

        public void DeleteDistrito(Distrito obj)
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

        public Distrito GetDistrito(int id)
        {
            try
            {
                return connection.Table<Distrito>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Distrito> GetDistritos()
        {
            try
            {
                return connection.Table<Distrito>().OrderBy(x => x.Nombre).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Funcionario
        public void InsertFuncionario(Funcionario obj)
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

        public void UpdateFuncionario(Funcionario obj)
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

        public void DeleteFuncionario(Funcionario obj)
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

        public Funcionario GetFuncionario(int id)
        {
            try
            {
                return connection.Table<Funcionario>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Funcionario> GetFuncionario()
        {
            try
            {
                return connection.Table<Funcionario>().OrderBy(x => x.Persona).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

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

        public bool TryUsuario(string user, string pass)
        {
            try
            {
                if (connection.Table<Usuario>().FirstOrDefault(x => x.User == user) != null)
                {
                    using (DataAccess db = new DataAccess())
                    {
                        Usuario existente = db.GetUsuarioXUser(user);
                        if (existente.Password == pass)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                }
                else
                {
                    return false;
                }
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

        public Usuario GetUsuarioDefault()
        {
            try
            {
                return connection.Table<Usuario>().FirstOrDefault(u => u.Defecto);
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
        #endregion

        public void Dispose()
        {
            connection.Dispose();
        }

        private void CreaTablas(SQLiteConnection con)
        {
            con.CreateTable<Persona>();
            con.CreateTable<Usuario>();
            con.CreateTable<AdecuacionCurricular>();
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
            con.CreateTable<TipoPeriodo>();
        }
    }
}
