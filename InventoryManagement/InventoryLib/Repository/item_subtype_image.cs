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
    
    public partial class item_subtype_image
    {
        public int subtype_image_id { get; set; }
        public int subtype_image_subtype_id { get; set; }
        public byte[] subtype_image_picture { get; set; }
    
        public virtual item_subtype item_subtype { get; set; }
    }
}
