﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QoalaEntities : DbContext
    {
        public QoalaEntities()
            : base("name=QoalaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<COMMENT> COMMENTS { get; set; }
        public virtual DbSet<DEVICE_GEO_LOCATIONS> DEVICE_GEO_LOCATIONS { get; set; }
        public virtual DbSet<DEVICE> DEVICES { get; set; }
        public virtual DbSet<POST> POSTS { get; set; }
        public virtual DbSet<User> USERS { get; set; }
        public virtual DbSet<ACCESSCONTROL> ACCESSCONTROLs { get; set; }
        public virtual DbSet<NET_ACCOUNTS> NET_ACCOUNTS { get; set; }
    
        public virtual int SP_DELETE_USER(Nullable<decimal> iD, ObjectParameter rOWCOUNT)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_USER", iDParameter, rOWCOUNT);
        }
    
        public virtual int SP_UPDATE_USER(Nullable<decimal> iD, string nAME, string pASSWORD, string eMAIL, Nullable<decimal> pERMISSION, ObjectParameter rOWCOUNT)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(decimal));
    
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var pASSWORDParameter = pASSWORD != null ?
                new ObjectParameter("PASSWORD", pASSWORD) :
                new ObjectParameter("PASSWORD", typeof(string));
    
            var eMAILParameter = eMAIL != null ?
                new ObjectParameter("EMAIL", eMAIL) :
                new ObjectParameter("EMAIL", typeof(string));
    
            var pERMISSIONParameter = pERMISSION.HasValue ?
                new ObjectParameter("PERMISSION", pERMISSION) :
                new ObjectParameter("PERMISSION", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_USER", iDParameter, nAMEParameter, pASSWORDParameter, eMAILParameter, pERMISSIONParameter, rOWCOUNT);
        }
    
        public virtual int SP_USER_LOG(string lOG, Nullable<decimal> uSER_ID)
        {
            var lOGParameter = lOG != null ?
                new ObjectParameter("LOG", lOG) :
                new ObjectParameter("LOG", typeof(string));
    
            var uSER_IDParameter = uSER_ID.HasValue ?
                new ObjectParameter("USER_ID", uSER_ID) :
                new ObjectParameter("USER_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_USER_LOG", lOGParameter, uSER_IDParameter);
        }
    
        public virtual int SP_INSERT_USER(string nAME, string pASSWORD, string eMAIL, Nullable<decimal> pERMISSION, ObjectParameter oUT_ID_USER)
        {
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var pASSWORDParameter = pASSWORD != null ?
                new ObjectParameter("PASSWORD", pASSWORD) :
                new ObjectParameter("PASSWORD", typeof(string));
    
            var eMAILParameter = eMAIL != null ?
                new ObjectParameter("EMAIL", eMAIL) :
                new ObjectParameter("EMAIL", typeof(string));
    
            var pERMISSIONParameter = pERMISSION.HasValue ?
                new ObjectParameter("PERMISSION", pERMISSION) :
                new ObjectParameter("PERMISSION", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INSERT_USER", nAMEParameter, pASSWORDParameter, eMAILParameter, pERMISSIONParameter, oUT_ID_USER);
        }
    }
}
