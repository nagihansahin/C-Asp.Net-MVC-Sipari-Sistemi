//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SipSis.DAL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Order = new HashSet<Order>();
            this.WarrantyOrder = new HashSet<WarrantyOrder>();
        }
    
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public Nullable<int> MarketID { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual Market Market { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WarrantyOrder> WarrantyOrder { get; set; }
    }
}
