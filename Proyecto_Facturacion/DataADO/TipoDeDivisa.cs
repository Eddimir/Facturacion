//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto1.DataADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoDeDivisa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoDeDivisa()
        {
            this.Facturacion = new HashSet<Facturacion>();
        }
    
        public int Id { get; set; }
        public string TipoDivisa { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<decimal> ITBS { get; set; }
        public Nullable<System.DateTime> FechaActualizacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturacion> Facturacion { get; set; }
    }
}
