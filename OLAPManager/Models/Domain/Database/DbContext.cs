using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OLAPManager.Models.Domain.Database
{
    /// <summary>
    /// Repository pattern, code from http://www.remondo.net/repository-pattern-example-csharp/
    /// </summary>
    /// 

    public class OLAPContext : DbContext
    {
        public DbSet<RequestAccess> Accesses { get; set; }
        public DbSet<RequestBug> Bugs { get; set; }
        public DbSet<RequestChange> Change { get; set; }

        public System.Data.Entity.DbSet<OLAPManager.Models.Domain.User> Users { get; set; }
    }
}