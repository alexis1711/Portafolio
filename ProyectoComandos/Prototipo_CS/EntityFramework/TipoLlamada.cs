//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prototipo_CS.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoLlamada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoLlamada()
        {
            this.Emergencias = new HashSet<Emergencias>();
        }
    
        public int Id { get; set; }
        public string TipoLlamada1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emergencias> Emergencias { get; set; }
    }
}
