using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alltech.DataAccess.Models
{
    public class ParamsDatatable
    {
        public int draw { get; set;}
        public int length { get; set;}
        public int start { get; set;}
        public string sortName { get; set;}
        public string sortDir { get; set;}
        public string queryString { get; set;}

    }
}
