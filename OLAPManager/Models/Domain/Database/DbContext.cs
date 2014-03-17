using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OLAPManager.Models.Domain.Database
{
    public class OLAPContext //fake repository, just setup to help builds go through
    {
        public List<RequestAccess> Accesses { get; set; }
        public List<RequestBug> Bugs { get; set; }
        public List<RequestChange> Change { get; set; }

        public List<User> Users { get; set; }
    }
}