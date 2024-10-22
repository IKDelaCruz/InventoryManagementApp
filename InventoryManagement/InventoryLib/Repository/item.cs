//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryLib.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public item()
        {
            this.item_image = new HashSet<item_image>();
        }
    
        public int item_id { get; set; }
        public string item_asset_tag { get; set; }
        public string item_name { get; set; }
        public string item_description { get; set; }
        public int item_type_id { get; set; }
        public int item_subtype_id { get; set; }
        public decimal item_purchase_price { get; set; }
        public decimal item_current_value { get; set; }
        public Nullable<System.DateTime> item_purchase_date { get; set; }
        public Nullable<int> item_lifespan { get; set; }
        public Nullable<int> item_status { get; set; }
        public Nullable<System.DateTime> item_last_updated { get; set; }
        public Nullable<int> item_last_updated_user { get; set; }
        public Nullable<int> item_brand_id { get; set; }
        public string item_model { get; set; }
        public string item_serial { get; set; }
        public Nullable<int> item_current_owner { get; set; }
        public Nullable<int> item_current_department { get; set; }
        public Nullable<System.DateTime> item_borrow_date { get; set; }
        public Nullable<System.DateTime> item_expected_return { get; set; }
        public Nullable<int> item_os_id { get; set; }
        public Nullable<int> item_processor_id { get; set; }
        public Nullable<int> item_memory_id { get; set; }
        public Nullable<int> item_hdd1_id { get; set; }
        public Nullable<int> item_hdd2_id { get; set; }
        public Nullable<decimal> item_salvage_value { get; set; }
        public string item_ip_address { get; set; }
        public string item_ip_subnet_mask { get; set; }
        public string item_ip_gateway { get; set; }
        public string item_ip_dns { get; set; }
        public Nullable<int> item_login_type { get; set; }
        public Nullable<int> item_printer_type { get; set; }
        public Nullable<int> item_parent { get; set; }
        public string sales_invoice_no { get; set; }
        public string purchase_order_no { get; set; }
    
        public virtual brand brand { get; set; }
        public virtual item_subtype item_subtype { get; set; }
        public virtual item_type item_type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<item_image> item_image { get; set; }
    }
}
