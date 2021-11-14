using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackend.Entities.ClassDTO
{
    public class ProductoDTO
    {
        [Key]
        public int ID_Producto { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(20)]
        public string Marca { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripción { get; set; }

        public int Stock { get; set; }

        public double Precio { get; set; }
    }
}
