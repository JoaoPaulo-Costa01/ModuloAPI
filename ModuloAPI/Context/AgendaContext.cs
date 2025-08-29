using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;

namespace ModuloAPI.Context {
    public class AgendaContext : DbContext {


        //(DbContextOptions<AgendaContext> options) recebe a conexão do banco e vai passar para o base,
        //ou seja,para o nosso dbcontext que gerencia a nossa comunicação com o banco de dados
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { 
        
        }

        //entidades = classe no nosso programa e tambem é uma tabela no banco de dados
        public DbSet<Contato> Contatos { get; set; }
    }
}
