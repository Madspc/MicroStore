using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MicroStore.Models
{
    //Esta clase sirve para realizar la conexion a nuestra base de datos, ambas sub-clases son de la misma 
    //base de datos
    public class OurDbContext : DbContext
    {
        public DbSet<CuentaUsuario> cuentaUsuario { get; set; }
        public DbSet<UsuarioCompra> usuarioCompra { get; set; }
    }
}