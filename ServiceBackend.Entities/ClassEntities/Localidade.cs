namespace ServiceBackend.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("db.Localidades")]
    public partial class Localidade
    {
        [Key]
        public int LocalidadID { get; set; }

        [Required]
        [StringLength(50)]
        public string LocalidadName { get; set; }

        public int ProvinciaID { get; set; }

        public int Available { get; set; }

        public virtual Provincia Provincia { get; set; }
    }
}
