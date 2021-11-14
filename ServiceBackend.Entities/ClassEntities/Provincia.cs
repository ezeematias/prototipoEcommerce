namespace ServiceBackend.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("db.Provincias")]
    public partial class Provincia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Provincia()
        {
            Localidades = new HashSet<Localidade>();
        }

        public int ProvinciaID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProvinciaName { get; set; }

        public int PaisID { get; set; }

        public int Available { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Localidade> Localidades { get; set; }

        public virtual Pais Pais { get; set; }
    }
}
