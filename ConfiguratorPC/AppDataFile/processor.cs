//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConfiguratorPC.AppDataFile
{
    using System;
    using System.Collections.Generic;
    
    public partial class processor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public processor()
        {
            this.computer = new HashSet<computer>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string socket { get; set; }
        public string core { get; set; }
        public string streams { get; set; }
        public int cache { get; set; }
        public int freq { get; set; }
        public int heat { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public Nullable<double> rating { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<computer> computer { get; set; }
    }
}
