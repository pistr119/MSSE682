using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OLAPManager.Models.Domain;

namespace OLAPManager.Tests.Domain

{
    [TestClass]
    public class DomainTests
    {
        User user = new User(1, "username", "userpassword", (UserType)1);
        User user2 = new User();
        RequestAccess requestAccess = new RequestAccess(1,(Market)0,(Product)0,(RequestStatus)0, (ControllerStatus)1, "test request",1);
        RequestBug requestBug=new RequestBug(1,(RequestStatus)1, (BugType)1,"this is crap", 1);
        RequestChange requestChange = new RequestChange(1, (RequestStatus)1, "it sounds like a good idea", "build an olap manager", 1);
        //(RequestStatus status, string businessneed, string description, int submittedByID)
        string note = "Your products are awful";
      
        Remark remark = new Remark();

 

        [TestInitialize]
        public void init()
        {
             remark = new Remark(user.Id, note, requestAccess.Id);
        }

        [TestCleanup]
        public void cleanup()
        {

        }

        [TestMethod]
        public void DomainTestUserValidateT()
        {
            Assert.IsTrue(user.Validate());

        }

        [TestMethod]
        public void DomainTestUserValidateF()
        {
            Assert.IsFalse(user2.Validate());

        }

        [TestMethod]
        public void DomainTestUserEqualsF()
        {
            Assert.IsFalse(user2.Equals(user));
        }

        [TestMethod]
        public void DomainTestUserEqualsT()
        {
 
            User user3 = new User(1, "username", "userpassword", (UserType)1);
            Assert.IsTrue(user3.Equals(user));
        }

        [TestMethod]
        public void DomainTestRemarkValidateT()
        {
            User user3 = new User(1, "username", "userpassword", (UserType)1);

           
            Assert.IsTrue(remark.Validate());
        }

        [TestMethod]
        public void DomainTestRemarkValidateF()
        {

            var r=new Remark();
            Assert.IsFalse(r.Validate());
        }

        [TestMethod]
        public void DomainTestRemarkEqualsT()
        {
            var remark2=new Remark();
            remark2=remark;
            Assert.IsTrue(remark.Equals(remark2));
        }

        [TestMethod]
        public void DomainTestRemarkEqualsF()
        {
            var remark2 = new Remark();
            Assert.IsFalse(remark.Equals(remark2));
        }


        [TestMethod]
        public void DomainTestRequestAccessValidateT()
        {
            Assert.IsTrue(requestAccess.Validate());
        }

        [TestMethod]
        public void DomainTestRequestAccessValidateF()
        {
            RequestAccess requestAccess2 = new RequestAccess();
            Assert.IsFalse(requestAccess2.Validate());
        }

        [TestMethod]
        public void DomainTestRequestAccessEqualsF()
        {
            Request  requestAccess2 = new RequestAccess();
            Assert.IsFalse(requestAccess.Equals(requestAccess2));
        }

        [TestMethod]
        public void DomainTestRequestAccessEqualsT()
        {
            RequestAccess requestAccess2 = requestAccess;
            Assert.IsTrue(requestAccess.Equals(requestAccess2));
        }


        [TestMethod]
        public void DomainTestRequestBugValidateT()
        {
            Assert.IsTrue(requestBug.Validate());
        }

        [TestMethod]
        public void DomainTestRequestBugValidateF()
        {
            var requestBug2 = new RequestBug();
            Assert.IsFalse(requestBug2.Validate());
        }

        [TestMethod]
        public void DomainTestRequestBugEqualsT()
        {
            RequestBug requestBug2 = requestBug;
            Assert.IsTrue(requestBug.Equals(requestBug2));
        }

        [TestMethod]
        public void DomainTestRequestBugEqualsF()
        {
            var requestBug2 = new RequestBug();
            Assert.IsFalse(requestBug2.Equals(requestBug));
        }

        [TestMethod]
        public void DomainTestRequestChangeValidateT()
        {
            Assert.IsTrue(requestChange.Validate());
        }

        [TestMethod]
        public void DomainTestRequestChangeValidateF()
        {
            RequestChange rc2 = new RequestChange();
            Assert.IsFalse(rc2.Validate());
        }

        [TestMethod]
        public void DomainTestRequestChangeEqualsF()
        {
            RequestChange rc2 = new RequestChange();
            Assert.IsFalse(rc2.Equals(requestChange));
        }

        [TestMethod]
        public void DomainTestRequestChangeEqualsT()
        {
            RequestChange rc2 = requestChange;
            Assert.IsTrue(rc2.Equals(requestChange));
        }



    }




}
