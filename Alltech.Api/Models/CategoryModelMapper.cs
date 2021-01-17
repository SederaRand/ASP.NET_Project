using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Alltech.Api.Models
{
    public class CategoryModelMapper
    {
        [Key]
        public int Id_cat { get; set; }
        [Required]
        public string libelle_cat { get; set; }

        [DataType(DataType.Date)]
        public DateTime date_entry { get; set; }
    }
}