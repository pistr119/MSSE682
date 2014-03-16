using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OLAPManager.Models.Domain
{
    public enum UserType
    {
        EndUser = 1
        ,
        Controller = 2
            ,
        TechnicalUser = 3
            , TechnicalManager = 4
    }
    /// <summary>
    /// Class to hold user information
    /// </summary>
    public class User : IEntity  //to be replaced with windows authentication
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public UserType AccessType { get; set; }

        public bool Validate()
        {
            if (UserName != null
                && UserPassword != null
                ) return true;
            else return false;
        }

        public User()
        {
 
        }

        public User (int id, string username, string password, UserType accesstype)
        {
            this.Id = id;
            this.UserName = username;
            this.UserPassword = password;
            this.AccessType = accesstype;
        }

        public User( string username, string password, UserType accesstype)
        {
            //no id, for insertion of new users
            this.UserName = username;
            this.UserPassword = password;
            this.AccessType = accesstype;
        }

        public override int GetHashCode()
        {
            return  UserName.GetHashCode() +  UserPassword.GetHashCode() ;
        }

        public override bool Equals(object obj)
        {
            User u = (User)obj;
            if (this.Validate()==true &&  u.Validate()==true && GetType() == obj.GetType() &&  GetHashCode() == obj.GetHashCode())
                return true;
            else return false;
        }

        public override string ToString()
        {
            //enum to string code borrowed from:  http://stackoverflow.com/questions/3120436/enum-value-to-string
            return Id.ToString() + "/" + UserName.ToString() + "/" + Enum.GetName(AccessType.GetType(), AccessType);
        }
    }
}