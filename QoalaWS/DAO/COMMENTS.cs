//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QoalaWS.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMMENTS
    {
        public decimal ID_COMMENT { get; set; }
        public string CONTENT { get; set; }
        public System.DateTime CREATED_AT { get; set; }
        public Nullable<System.DateTime> UPDATED_AT { get; set; }
        public Nullable<System.DateTime> APPROVED_AT { get; set; }
        public Nullable<System.DateTime> DELETED_AT { get; set; }
        public decimal POST_ID { get; set; }
        public decimal USER_ID { get; set; }
    
        public virtual POSTS POSTS { get; set; }
        public virtual USERS USERS { get; set; }
    }
}
