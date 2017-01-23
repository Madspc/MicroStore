using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Nuevas librerias
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MicroStore.Models
{
    //Aqui introducimos los campos de nuestra tabla en la base de datos
    //Creamos los parametros necesarios de cada campo
    [Table("Productos")]
    public class UsuarioCompra
    {
        [Key]//Indicando quien es la llave principal
        public int Idp { get; set; }

        public string NombreProducto { get; set; }

        public decimal Precio { get; set; }

        public byte[] Imagen { get; set; }

        public bool Solicitado { get; set; }
    }
}