using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AgendoCita.Infrastructure
{
    public class AgendoCitaDbContextFactory : IDesignTimeDbContextFactory<AgendoCitaDbContext>
    {
        public AgendoCitaDbContext CreateDbContext(string[] args)
        {
            // Buscamos la ruta absoluta combinando el directorio base con la carpeta del proyecto Web
            // Usamos Path.GetFullPath para asegurar que los ".." se resuelvan correctamente
            string path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "AgendoCita.Web"));

            // Si la consola se ejecuta desde la raíz, tal vez falte "src" en la ruta:
            if (!Directory.Exists(path))
            {
                path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "src", "AgendoCita.Web"));
            }

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(path)
                .AddJsonFile("appsettings.json", optional: false) // Si no lo encuentra, ahora nos dirá por qué
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<AgendoCitaDbContext>();
            var connectionString = configuration.GetConnectionString("OracleConnection");

            optionsBuilder.UseOracle(connectionString);

            return new AgendoCitaDbContext(optionsBuilder.Options);
        }
    }
}