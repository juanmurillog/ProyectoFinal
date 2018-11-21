using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proyecto.Models.Basedb;
using Definitivo.Models.Basedb;

namespace ProyectoSeminario.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Proyecto.Models.Basedb.Alquiler> Alquiler { get; set; }
        public DbSet<Definitivo.Models.Basedb.Persona> Persona { get; set; }
        public DbSet<Definitivo.Models.Basedb.Producto> Producto { get; set; }
        public DbSet<Definitivo.Models.Basedb.TipoPago> TipoPago { get; set; }
        public DbSet<Definitivo.Models.Basedb.TipoPersona> TipoPersona { get; set; }
        public DbSet<Definitivo.Models.Basedb.TipoProducto> TipoProducto { get; set; }
        public DbSet<Proyecto.Models.Basedb.Venta> Venta { get; set; }
        public DbSet<Definitivo.Models.Basedb.TipoServicio> TipoServicio { get; set; }
    }
}
