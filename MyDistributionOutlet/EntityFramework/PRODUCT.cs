//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyDistributionOutlet.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCT
    {
        public PRODUCT()
        {
            this.PRODUCT_DESCRIPTION = new HashSet<PRODUCT_DESCRIPTION>();
            this.SHIPMENT_PRODUCT_DETAIL = new HashSet<SHIPMENT_PRODUCT_DETAIL>();
        }
    
        public long productID { get; set; }
        public string productName { get; set; }
        public string productSerialNumber { get; set; }
    
        public virtual ICollection<PRODUCT_DESCRIPTION> PRODUCT_DESCRIPTION { get; set; }
        public virtual ICollection<SHIPMENT_PRODUCT_DETAIL> SHIPMENT_PRODUCT_DETAIL { get; set; }
    }
}
