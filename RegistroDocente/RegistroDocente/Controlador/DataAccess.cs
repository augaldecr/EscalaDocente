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
            if (GetConfiguracion(1) == null)
            {
                InicializeParameters();
                InsertaDatosBasicos();
            }
        }

        #region CRUDOfClasses

        #region AdecuacionCurricular
        public void InsertAdecuacionCurricular(AdecuacionCurricular obj)
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

        public void UpdateAdecuacionCurricular(AdecuacionCurricular obj)
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

        public void DeleteAdecuacionCurricular(AdecuacionCurricular obj)
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

        public AdecuacionCurricular GetAdecuacionCurricular(int id)
        {
            try
            {
                return connection.Table<AdecuacionCurricular>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AdecuacionCurricular> GetAdecuacionesCurriculares()
        {
            try
            {
                return connection.Table<AdecuacionCurricular>().OrderBy(x => x.Matricula).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

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

        #region Canton
        public void InsertCanton(Canton obj)
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

        public void UpdateCanton(Canton obj)
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

        public void DeleteCanton(Canton obj)
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

        public Canton GetCanton(int id)
        {
            try
            {
                return connection.Table<Canton>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Canton> GetCantones()
        {
            try
            {
                return connection.Table<Canton>().OrderBy(x => x.Nombre).ToList();
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

        #region CicloEducativo
        public void InsertCicloEducativo(CicloEducativo obj)
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

        public void UpdateCicloEducativo(CicloEducativo obj)
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

        public void DeleteCicloEducativo(CicloEducativo obj)
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

        public CicloEducativo GetCicloEducativo(int id)
        {
            try
            {
                return connection.Table<CicloEducativo>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<CicloEducativo> GetCiclosEducativos()
        {
            try
            {
                return connection.Table<CicloEducativo>().OrderBy(x => x.Nombre).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Circuito
        public void InsertCircuito(Circuito obj)
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

        public void UpdateCircuito(Circuito obj)
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

        public void DeleteCircuito(Circuito obj)
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

        public Circuito GetCircuito(int id)
        {
            try
            {
                return connection.Table<Circuito>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Circuito> GetCircuito()
        {
            try
            {
                return connection.Table<Circuito>().OrderBy(x => x.Nombre).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Configuracion
        public void InsertConfiguracion(Configuracion obj)
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

        public void UpdateConfiguracion(Configuracion obj)
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

        public void DeleteConfiguracion(Configuracion obj)
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

        public Configuracion GetConfiguracion(int id)
        {
            try
            {
                return connection.Table<Configuracion>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Configuracion> GetConfiguraciones()
        {
            try
            {
                return connection.Table<Configuracion>().OrderBy(x => x.ID).ToList();
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

        #region Dia
        public void InsertDia(Dia obj)
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

        public void UpdateDia(Dia obj)
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

        public void DeleteDia(Dia obj)
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

        public Dia GetDia(int id)
        {
            try
            {
                return connection.Table<Dia>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Dia> GetDias()
        {
            try
            {
                return connection.Table<Dia>().OrderBy(x => x.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region DiaLectivo
        public void InsertDiaLectivo(DiaLectivo obj)
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

        public void UpdateDiaLectivo(DiaLectivo obj)
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

        public void DeleteDiaLectivo(DiaLectivo obj)
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

        public DiaLectivo GetDiaLectivo(int id)
        {
            try
            {
                return connection.Table<DiaLectivo>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<DiaLectivo> GetDiaLectivo()
        {
            try
            {
                return connection.Table<DiaLectivo>().OrderBy(x => x.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region DiaNoLectivo
        public void InsertDiaNoLectivo(DiaNoLectivo obj)
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

        public void UpdateDiaNoLectivo(DiaNoLectivo obj)
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

        public void DeleteDiaNoLectivo(DiaNoLectivo obj)
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

        public DiaNoLectivo GetDiaNoLectivo(int id)
        {
            try
            {
                return connection.Table<DiaNoLectivo>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<DiaNoLectivo> GetDiasNoLectivos()
        {
            try
            {
                return connection.Table<DiaNoLectivo>().OrderBy(x => x.ID).ToList();
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

        #region Escala
        public void InsertEscala(Escala obj)
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

        public void UpdateEscala(Escala obj)
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

        public void DeleteEscala(Escala obj)
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

        public Escala GetEscala(int id)
        {
            try
            {
                return connection.Table<Escala>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Escala> GetEscalas()
        {
            try
            {
                return connection.Table<Escala>().OrderBy(x => x.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region EscalaNodo
        public void InsertEscalaNodo(EscalaNodo obj)
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

        public void UpdateEscalaNodo(EscalaNodo obj)
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

        public void DeleteEscalaNodo(EscalaNodo obj)
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

        public EscalaNodo GetEscalaNodo(int id)
        {
            try
            {
                return connection.Table<EscalaNodo>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EscalaNodo> GetEscalaNodos()
        {
            try
            {
                return connection.Table<EscalaNodo>().OrderBy(x => x.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EscalaNodo> GetEscalaNodosXEscala(int escala)
        {
            try
            {
                return connection.Table<EscalaNodo>().Where(x => x.Escala == escala).OrderBy(x => x.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Especialidad
        public void InsertEspecialidad(Especialidad obj)
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

        public void UpdateEspecialidad(Especialidad obj)
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

        public void DeleteEspecialidad(Especialidad obj)
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

        public Especialidad GetEspecialidad(int id)
        {
            try
            {
                return connection.Table<Especialidad>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Especialidad> GetEspecialidades()
        {
            try
            {
                return connection.Table<Especialidad>().OrderBy(x => x.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Evaluacion
        public void InsertEvaluacion(Evaluacion obj)
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

        public void UpdateEvaluacion(Evaluacion obj)
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

        public void DeleteEvaluacion(Evaluacion obj)
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

        public Evaluacion GetEvaluacion(int id)
        {
            try
            {
                return connection.Table<Evaluacion>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Evaluacion> GetEvaluaciones()
        {
            try
            {
                return connection.Table<Evaluacion>().OrderBy(x => x.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region EvaluacionAplicada
        public void InsertEvaluacionAplicada(EvaluacionAplicada obj)
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

        public void UpdateEvaluacionAplicada(EvaluacionAplicada obj)
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

        public void DeleteEvaluacionAplicada(EvaluacionAplicada obj)
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

        public EvaluacionAplicada GetEvaluacionAplicada(int id)
        {
            try
            {
                return connection.Table<EvaluacionAplicada>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EvaluacionAplicada> GetEvaluacionesAplicadas()
        {
            try
            {
                return connection.Table<EvaluacionAplicada>().OrderBy(x => x.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region EvaluacionNombrePropuesto
        public void InsertEvaluacionNombrePropuesto(EvaluacionNombrePropuesto obj)
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

        public void UpdateEvaluacionNombrePropuesto(EvaluacionNombrePropuesto obj)
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

        public void DeleteEvaluacionNombrePropuesto(EvaluacionNombrePropuesto obj)
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

        public EvaluacionNombrePropuesto GetEvaluacionNombrePropuesto(int id)
        {
            try
            {
                return connection.Table<EvaluacionNombrePropuesto>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EvaluacionNombrePropuesto> GetEvaluacionNombresPropuestos()
        {
            try
            {
                return connection.Table<EvaluacionNombrePropuesto>().OrderBy(x => x.ID).ToList();
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

        #region Genero
        public void InsertGenero(Genero obj)
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

        public void UpdateGenero(Genero obj)
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

        public void DeleteGenero(Genero obj)
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

        public Genero GetGenero(int id)
        {
            try
            {
                return connection.Table<Genero>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Genero> GetGeneros()
        {
            try
            {
                return connection.Table<Genero>().OrderBy(x => x.Nombre).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region HorarioDocente
        public void InsertHorarioDocente(HorarioDocente obj)
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

        public void UpdateHorarioDocente(HorarioDocente obj)
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

        public void DeleteHorarioDocente(HorarioDocente obj)
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

        public HorarioDocente GetHorarioDocente(int id)
        {
            try
            {
                return connection.Table<HorarioDocente>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<HorarioDocente> GetHorarioDocente()
        {
            try
            {
                return connection.Table<HorarioDocente>().OrderBy(x => x.Dia).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<HorarioDocente> GetHorarioDocenteXAsignatura(int asig)
        {
            try
            {
                return connection.Table<HorarioDocente>().Where(x => x.Asignatura == asig).OrderBy(x => x.Dia).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<HorarioDocente> GetHorarioDocenteXDia(int dia)
        {
            try
            {
                return connection.Table<HorarioDocente>().Where(x => x.Dia == dia).OrderBy(x => x.Seccion).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<HorarioDocente> GetHorarioDocenteXSeccion(int seccion)
        {
            try
            {
                return connection.Table<HorarioDocente>().Where(x => x.Seccion == seccion).OrderBy(x => x.Dia).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region InAsistencia
        public void InsertInAsistencia(InAsistencia obj)
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

        public void UpdateInAsistencia(InAsistencia obj)
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

        public void DeleteInAsistencia(InAsistencia obj)
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

        public InAsistencia GetInAsistencia(int id)
        {
            try
            {
                return connection.Table<InAsistencia>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<InAsistencia> GetInAsistencias()
        {
            try
            {
                return connection.Table<InAsistencia>().OrderBy(x => x.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<InAsistencia> GetInAsistenciasXEstudiante(int mat)
        {
            try
            {
                return connection.Table<InAsistencia>().Where(x => x.Matricula == mat).OrderBy(x => x.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Indicador
        public void InsertIndicador(Indicador obj)
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

        public void UpdateIndicador(Indicador obj)
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

        public void DeleteIndicador(Indicador obj)
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

        public Indicador GetIndicador(int id)
        {
            try
            {
                return connection.Table<Indicador>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Indicador> GetIndicadores()
        {
            try
            {
                return connection.Table<Indicador>().OrderBy(x => x.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Indicador> GetIndicadoresXGrupo(int grupo)
        {
            try
            {
                return connection.Table<Indicador>().Where(x => x.ObjetivoGeneral == grupo).OrderBy(x => x.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region IndicadorAplicado
        public void InsertIndicadorAplicado(IndicadorAplicado obj)
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

        public void UpdateIndicadorAplicado(IndicadorAplicado obj)
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

        public void DeleteIndicadorAplicado(IndicadorAplicado obj)
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

        public IndicadorAplicado GetIndicadorAplicado(int id)
        {
            try
            {
                return connection.Table<IndicadorAplicado>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<IndicadorAplicado> GetIndicadoresAplicados()
        {
            try
            {
                return connection.Table<IndicadorAplicado>().OrderBy(x => x.Observacion).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<IndicadorAplicado> GetIndicadoresAplicadosXObservacion(int obs)
        {
            try
            {
                return connection.Table<IndicadorAplicado>().Where(x => x.Observacion == obs).OrderBy(x => x.Observacion).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<IndicadorAplicado> GetIndicadoresAplicadosXIndicador(int ind)
        {
            try
            {
                return connection.Table<IndicadorAplicado>().Where(x => x.Indicador == ind).OrderBy(x => x.Observacion).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<IndicadorAplicado> GetIndicadoresAplicadosXEstudiante(int est)
        {
            try
            {
                return connection.Table<IndicadorAplicado>().Where(x => x.Matricula == est).OrderBy(x => x.Observacion).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Institucion
        public void InsertInstitucion(Institucion obj)
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

        public void UpdateInstitucion(Institucion obj)
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

        public void DeleteInstitucion(Institucion obj)
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

        public Institucion GetInstitucion(int id)
        {
            try
            {
                return connection.Table<Institucion>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Institucion GetInstitucionXCodigo(string cod)
        {
            try
            {
                return connection.Table<Institucion>().FirstOrDefault(x => x.CodigoPresupuestario == cod);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Institucion> GetInstituciones()
        {
            try
            {
                return connection.Table<Institucion>().OrderBy(x => x.Nombre).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Matricula
        public void InsertMatricula(Matricula obj)
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

        public void UpdateMatricula(Matricula obj)
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

        public void DeleteMatricula(Matricula obj)
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

        public Matricula GetMatricula(int id)
        {
            try
            {
                return connection.Table<Matricula>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Matricula> GetMatriculas()
        {
            try
            {
                return connection.Table<Matricula>().OrderBy(x => x.Estudiante).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Matricula> GetMatriculasXSeccion(int secc)
        {
            try
            {
                return connection.Table<Matricula>().Where(x => x.Seccion == secc).OrderBy(x => x.Estudiante).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region MatriculaAsignatura
        public void InsertMatriculaAsignatura(MatriculaAsignatura obj)
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

        public void UpdateMatriculaAsignatura(MatriculaAsignatura obj)
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

        public void DeleteMatriculaAsignatura(MatriculaAsignatura obj)
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

        public MatriculaAsignatura GetMatriculaAsignatura(int id)
        {
            try
            {
                return connection.Table<MatriculaAsignatura>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<MatriculaAsignatura> GetMatriculasAsignaturas()
        {
            try
            {
                return connection.Table<MatriculaAsignatura>().OrderBy(x => x.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<MatriculaAsignatura> GetMatriculasXEstudiante(int est)
        {
            try
            {
                return connection.Table<MatriculaAsignatura>().Where(x => x.Matricula == est).OrderBy(x => x.Asignatura).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<MatriculaAsignatura> GetMatriculasXAsignatura(int asig)
        {
            try
            {
                return connection.Table<MatriculaAsignatura>().Where(x => x.Asignatura == asig).OrderBy(x => x.Matricula).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region ModalidadInstitucion
        public void InsertModalidadInstitucion(ModalidadInstitucion obj)
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

        public void UpdateModalidadInstitucion(ModalidadInstitucion obj)
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

        public void DeleteModalidadInstitucion(ModalidadInstitucion obj)
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

        public ModalidadInstitucion GetModalidadInstitucion(int id)
        {
            try
            {
                return connection.Table<ModalidadInstitucion>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ModalidadInstitucion> GetModalidadesInstitucionales()
        {
            try
            {
                return connection.Table<ModalidadInstitucion>().OrderBy(x => x.Nombre).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Nivel
        public void InsertNivel(Nivel obj)
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

        public void UpdateNivel(Nivel obj)
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

        public void DeleteNivel(Nivel obj)
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

        public Nivel GetNivel(int id)
        {
            try
            {
                return connection.Table<Nivel>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Nivel> GetNiveles()
        {
            try
            {
                return connection.Table<Nivel>().OrderBy(x => x.Nombre).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region NivelEscolar
        public void InsertNivelEscolar(NivelEscolar obj)
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

        public void UpdateNivelEscolar(NivelEscolar obj)
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

        public void DeleteNivelEscolar(NivelEscolar obj)
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

        public NivelEscolar GetNivelEscolar(int id)
        {
            try
            {
                return connection.Table<NivelEscolar>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<NivelEscolar> GetNivelesEscolares()
        {
            try
            {
                return connection.Table<NivelEscolar>().OrderBy(x => x.Nombre).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region ObjetivoGeneral
        public void InsertObjetivoGeneral(ObjetivoGeneral obj)
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

        public void UpdateObjetivoGeneral(ObjetivoGeneral obj)
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

        public void DeleteObjetivoGeneral(ObjetivoGeneral obj)
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

        public ObjetivoGeneral GetObjetivoGeneral(int id)
        {
            try
            {
                return connection.Table<ObjetivoGeneral>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ObjetivoGeneral> GetObjetivosGenerales()
        {
            try
            {
                return connection.Table<ObjetivoGeneral>().OrderBy(x => x.Nombre).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Observacion
        public void InsertObservacion(Observacion obj)
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

        public void UpdateObservacion(Observacion obj)
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

        public void DeleteObservacion(Observacion obj)
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

        public Observacion GetObservacion(int id)
        {
            try
            {
                return connection.Table<Observacion>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Observacion> GetObservaciones()
        {
            try
            {
                return connection.Table<Observacion>().OrderBy(x => x.Nombre).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Pais
        public void InsertPais(Pais obj)
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

        public void UpdatePais(Pais obj)
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

        public void DeletePais(Pais obj)
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

        public Pais GetPais(int id)
        {
            try
            {
                return connection.Table<Pais>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pais> GetPaises()
        {
            try
            {
                return connection.Table<Pais>().OrderBy(x => x.Nombre).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        //Pendiente
        /*#region PaseDeLista
        public void InsertPais(Pais obj)
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

        public void UpdatePais(Pais obj)
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

        public void DeletePais(Pais obj)
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

        public Pais GetPais(int id)
        {
            try
            {
                return connection.Table<Pais>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pais> GetPaises()
        {
            try
            {
                return connection.Table<Pais>().OrderBy(x => x.Nombre).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion*/

        //PlanEvaluativo

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

        public Persona GetPersona(int id)
        {
            try
            {
                return connection.Table<Persona>().FirstOrDefault(x => x.ID == id);
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

        #region Provincia
        public void InsertProvincia(Provincia obj)
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

        public void UpdateProvincia(Provincia obj)
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

        public void DeleteProvincia(Provincia obj)
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

        public Provincia GetProvincia(int id)
        {
            try
            {
                return connection.Table<Provincia>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Provincia> GetProvincias()
        {
            try
            {
                return connection.Table<Provincia>().OrderBy(x => x.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Puesto
        public void InsertPuesto(Puesto obj)
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

        public void UpdatePuesto(Puesto obj)
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

        public void DeletePuesto(Puesto obj)
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

        public Puesto GetPuesto(int id)
        {
            try
            {
                return connection.Table<Puesto>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Puesto> GetPuestos()
        {
            try
            {
                return connection.Table<Puesto>().OrderBy(x => x.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Regional
        public void InsertRegional(Regional obj)
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

        public void UpdateRegional(Regional obj)
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

        public void DeleteRegional(Regional obj)
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

        public Regional GetRegional(int id)
        {
            try
            {
                return connection.Table<Regional>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Regional> GetRegionales()
        {
            try
            {
                return connection.Table<Regional>().OrderBy(x => x.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        //RubricasEvaluacion

        #region Seccion
        public void InsertSeccion(Seccion obj)
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

        public void UpdateSeccion(Seccion obj)
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

        public void DeleteSeccion(Seccion obj)
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

        public Seccion GetSeccion(int id)
        {
            try
            {
                return connection.Table<Seccion>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Seccion> GetSecciones()
        {
            try
            {
                return connection.Table<Seccion>().OrderBy(x => x.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        //TipoAdecuacion

        #region TipoAsignatura
        public void InsertTipoAsignatura(TipoAsignatura obj)
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

        public void UpdateTipoAsignatura(TipoAsignatura obj)
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

        public void DeleteTipoAsignatura(TipoAsignatura obj)
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

        public TipoAsignatura GetTipoAsignatura(int id)
        {
            try
            {
                return connection.Table<TipoAsignatura>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<TipoAsignatura> GetTiposAsignaturas()
        {
            try
            {
                return connection.Table<TipoAsignatura>().OrderBy(x => x.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        //TipoEvaluacion
        //TipoInAsistencia

        #region TipoMatricula
        public void InsertTipoMatricula(TipoMatricula obj)
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

        public void UpdateTipoMatricula(TipoMatricula obj)
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

        public void DeleteTipoMatricula(TipoMatricula obj)
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

        public TipoMatricula GetTipoMatricula(int id)
        {
            try
            {
                return connection.Table<TipoMatricula>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<TipoMatricula> GetTiposMatricula()
        {
            try
            {
                return connection.Table<TipoMatricula>().OrderBy(x => x.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        //TipoPeriodicidadAsignatura

        #region TipoPeriodo
        public void InsertTipoPeriodo(TipoPeriodo obj)
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

        public void UpdateTipoPeriodo(TipoPeriodo obj)
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

        public void DeleteTipoPeriodo(TipoPeriodo obj)
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

        public TipoPeriodo GetTipoPeriodo(int id)
        {
            try
            {
                return connection.Table<TipoPeriodo>().FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<TipoPeriodo> GetTiposPeriodo()
        {
            try
            {
                return connection.Table<TipoPeriodo>().OrderBy(x => x.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        //TipoSalida
        //TipoIndicador


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

        #region Methods
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
            con.CreateTable<Configuracion>();
            con.CreateTable<CursoLectivo>();
            con.CreateTable<Dia>();
            con.CreateTable<DiaLectivo>();
            con.CreateTable<DiaNoLectivo>();
            con.CreateTable<Distrito>();
            con.CreateTable<Escala>();
            con.CreateTable<EscalaNodo>();
            con.CreateTable<Especialidad>();
            con.CreateTable<Evaluacion>();
            con.CreateTable<Funcionario>();
            con.CreateTable<Genero>();
            con.CreateTable<HorarioDocente>();
            con.CreateTable<InAsistencia>();
            con.CreateTable<Indicador>();
            con.CreateTable<IndicadorAplicado>();
            con.CreateTable<Institucion>();
            con.CreateTable<Matricula>();
            con.CreateTable<MatriculaAsignatura>();
            con.CreateTable<ModalidadInstitucion>();
            con.CreateTable<Nivel>();
            con.CreateTable<NivelEscolar>();
            con.CreateTable<ObjetivoGeneral>();
            con.CreateTable<Observacion>();
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
            con.CreateTable<TipoIndicador>();
            con.CreateTable<TipoMatricula>();
            con.CreateTable<TipoPeriodicidadAsignatura>();
            con.CreateTable<TipoPeriodo>();
        }

        private void InicializeParameters()
        {
            InsertConfiguracion(new Configuracion { ID = 1, DatosBasicos = false, Listo = false });
        }

        #region Inserts of basic data
        private void InsertaDatosBasicos()
        {
            InsertAnhos();
            InsertAsignaturas();
            InsertCantones();
            InsertDistritos();
            InsertCircuitos();
            InsertCursosLectivos();
            InsertCategoriasDocentes();
            InsertCicloEducativo();
            InsertEscalas();
            InsertEscalaNodos();
            InsertFuncionarios();
            InsertGeneros();
            InsertIndicadores();
            InsertInstituciones();
            InsertMatriculas();
            InsertMatriculasAsignaturas();
            InsertModalidadesInstituciones();
            InsertNiveles();
            InsertNivelesEscolares();
            InsertObjetivoGeneral();
            InsertObservaciones();
            InsertPaises();
            InsertPeriodos();
            InsertProvincias();
            InsertPuestos();
            InsertRegionales();
            InsertSecciones();
            InsertTiposAsignaturas();
            InsertTiposIndicadores();
            InsertTiposMatricula();
            InsertTiposPeriodo();
            SetConfigurated();
        }

        private void InsertAnhos()
        {
            InsertAnho(new Anho { Nombre = "2016" });
            InsertAnho(new Anho { Nombre = "2017" });
        }

        private void InsertAsignaturas()
        {
            InsertAsignatura(new Asignatura { Nombre = "Español", TipoAsignatura = 1 });
            InsertAsignatura(new Asignatura { Nombre = "Ciencias", TipoAsignatura = 1 });
            InsertAsignatura(new Asignatura { Nombre = "Matemática", TipoAsignatura = 1 });
            InsertAsignatura(new Asignatura { Nombre = "Estudios Sociales", TipoAsignatura = 1 });
            InsertAsignatura(new Asignatura { Nombre = "Cívica", TipoAsignatura = 1 });
            InsertAsignatura(new Asignatura { Nombre = "Inglés", TipoAsignatura = 1 });
        }

        private void InsertCantones()
        {
            InsertCanton(new Canton() { Nombre = "San José", Provincia = 1 });
            InsertCanton(new Canton() { Nombre = "Escazú", Provincia = 1 });
            InsertCanton(new Canton() { Nombre = "Desamparados", Provincia = 1 });
            InsertCanton(new Canton() { Nombre = "Puriscal", Provincia = 1 });
            InsertCanton(new Canton() { Nombre = "Tarrazú", Provincia = 1 });
            InsertCanton(new Canton() { Nombre = "Aserrí", Provincia = 1 });
            InsertCanton(new Canton() { Nombre = "Mora", Provincia = 1 });
            InsertCanton(new Canton() { Nombre = "Goicoechea", Provincia = 1 });
            InsertCanton(new Canton() { Nombre = "Santa Ana", Provincia = 1 });
            InsertCanton(new Canton() { Nombre = "Alajuelita", Provincia = 1 });
            InsertCanton(new Canton() { Nombre = "Vásquez de Coronado", Provincia = 1 });
            InsertCanton(new Canton() { Nombre = "Acosta", Provincia = 1 });
            InsertCanton(new Canton() { Nombre = "Tibás", Provincia = 1 });
            InsertCanton(new Canton() { Nombre = "Moravia", Provincia = 1 });
            InsertCanton(new Canton() { Nombre = "Montes de Oca", Provincia = 1 });
            InsertCanton(new Canton() { Nombre = "Turrubares", Provincia = 1 });
            InsertCanton(new Canton() { Nombre = "Dota, Provincia = 1" });
            InsertCanton(new Canton() { Nombre = "Curridabat", Provincia = 1 });
            InsertCanton(new Canton() { Nombre = "Pérez Zeledón", Provincia = 1 });
            InsertCanton(new Canton() { Nombre = "León Córtes Castro" });
            InsertCanton(new Canton() { Nombre = "Alajuela" });
            InsertCanton(new Canton() { Nombre = "San Ramón" });
            InsertCanton(new Canton() { Nombre = "Grecia" });
            InsertCanton(new Canton() { Nombre = "San Mateo" });
            InsertCanton(new Canton() { Nombre = "Atenas" });
            InsertCanton(new Canton() { Nombre = "Naranjo" });
            InsertCanton(new Canton() { Nombre = "Palmares" });
            InsertCanton(new Canton() { Nombre = "Poás" });
            InsertCanton(new Canton() { Nombre = "Orotina" });
            InsertCanton(new Canton() { Nombre = "San Carlos" });
            InsertCanton(new Canton() { Nombre = "Zarcero" });
            InsertCanton(new Canton() { Nombre = "Valverde Vega" });
            InsertCanton(new Canton() { Nombre = "Upala" });
            InsertCanton(new Canton() { Nombre = "Los Chiles" });
            InsertCanton(new Canton() { Nombre = "Guatuso" });
            InsertCanton(new Canton() { Nombre = "Cartago" });
            InsertCanton(new Canton() { Nombre = "Paraíso" });
            InsertCanton(new Canton() { Nombre = "La Unión" });
            InsertCanton(new Canton() { Nombre = "Jiménez" });
            InsertCanton(new Canton() { Nombre = "Turrialba" });
            InsertCanton(new Canton() { Nombre = "Alvarado" });
            InsertCanton(new Canton() { Nombre = "Oreamuno" });
            InsertCanton(new Canton() { Nombre = "El Guarco" });
            InsertCanton(new Canton() { Nombre = "Heredia" });
            InsertCanton(new Canton() { Nombre = "Barva" });
            InsertCanton(new Canton() { Nombre = "Santo Domingo" });
            InsertCanton(new Canton() { Nombre = "Santa Bárbara" });
            InsertCanton(new Canton() { Nombre = "San Rafael" });
            InsertCanton(new Canton() { Nombre = "San Isidro" });
            InsertCanton(new Canton() { Nombre = "Belén" });
            InsertCanton(new Canton() { Nombre = "Flores" });
            InsertCanton(new Canton() { Nombre = "San Pablo" });
            InsertCanton(new Canton() { Nombre = "Sarapiquí" });
            InsertCanton(new Canton() { Nombre = "Liberia" });
            InsertCanton(new Canton() { Nombre = "Nicoya" });
            InsertCanton(new Canton() { Nombre = "Santa Cruz" });
            InsertCanton(new Canton() { Nombre = "Bagaces" });
            InsertCanton(new Canton() { Nombre = "Carrillo" });
            InsertCanton(new Canton() { Nombre = "Cañas" });
            InsertCanton(new Canton() { Nombre = "Abangares" });
            InsertCanton(new Canton() { Nombre = "Tilarán" });
            InsertCanton(new Canton() { Nombre = "Nandayure" });
            InsertCanton(new Canton() { Nombre = "La Cruz" });
            InsertCanton(new Canton() { Nombre = "Hojancha" });
            InsertCanton(new Canton() { Nombre = "Puntarenas" });
            InsertCanton(new Canton() { Nombre = "Esparza" });
            InsertCanton(new Canton() { Nombre = "Buenos Aires" });
            InsertCanton(new Canton() { Nombre = "Montes de Oro" });
            InsertCanton(new Canton() { Nombre = "Osa" });
            InsertCanton(new Canton() { Nombre = "Aguirre" });
            InsertCanton(new Canton() { Nombre = "Golfito" });
            InsertCanton(new Canton() { Nombre = "Coto Brus" });
            InsertCanton(new Canton() { Nombre = "Parrita" });
            InsertCanton(new Canton() { Nombre = "Corredores" });
            InsertCanton(new Canton() { Nombre = "Garabito" });
            InsertCanton(new Canton() { Nombre = "Limón", Provincia = 7 });
            InsertCanton(new Canton() { Nombre = "Pococí", Provincia = 7 });
            InsertCanton(new Canton() { Nombre = "Siquirres", Provincia = 7 });
            InsertCanton(new Canton() { Nombre = "Talamanca", Provincia = 7 });
            InsertCanton(new Canton() { Nombre = "Matina", Provincia = 7 });
            InsertCanton(new Canton() { Nombre = "Guacimo", Provincia = 7 });
        }

        private void InsertDistritos()
        {
            InsertDistrito(new Distrito { Canton = 1, Nombre = "Guápiles" });
        }

        private void InsertCircuitos()
        {
            InsertCircuito(new Circuito() { Nombre = "01", Regional = 1, });
        }

        private void InsertCursosLectivos()
        {
            InsertCursoLectivo(new CursoLectivo { Nombre = "2016", Activo = false });
            InsertCursoLectivo(new CursoLectivo { Nombre = "2017", Activo = true });
        }

        private void InsertCategoriasDocentes()
        {
            InsertCategoriaDocente(new CategoriaDocente { Nombre = "PT1" });
            InsertCategoriaDocente(new CategoriaDocente { Nombre = "PT2" });
            InsertCategoriaDocente(new CategoriaDocente { Nombre = "PT3" });
            InsertCategoriaDocente(new CategoriaDocente { Nombre = "PT4" });
            InsertCategoriaDocente(new CategoriaDocente { Nombre = "PT5" });
            InsertCategoriaDocente(new CategoriaDocente { Nombre = "PT6" });
            InsertCategoriaDocente(new CategoriaDocente { Nombre = "MT1" });
            InsertCategoriaDocente(new CategoriaDocente { Nombre = "MT2" });
            InsertCategoriaDocente(new CategoriaDocente { Nombre = "MT3" });
            InsertCategoriaDocente(new CategoriaDocente { Nombre = "MT4" });
            InsertCategoriaDocente(new CategoriaDocente { Nombre = "MT5" });
            InsertCategoriaDocente(new CategoriaDocente { Nombre = "MT6" });
            InsertCategoriaDocente(new CategoriaDocente { Nombre = "VT1" });
            InsertCategoriaDocente(new CategoriaDocente { Nombre = "VT2" });
            InsertCategoriaDocente(new CategoriaDocente { Nombre = "VT3" });
            InsertCategoriaDocente(new CategoriaDocente { Nombre = "VT4" });
            InsertCategoriaDocente(new CategoriaDocente { Nombre = "VT5" });
            InsertCategoriaDocente(new CategoriaDocente { Nombre = "VT6" });
        }

        private void InsertCicloEducativo()
        {
            InsertCicloEducativo(new CicloEducativo() { Nombre = "Ciclo I", NotaMinima = 65 });
            InsertCicloEducativo(new CicloEducativo() { Nombre = "Ciclo II", NotaMinima = 65 });
            InsertCicloEducativo(new CicloEducativo() { Nombre = "Ciclo III", NotaMinima = 65 });
            InsertCicloEducativo(new CicloEducativo() { Nombre = "Ciclo IV", NotaMinima = 70 });
        }

        private void InsertEscalas()
        {
            InsertEscala(new Escala { Nombre = "Liker" });
        }

        private void InsertEscalaNodos()
        {
            InsertEscalaNodo(new EscalaNodo { Escala = 1, Nombre = "Excelente", Valor = 5 });
            InsertEscalaNodo(new EscalaNodo { Escala = 1, Nombre = "Muy bueno", Valor = 4 });
            InsertEscalaNodo(new EscalaNodo { Escala = 1, Nombre = "Bueno", Valor = 3 });
            InsertEscalaNodo(new EscalaNodo { Escala = 1, Nombre = "Regular", Valor = 2 });
            InsertEscalaNodo(new EscalaNodo { Escala = 1, Nombre = "Deficiente", Valor = 1 });
        }

        private void InsertFuncionarios()
        {
            InsertFuncionario(new Funcionario { Persona = 1, CategoriaDocente = 18, Puesto = 1 });
            InsertFuncionario(new Funcionario { Persona = 2, CategoriaDocente = 12, Puesto = 2 });
        }

        private void InsertGeneros()
        {
            InsertGenero(new Genero { Nombre = "Masculino" });
            InsertGenero(new Genero { Nombre = "Femenino" });
            InsertGenero(new Genero { Nombre = "Otro" });
        }

        private void InsertIndicadores()
        {
            //InsertIndicador(new Indicador { Nombre = "", ObjetivoGeneral = "" });
        }

        private void InsertInstituciones()
        {
            InsertInstitucion(
                new Institucion
                {
                    Circuito = 1,
                    Nombre = "Colegio Académico de Jiménez",
                    CodigoPresupuestario = "4144",
                    Direccion = "Costado norte de polideportivo de Jiménez",
                    Distrito = 1,
                    EmailInstitucion = "col.academicodejimenez@mep.go.cr",
                    Modalidad = 1,
                    Director = 2,
                }
            );

            InsertInstitucion(
                new Institucion
                {
                    Circuito = 1,
                    Nombre = "Escuela Central de Guápiles",
                    CodigoPresupuestario = "3601",
                    Direccion = "Costado norte de plaza El Salvador",
                    Distrito = 1,
                    EmailInstitucion = "esc.centraldeguapiles@mep.go.cr",
                    Modalidad = 1,
                    Director = 2,
                }
            );
        }

        private void InsertMatriculas()
        {
            InsertMatricula(new Matricula { Estudiante = 1, Seccion = 1, TipoMatricula = 1, EmailEncargado = "" });
        }

        private void InsertMatriculasAsignaturas()
        {
            InsertMatriculaAsignatura(new MatriculaAsignatura { Matricula = 1, Asignatura = 1 });
        }

        private void InsertModalidadesInstituciones()
        {
            InsertModalidadInstitucion(new ModalidadInstitucion { Nombre = "Primaria" });
            InsertModalidadInstitucion(new ModalidadInstitucion { Nombre = "Secundaria académica" });
            InsertModalidadInstitucion(new ModalidadInstitucion { Nombre = "Secundaria Técnica" });
        }

        private void InsertNiveles()
        {
            InsertNivel(new Nivel { Nombre = "Primero" });
            InsertNivel(new Nivel { Nombre = "Segundo" });
            InsertNivel(new Nivel { Nombre = "Tercero" });
            InsertNivel(new Nivel { Nombre = "Cuarto" });
            InsertNivel(new Nivel { Nombre = "Quinto" });
            InsertNivel(new Nivel { Nombre = "Sexto" });
            InsertNivel(new Nivel { Nombre = "Sétimo" });
            InsertNivel(new Nivel { Nombre = "Octavo" });
            InsertNivel(new Nivel { Nombre = "Noveno" });
            InsertNivel(new Nivel { Nombre = "Décimo" });
            InsertNivel(new Nivel { Nombre = "Undécimo" });
            InsertNivel(new Nivel { Nombre = "Duodécimo" });
        }

        private void InsertNivelesEscolares()
        {
            InsertNivelEscolar(new NivelEscolar { Nombre = "Primaria" });
            InsertNivelEscolar(new NivelEscolar { Nombre = "Secundaria" });
        }

        private void InsertObjetivoGeneral()
        {
            //InsertObjetivoGeneral(new ObjetivoGeneral { });
        }

        private void InsertObservaciones()
        {
            //InsertObjetivoGeneral(new ObjetivoGeneral { });
        }

        private void InsertPaises()
        {
            InsertPais(new Pais { Nombre = "Costa Rica" });
        }

        private void InsertPeriodos()
        {
            InsertPeriodo(new Periodo { Nombre = "Primer período", CursoLectivo = 2, FechaInicio = new DateTime(2017, 02, 06), FechaFin = new DateTime(2017, 05, 12) });
            InsertPeriodo(new Periodo { Nombre = "Segundo período", CursoLectivo = 2, FechaInicio = new DateTime(2017, 05, 15), FechaFin = new DateTime(2017, 08, 25) });
            InsertPeriodo(new Periodo { Nombre = "Tercer período", CursoLectivo = 2, FechaInicio = new DateTime(2017, 08, 28), FechaFin = new DateTime(2017, 12, 11) });
        }

        private void InsertProvincias()
        {
            InsertProvincia(new Provincia { Nombre = "San José", Pais = 1 });
            InsertProvincia(new Provincia { Nombre = "Cartago", Pais = 1 });
            InsertProvincia(new Provincia { Nombre = "Alajuela", Pais = 1 });
            InsertProvincia(new Provincia { Nombre = "Heredia", Pais = 1 });
            InsertProvincia(new Provincia { Nombre = "Puntarenas", Pais = 1 });
            InsertProvincia(new Provincia { Nombre = "Guanacaste", Pais = 1 });
            InsertProvincia(new Provincia { Nombre = "Limón", Pais = 1 });
        }

        private void InsertPuestos()
        {
            InsertPuesto(new Puesto { Nombre = "Docente" });
            InsertPuesto(new Puesto { Nombre = "Director" });
        }

        private void InsertRegionales()
        {
            InsertRegional(new Regional { Nombre = "Guápiles", });
        }

        private void InsertSecciones()
        {
            InsertSeccion(new Seccion { Institucion = 2, Nivel = 2, Grupo = "1", CursoLectivo = 2, ProfesorGuia = 1 });
        }

        private void InsertTiposAsignaturas()
        {
            InsertTipoAsignatura(new TipoAsignatura { Nombre = "Básicas" });
        }

        private void InsertTiposIndicadores()
        {
            //Inserti(new Asignatura { Nombre =  });
        }

        private void InsertTiposMatricula()
        {
            InsertTipoMatricula(new TipoMatricula { Nombre = "Ordinaria" });
        }

        private void InsertTiposPeriodo()
        {
            InsertTipoPeriodo(new TipoPeriodo { Nombre = "Trimestral" });
            InsertTipoPeriodo(new TipoPeriodo { Nombre = "Semestral" });
            InsertTipoPeriodo(new TipoPeriodo { Nombre = "Unisemestral" });
            InsertTipoPeriodo(new TipoPeriodo { Nombre = "Cuatrimestral" });
        }

        private void SetConfigurated()
        {
            UpdateConfiguracion(new Configuracion { ID = 1, DatosBasicos = true});
        }
        #endregion 
        #endregion
    }
}
