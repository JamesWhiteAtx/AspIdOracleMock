//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Asp.Identity.Oracle
{
    using System;
    using System.Collections.Generic;
    
    public partial class IdentityUserLogin
    {
        public string UserId { get; set; }
        public string ProviderKey { get; set; }
        public string LoginProvider { get; set; }
    
        public virtual IdentityUser User { get; set; }
    }
}
