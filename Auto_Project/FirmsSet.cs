//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Auto_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class FirmsSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FirmsSet()
        {
            this.AvailabilitysSet = new HashSet<AvailabilitysSet>();
        }
    
        public int Id { get; set; }
        public string NameCompany { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AvailabilitysSet> AvailabilitysSet { get; set; }
    }
}