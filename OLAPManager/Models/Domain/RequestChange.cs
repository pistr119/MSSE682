using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OLAPManager.Models.Domain
{

    /// <summary>
    /// Class used to hold user submitted change requests
    /// </summary>
    public partial class RequestChange:Request
    {

        //public int Id { get; set; }
        //public RequestStatus Status { get; set; }
        //public virtual List<Remark> Remarks { get; set; }

        public string BusinessNeed;
                

        public RequestChange()
        {
            this.Status = 0;
 
        }

        public RequestChange(RequestStatus status, List<Remark> remarks, string businessneed, string description, int submittedByID)
        {
            this.Status = status;
            this.Remarks = remarks;
            this.BusinessNeed=businessneed;
            this.Description = description;
            this.SubmittedByUserId = submittedByID;
        }



        public RequestChange(int id, RequestStatus status, List<Remark> remarks, string businessneed, string description, int submittedByID)
        {
            this.Id = id;
            this.Status = status;
            this.Remarks = remarks;
            this.BusinessNeed=businessneed;
            this.Description = description;
            this.SubmittedByUserId = submittedByID;
        }

        public RequestChange(int id, RequestStatus status, string businessneed, string description, int submittedByID)
        {
            this.Id = id;
            this.Status = status;
            this.BusinessNeed=businessneed;
            this.Description = description;
            this.SubmittedByUserId = submittedByID;
        }

        public RequestChange(RequestStatus status, string businessneed, string description, int submittedByID)
        {
            this.Status = status;
            this.BusinessNeed=businessneed;
            this.Description = description;
            this.SubmittedByUserId = submittedByID;
        }

 
    }
}