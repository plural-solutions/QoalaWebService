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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.COMMENTS = new HashSet<Comment>();
            this.DEVICES = new HashSet<Device>();
            this.POSTS = new HashSet<Post>();
            this.ACCESSCONTROLs = new HashSet<AccessControl>();
        }
    
        public decimal ID_USER { get; set; }
        public string NAME { get; set; }
        public string PASSWORD { get; set; }
        public string EMAIL { get; set; }
        public byte PERMISSION { get; set; }
        public System.DateTime CREATED_AT { get; set; }
        public Nullable<System.DateTime> UPDATED_AT { get; set; }
        public Nullable<System.DateTime> DELETED_AT { get; set; }
        public string ADDRESS { get; set; }
        public string DISTRICT { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string ZIPCODE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> COMMENTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Device> DEVICES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Post> POSTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccessControl> ACCESSCONTROLs { get; set; }
    }
}
