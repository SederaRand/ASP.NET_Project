using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alltech.DataAccess.Models
{
    public class Products
    {
        [Key]
        public int Id_prod { get; set; }
        [Required]
        public string Name_prod { get; set; }
        [Required]
        public string Desc_prod { get; set; }

        [Required]
        public int Category_prod { get; set; }
        [Required]
        public string Images { get; set; }
        [Required]
        public int Quantity_prod { get; set; }
        [Required]
        public Boolean Status_prod { get; set; }

        [Required]
        public decimal Price_prod { get; set; }
       
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date_entry_Prod { get; set; }


    }
}
