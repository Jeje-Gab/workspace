using ExpensiveControlApp.Models.Expensives;
using Microsoft.EntityFrameworkCore;

namespace ExpensiveControlApp.Infra.DataBase
{
    public class ExpensiveControlContext : DbContext
    // Herança
    {
        public DbSet<Expensive> Expensives { get; set; }
        // DbSet referente a classe criada "Expensive.cs"

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=ExpensiveControl.db");
        // Configuração do Sqlite
        // "UseSqlite("Data Sourse=ExpensiveControl.db")" UseSqLite está recebendo o nosso banco
        // Builder se refere ao projeto em si no geral
        //
        // Apos isto add "DbContext" na nossa injeção de dependencia
    }
}
