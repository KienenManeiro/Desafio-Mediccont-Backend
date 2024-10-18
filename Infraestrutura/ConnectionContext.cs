using Mediccont.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Mediccont.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Tarefa> Tarefa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=123");
    }
}
