using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ModuloAPI.Context;

namespace ModuloAPI.Context {
    // Esta classe "ensina" a ferramenta de linha de comando a criar seu DbContext.
    public class AgendaContextFactory : IDesignTimeDbContextFactory<AgendaContext> {
        public AgendaContext CreateDbContext(string[] args) {
            // Configuração para ler o arquivo appsettings.json
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<AgendaContext>();

            // Pega a string de conexão do appsettings.json
            // ATENÇÃO: Verifique se "ConexaoPadrao" é o nome exato da sua string de conexão no arquivo appsettings.json
            var connectionString = configuration.GetConnectionString("ConexaoPadrao");

            // ATENÇÃO: Se você usa um banco de dados diferente (SQLite, PostgreSQL, etc.),
            // mude .UseSqlServer() para o método correto (ex: .UseSqlite(), .UseNpgsql()).
            optionsBuilder.UseSqlServer(connectionString);

            // Retorna uma nova instância do seu contexto com as opções configuradas.
            return new AgendaContext(optionsBuilder.Options);
        }
    }
}