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
    
    public partial class transmital
    {
        public int transmital_id { get; set; }
        public int transmitted_to_user_id { get; set; }
        public int transmitted_to_company_id { get; set; }
        public int transmitted_to_department_id { get; set; }
        public System.DateTime transmitted_date { get; set; }
        public int prepared_by_id { get; set; }
        public int approved_by_id { get; set; }
        public Nullable<System.DateTime> approved_date { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<int> noted_by_id { get; set; }
        public string purpose { get; set; }
    }
}
