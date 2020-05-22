using Microsoft.EntityFrameworkCore;
using Registro_Completo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registro_Completo.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Persona> Personas { get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Data\RegistroCompleto.db");
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Persona>().HasData(new Persona
            {
                PersonaId = 1,
                FechaNacimiento = DateTime.Now,
                Nombre = "Roberto Carlos",
                Telefono = "8293567829",
                Direccion = "Rio de janeiro #1286",
                Cedula = "0000024563"
            });
        }
    }
}
