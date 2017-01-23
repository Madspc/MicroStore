using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Proporciona clases de atributos que se utilizan para definir metadatos para los controles de datos ASP.NET MVC y ASP.NET.
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicroStore.Models
{
    //Aqui introducimos los campos de nuestra tabla en la base de datos
    //Creamos los parametros necesarios de cada campo
    [Table("Clientes") ]
    public class CuentaUsuario
    {
        [Key]//Indicando quien es la llave principal
        public int Id { get; set; }

        public string Usuario { get; set; }

        public string Contraseña { get; set; }
    }
}