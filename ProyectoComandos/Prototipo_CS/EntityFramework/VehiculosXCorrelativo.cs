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
    
    public partial class VehiculosXCorrelativo
    {
        public int Id { get; set; }
        public int CodCorrelativo { get; set; }
        public string NumPlaca { get; set; }
    
        public virtual Correlativo Correlativo { get; set; }
        public virtual Vehiculos Vehiculos { get; set; }
    }
}
