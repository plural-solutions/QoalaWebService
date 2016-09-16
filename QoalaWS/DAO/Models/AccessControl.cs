﻿using QoalaWS.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QoalaWS.DAO
{
    public partial class ACCESSCONTROL
    {
        
        public static ACCESSCONTROL find(QoalaEntities context, String token)
        {
            return context.ACCESSCONTROLs.FirstOrDefault(a => a.TOKEN == token && a.EXPIRED_AT <= DateTime.Now);
        }

        public ACCESSCONTROL Add(QoalaEntities context)
        {
            this.Logger().Debug("add ACCESSCONTROL for user: " + this.USER.ToString());
            TOKEN = DateTime.Now.Ticks.ToString() + "-" + USER.ID_USER.ToString();
            // TODO: make the number to addDays configured by USER configuration ou SYSTEM configuration
            EXPIRED_AT = DateTime.Now.AddDays(7);
            context.ACCESSCONTROLs.Add(this);
            context.SaveChanges();
            return this;
        }

        public bool Delete(QoalaEntities context)
        {
            this.Logger().Debug("delete ACCESSCONTROL("+TOKEN+") for user: " + this.USER.ToString());
            // Do not remove this entity, just update with expired now
            //context.ACCESSCONTROLs.Remove(this);
            this.EXPIRED_AT = DateTime.Now;
            context.Entry(this).State = EntityState.Modified;
            context.SaveChanges();
            return find(context, TOKEN) == null;
        }

    }
}