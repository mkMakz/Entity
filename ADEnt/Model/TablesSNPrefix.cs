//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADEnt.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TablesSNPrefix
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesSNPrefix()
        {
            this.newEquipment = new HashSet<newEquipment>();
        }
    
        public int intSNPrefixID { get; set; }
        public string strPrefix { get; set; }
        public Nullable<int> intModelID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<newEquipment> newEquipment { get; set; }
        public  TablesModel TablesModel { get; set; }
    }
}
