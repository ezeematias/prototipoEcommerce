namespace ServiceBackend.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Productos")]
    public partial class Producto
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

        public int Available { get; set; }

        public double Precio { get; set; }
    }
}
