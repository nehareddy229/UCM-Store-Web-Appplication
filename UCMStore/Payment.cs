//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UCMStore
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public string CardNo { get; set; }
        public Nullable<int> ExpiryMonth { get; set; }
        public Nullable<int> ExpiryYear { get; set; }
        public Nullable<int> CVV { get; set; }
        public Nullable<System.DateTime> PaidOn { get; set; }
        public string PaymentStatus { get; set; }
        public int OrderId { get; set; }
        public int PaymentId { get; set; }
    
        public virtual Order Order { get; set; }
    }
}