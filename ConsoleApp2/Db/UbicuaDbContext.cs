using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2.Db
{
    public class UbicuaDbContext : DbContext
    {
        private const string _connection = "Server=ESTEBAN\\SQLEXPRESS;Initial Catalog=ProuebaPractica;User ID=sa;Password=gestion01;TrustServerCertificate=True;";
        public DbSet<Dato> Datos { get; set; } // Reemplaza TuEntidad y TuTabla con nombres apropiados

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connection);
        }
    }
}
