//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SahinRektefiyeSoln.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserMenus
    {
        public int UserMenuId { get; set; }
        public string UserName { get; set; }
        public Nullable<int> MenuId { get; set; }
    
        public virtual Menus Menus { get; set; }
        public virtual Users Users { get; set; }
    }
}
