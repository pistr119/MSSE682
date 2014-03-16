using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLAPManager.Models.Domain
{
    interface IEntity
    {
        int Id { get; set; }
        bool Validate();
    }
}
