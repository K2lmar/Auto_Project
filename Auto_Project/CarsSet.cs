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
    
    public partial class CarsSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarsSet()
        {
            this.AvailabilitysSet = new HashSet<AvailabilitysSet>();
        }
    
        public int Id { get; set; }
        public string ModelCar { get; set; }
        public int Color { get; set; }
        public Nullable<int> Price { get; set; }
        public string StateNumber { get; set; }
        public string ReleaseYear { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AvailabilitysSet> AvailabilitysSet { get; set; }
    }
}
