using SQLite.Net.Interop;

namespace RegistroDocente
{
    public interface IConfig
    {
        string DirectorioDB { get; }
        ISQLitePlatform Plataforma { get; }
    }
}
