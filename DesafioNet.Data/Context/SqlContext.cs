using DesafioNet.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioNet.Data.Context
{
    public class SqlContext :DbContext
    {
        public SqlContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<Transacao> Transacaos { get; set; }
        public DbSet<Chave> Chaves { get; set; }
        public DbSet<Pagador> Pagadores { get; set; }
        public DbSet<Recebedor> Recebedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // pega todas as classes que herda IEntityConfiguration
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
