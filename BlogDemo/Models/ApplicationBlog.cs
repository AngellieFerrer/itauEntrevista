using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogDemo.Models
{
    public class ApplicationBlog
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "El {0} debe tener al menos {2} y como máximo {1} carácteres de longitud.", MinimumLength = 10)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "El {0} debe tener al menos {2} y como máximo {1} carácteres de longitud.", MinimumLength = 8)]
        public string Fecha { get; set; }

        [Required]
        [StringLength(5000, ErrorMessage = "El {0} debe tener al menos {2} y como máximo {1} carácteres de longitud.", MinimumLength = 10)]
        public string Contenido { get; set; }

        [Required]
        [EmailAddress]
        public string EmailUser { get; set; }
    }
}
