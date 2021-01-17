using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alltech.DataAccess.Models
{
    public class Categories
    {
        [Key]
        public int Id_cat { get; set; }
        [Required]
        public string Libelle_cat { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date_entry { get; set; }
    }
}
