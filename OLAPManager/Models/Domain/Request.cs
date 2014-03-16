using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OLAPManager.Models.Domain
{
    //References
    //Freeman, A. (2013). Pro ASP.NET MVC 5. New York, NY: Apress.
    //


    public enum RequestStatus
    {
        NotStarted = 0
        ,
        InProgress = 1
            ,
        Approved = 2
            ,
        Rejected = 3
            , Complete = 4
    }

    public abstract class Request : IEntity
    {

        public int Id { get; set; }
        public RequestStatus Status { get; set; }
        public virtual List<Remark> Remarks { get; set; }

        [Required (ErrorMessage="Please provide a brief explanation")]  //freeman, p37
        public string Description { get; set; }

        public int SubmittedByUserId { get; set; }
        public virtual User SubmittedByUser { get; set; }

        

        public bool Validate()
        {
            if ( 
                  Description != null
                && SubmittedByUserId!=0
                )
                return true;
            else return false;
        }

        public override bool Equals(object obj)
        {
            Request r = (Request)obj;
            if (r.Validate() == false || this.Validate() == false)
                return false;
            if (this.GetType() != obj.GetType())
                return false;
            else if (this.GetType() == obj.GetType() && this.GetHashCode() == obj.GetHashCode())
                return true;
            else return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() + Description.GetHashCode() + SubmittedByUserId.GetHashCode();
        }

        public override string ToString()
        {
            return SubmittedByUser.ToString() + " / " + Description;
        }


        public Request()
        {

        }

    }
}