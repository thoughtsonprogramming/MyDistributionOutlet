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
    
    public partial class SHIPMENT_SUPPLIER
    {
        public long shipmentSupplierID { get; set; }
        public long shipmentID { get; set; }
        public long supplierID { get; set; }
    
        public virtual SHIPMENT SHIPMENT { get; set; }
        public virtual SUPPLIER SUPPLIER { get; set; }
    }
}
