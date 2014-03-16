using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OLAPManager.Models.Domain
{
 
    /// <summary>
    /// Class holds information for remarks made on a request
    /// </summary>
    public class  Remark : IEntity
    {
        public Remark()
        {
            //parameterless constructor
        }

        

        public int Id { get; set; }  
        public int UserId { get; set; } 
        public virtual User User {get; set;}

        public string Note { get; set; }

        //foreign key from http://msdn.microsoft.com/en-us/data/jj679962.aspx
        public int RequestId { get; set; }

        //navigational property from http://msdn.microsoft.com/en-us/data/jj679962.aspx
        public virtual Request Request { get; set; }

        public Remark( int id, int userId, string note, int requestId)
        {
            this.Id = id;
            this.UserId = userId;
            this.Note = note;
            this.RequestId = requestId;
        }

        public Remark(int userId, string note, int requestId)
        {
            //no id provided, for new insertions
            this.UserId = userId;
            this.Note = note;
            this.RequestId = requestId;
        }

        public override int GetHashCode()
        {
 	         return Id + (int)UserId+Note.GetHashCode()+RequestId;
        }

        public override string ToString()
        {
            return RequestId + "/" + UserId + "/" + Note; 
        }

        public override bool Equals(object obj)
        {
            Remark r = (Remark)obj;
            if (this.Validate() == false || r.Validate()==false)
                return false;
            if (this.GetType() != obj.GetType())
                return false;
            else if (this.Validate() ==true && this.GetType() == obj.GetType() && this.GetHashCode() == obj.GetHashCode())
                return true;
            else return false;
        }

        public bool Validate()
        {
            if (UserId != 0
 
                && Note != null
                && RequestId != 0
                )
                return true;
            else return false;
        }
    }

    
}