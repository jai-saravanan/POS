//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Persistance
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InvoiceInfo()
        {
            this.CardProcessings = new HashSet<CardProcessing>();
            this.Invoice_Payment = new HashSet<Invoice_Payment>();
            this.Invoice_Product = new HashSet<Invoice_Product>();
            this.Salesman_Commission = new HashSet<Salesman_Commission>();
            this.SalesReturns = new HashSet<SalesReturn>();
        }
    
        public int Inv_ID { get; set; }
        public string InvoiceNo { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public Nullable<int> OpenID { get; set; }
        public string CurrencyCode { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<decimal> DiscPer { get; set; }
        public Nullable<decimal> DiscAmt { get; set; }
        public Nullable<decimal> GrandTotal { get; set; }
        public string TaxType { get; set; }
        public string Member_ID { get; set; }
        public Nullable<int> SalesmanID { get; set; }
        public Nullable<decimal> Cash { get; set; }
        public Nullable<decimal> Change { get; set; }
        public Nullable<int> CustID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CardProcessing> CardProcessings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice_Payment> Invoice_Payment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice_Product> Invoice_Product { get; set; }
        public virtual POS_OpeningCash POS_OpeningCash { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salesman_Commission> Salesman_Commission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesReturn> SalesReturns { get; set; }
    }
}