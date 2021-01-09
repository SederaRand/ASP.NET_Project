using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alltech.DataAccess.Context
{
    public partial class AlltechContext : IdentityDbContext<Alltech.DataAccess.Models.User>
    {
        public AlltechContext()
            : base("name=AlltechDBEntities")
        {
        }

        public static AlltechContext Create()
        {
            return new AlltechContext();
        }

         

    }
}

