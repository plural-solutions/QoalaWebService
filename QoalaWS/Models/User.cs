﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QoalaWS.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ControlAccess register()
        {
            if (!emailAlreadyExist(Email))
                return null;
           
            Id = 1;
            return doLogin();
        }

        public bool resetPassword()
        {
            // reset password
            return true;
        }

        public ControlAccess doLogin()
        {

            User user = findByEmail(Email);

            if (user.Password.Equals(Password))
            {
                ControlAccess controllAccess = new ControlAccess { Id = user.Id };
                return controllAccess.createToken();
            }

            return null;
        }

        public static bool doLogout(string TokenID)
        {
            ControlAccess ca = ControlAccess.find(TokenID);
            return ca.destroyToken();
        }

        public static User findByEmail(string email)
        {
            // Execute query to find user
            //select * from users where email = email

            return new User { Id = 1, Email = "lucas@gmail.com", Name = "Lucas", Password = "senha" };
        }

        public static bool emailAlreadyExist(string email)
        {
            //select * from users where email = email
            return false;
        }
    }
}
