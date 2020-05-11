using erpApp.Model;
using Microsoft.EntityFrameworkCore;

namespace erpApp.EntityFramework.Core
{
  public class ClienteFornecedorContext : DbContext
  {
   public DbSet<ClienteFornecedorCxt> DbClienteFornecedor { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(UtilStrConfiguracoes.strConnection);

      base.OnConfiguring(optionsBuilder);   
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<ClienteFornecedorCxt>(entity =>
      {
        entity.ToTable("FCFO");
        entity.HasKey("CodColigada", "CodCfo");

      });

      base.OnModelCreating(modelBuilder);
    }
  }
}
