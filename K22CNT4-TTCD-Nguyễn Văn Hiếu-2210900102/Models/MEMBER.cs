//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace K22CNT4_TTCD_Nguyễn_Văn_Hiếu_2210900102.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MEMBER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEMBER()
        {
            this.ORDERS = new HashSet<ORDER>();
        }
    
        public int member_id { get; set; }
        public string member_name { get; set; }
        public string member_username { get; set; }
        public string member_pass { get; set; }
        public string dia_chi { get; set; }
        public string member_phone { get; set; }
        public string member_email { get; set; }
        
        public Nullable<System.DateTime> ngay_sinh { get; set; }
        public Nullable<System.DateTime> ngay_cap_nhap { get; set; }
        public Nullable<byte> gioi_tinh { get; set; }
        public int tich_diem { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER> ORDERS { get; set; }
    }
}
