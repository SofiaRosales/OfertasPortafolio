//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SolucionOfertas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DIRECCION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIRECCION()
        {
            this.PERSONA = new HashSet<PERSONA>();
        }
    
        public decimal COMUNA_ID { get; set; }
        public decimal ID { get; set; }
        public string CALLE { get; set; }
        public decimal NRO_CASA { get; set; }
        public string DEPTO { get; set; }
    
        public virtual COMUNA COMUNA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONA> PERSONA { get; set; }
    }
}
