using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTiendaMagic.Models
{
    public class Item
    {
        [Table("Item")]
        public class Usuario
        {
            [Key]
            [Column("IdItem")]
            public int IdItem { get; set; }
            [Column("Nombre")]
            public string Nombre { get; set; }
            [Column("IdUser")]
            public int IdUser { get; set; }
            [Column("IdProducto")]
            public int IdProducto { get; set; }
            [Column("Precio")]
            public int Precio { get; set; }
            [Column("Estado")]
            //Si es 1 esta disponible y si es 0 esta bloqueado
            public int Estado { get; set; }
            [Column("Imagen")]
            public string Imagen { get; set; }
            [Column("Descripcion")]
            public string Descripcion { get; set; }
        }
    }
}
