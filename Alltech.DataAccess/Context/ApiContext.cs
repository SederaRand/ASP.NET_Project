using Alltech.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alltech.DataAccess.Context
{
    public class ApiContext : DbContext 
    {

        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
           
        } 
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }

    }

}
