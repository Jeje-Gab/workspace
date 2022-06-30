using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ControleDeContatos.Data
{

    public class BancoContext : DbContext
    // Necessario usar os recursos do entity framework core
    // Faz isto instalado os pacotes
    // 
    // Está herdando o contexto do Entity Framework do banco de dados
    {
        // Contrutor
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        // DbContextOptions<BancoContext> -> Tipar o Banco

        // "base(options)" -> Informaçâo que vira do options passar para dentro do "DbContext"
        {

        }

        // Configurando a Entidade "ContatoModel" para dentro do nosso contexto
        public DbSet<ContatoModel> Contatos { get; set; }

    }
}
