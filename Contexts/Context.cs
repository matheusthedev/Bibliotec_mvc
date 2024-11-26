using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibliotec.Models;
using Microsoft.EntityFrameworkCore;

namespace Bibliotec.Contexts
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public Context()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=NOTE12-S28\SQLEXPRESS; 
                Initial Catalog = Bibliotec_mvc; 
                User Id=sa; Password=123; 
                Integrated Security=true; 
                TrustServerCertificate = true");

            }
        }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Curso> Curso { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<LivroCategoria> livroCategoria {get; set;}

        public DbSet<LivroReserva> LivroReserva {get; set;}


    }
}