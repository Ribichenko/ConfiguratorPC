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
    
    public partial class add_ssd
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public add_ssd()
        {
            this.computer = new HashSet<computer>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public int volume { get; set; }
        public int write_speed { get; set; }
        public int read_speed { get; set; }
        public string type_chip { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public Nullable<double> rating { get; set; }
        public Nullable<int> type_memory_id { get; set; }
    
        public virtual type_memory type_memory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<computer> computer { get; set; }
    }
}
