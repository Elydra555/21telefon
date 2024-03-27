using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Data
{
    public class EmberekContext : DbContext
    {
        public EmberekContext() { }

        public DbSet<Emberek> Emberkek { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connMsSQL = "Server=(localdb)\\mssqllocaldb;Database=API.Data;MultipleActiveResultSets=true";
            string connMySQL = "Server=127.0.0.1;uid=root;passwd=;Database=nyilvantartas;";
            optionsBuilder.UseMySql(connMySQL, ServerVersion.AutoDetect(connMySQL));

            //optionsBuilder.UseMySql(connMsSQL);
        }
    }
}
