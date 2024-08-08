using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmesApp.Moddels
{
    public class Contexto :DbContext
    {
        //chave do "cofre"
        public DbSet<Ator> Ator { get; set; }
        public DbSet<Filme> Filme { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;DataBase=filmesapp;Username=postgres;Password=Clannadthebest22");
        }
    }
}
