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
    
    public partial class DeviceGeoLocation
    {
        public decimal ID_DEVICE_GEO_LOCATION { get; set; }
        public decimal ID_DEVICE { get; set; }
        public System.DateTime VERIFIED_AT { get; set; }
        public decimal LATITUDE { get; set; }
        public decimal LONGITUDE { get; set; }
    
        public virtual Device DEVICE { get; set; }
    }
}