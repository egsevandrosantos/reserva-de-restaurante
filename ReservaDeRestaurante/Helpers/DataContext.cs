using Microsoft.EntityFrameworkCore;

namespace ReservaDeRestaurante.Helpers;

public class DataContext : DbContext
{
    private readonly IConfiguration _configuration;

    public DataContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var connectionString = _configuration.GetConnectionString("DefaultDatabase");
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
}