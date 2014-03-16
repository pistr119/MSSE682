using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  OLAPManager.Models.Domain
 
{
    public enum ControllerStatus 
    {
        NotProcessed=0
        ,Declined=1
        ,Approved=2
        ,PendingInformation=3
    }

    public enum Market
    {
        Global=0
        ,NorthAmerica=1
        ,EMEA=2
        ,APAC=3
        ,GreaterChina=4
        ,LATAM=5
    }

    public enum Product //real products to be added later
    {
        AllProducts=0
        ,Product1=1
        ,Product2=2
        ,Product3=3
    }


    /// <summary>
    /// Class used to hold user access requests
    /// </summary>
    public partial class RequestAccess:Request
    {
        public ControllerStatus ControllerStatus { get; set; }
        public  Market MarketAccess { get; set; } //users can have access to multiple products
        public  Product  ProductAccess { get; set; }

        public RequestAccess(int id, Market market, Product product, RequestStatus status, ControllerStatus cstatus, string description, int submittedByID)
        {
            this.Id = id;
            this.Status = status;
            this.ControllerStatus = cstatus;
            this.Description = description;
            this.SubmittedByUserId = submittedByID;

            this.MarketAccess = market;
            this.ProductAccess = product;
        
        }

        public RequestAccess(int id, Market market, Product product, RequestStatus status, List<Remark> remarks, ControllerStatus cstatus, string description, int submittedByID)
        {
            this.Id = id;
            this.Status = status;
            this.ControllerStatus = cstatus;
            this.Remarks = remarks;
            this.Description = description;
            this.SubmittedByUserId = submittedByID;

            this.MarketAccess = market;
            this.ProductAccess = product;

        }


        public RequestAccess( Market market, Product product, RequestStatus status, ControllerStatus cstatus, string description, int submittedByID)
        {
            this.Status = status;
            this.ControllerStatus = cstatus;
            this.Description = description;
            this.SubmittedByUserId = submittedByID;

            this.MarketAccess = market;
            this.ProductAccess = product;
        }

        public RequestAccess(  Market market, Product product, RequestStatus status, List<Remark> remarks, ControllerStatus cstatus, string description, int submittedByID)
        {
            this.Status = status;
            this.ControllerStatus = cstatus;
            this.Remarks = remarks;
            this.Description = description;
            this.SubmittedByUserId = submittedByID;

            this.MarketAccess = market;
            this.ProductAccess = product;
        }

        public RequestAccess()
        {
            this.ControllerStatus = (ControllerStatus)0;
            this.Status = 0;
            //parameterless
        }
 

    }
}