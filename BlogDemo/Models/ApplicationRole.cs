using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogDemo.Models
{
    public class ApplicationRole 
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "El {0} debe tener al menos {2} y como máximo {1} carácteres de longitud.", MinimumLength = 10)]
        public string nombre { get; set; }

    }
}
