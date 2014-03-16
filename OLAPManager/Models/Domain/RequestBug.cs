using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OLAPManager.Models.Domain
 
{

    public enum BugType
    {
        NonReconciliation=1
        ,MissingAttribute=2
        ,ErrorMessage=3
        ,Other=0
        //other bug types will be defined later in the process
    }


    /// <summary>
    /// Class used to hold bug requests submitted by users
    /// </summary>
    public partial class RequestBug : Request
    {
        public BugType BugType { get; set; }

        //public int Id { get; set; }
        //public RequestStatus Status { get; set; }
        //public virtual List<Remark> Remarks { get; set; }

        public RequestBug()
        {
            this.Status = 0;
            this.BugType = 0;
        }

        public RequestBug(RequestStatus status, List<Remark> remarks, BugType bugtype, string description, int submittedByID)
        {
            this.Status = status;
            this.Remarks = remarks;
            this.BugType = bugtype;
            this.Description = description;
            this.SubmittedByUserId = submittedByID;
        }



        public RequestBug(int id, RequestStatus status, List<Remark> remarks, BugType bugtype, string description, int submittedByID)
        {
            this.Id = id;
            this.Status = status;
            this.Remarks = remarks;
            this.BugType = bugtype;
            this.Description = description;
            this.SubmittedByUserId = submittedByID;
        }

        public RequestBug(int id, RequestStatus status, BugType bugtype, string description, int submittedByID)
        {
            this.Id = id;
            this.Status = status;
            this.BugType = bugtype;
            this.Description = description;
            this.SubmittedByUserId = submittedByID;
        }

        public RequestBug(RequestStatus status, BugType bugtype, string description, int submittedByID)
        {
            this.Status = status;
            this.BugType = bugtype;
            this.Description = description;
            this.SubmittedByUserId = submittedByID;
        }
 
    }
}