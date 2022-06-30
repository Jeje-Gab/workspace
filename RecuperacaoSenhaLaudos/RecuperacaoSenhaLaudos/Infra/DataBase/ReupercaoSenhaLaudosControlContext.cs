using Microsoft.EntityFrameworkCore;
using RecuperacaoSenhaLaudos.Models.Pessoa;

namespace RecuperacaoSenhaLaudos.Infra.DataBase
{
    public class ReupercaoSenhaLaudosControlContext: DbContext
    {
        public DbSet<Pessoa> Expensives { get; set; }
        // DbSet referente a classe criada "Expensive.cs"

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=ExpensiveControl.db");
        // Configuração do Sqlite
        // "UseSqlite("Data Sourse=ExpensiveControl.db")" UseSqLite está recebendo o nosso banco
        // Builder se refere ao projeto em si no geral
        //
        // Apos isto add "DbContext" na nossa injeção de dependencia
    }
}
