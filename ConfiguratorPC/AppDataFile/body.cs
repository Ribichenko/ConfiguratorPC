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
    
    public partial class body
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public body()
        {
            this.computer = new HashSet<computer>();
        }
    
        public int id { get; set; }
        public string ffactor { get; set; }
        public int type_body_id { get; set; }
        public int colors_id { get; set; }
        public int max_videocard { get; set; }
        public string dimensions { get; set; }
        public int price { get; set; }
        public int max_cool { get; set; }
        public string description { get; set; }
    
        public virtual colors colors { get; set; }
        public virtual type_body type_body { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<computer> computer { get; set; }
    }
}
