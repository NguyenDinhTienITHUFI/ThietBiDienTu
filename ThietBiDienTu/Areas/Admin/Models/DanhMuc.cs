﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThietBiDienTu.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class DanhMuc
    {
        public DanhMuc()
        {
            this.SanPhams = new HashSet<SanPham>();
        }
    
        public int MaDanhMuc { get; set; }
        [Required(ErrorMessage = "Không được để trống !")]
        public string TenDanhMuc { get; set; }
    
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
