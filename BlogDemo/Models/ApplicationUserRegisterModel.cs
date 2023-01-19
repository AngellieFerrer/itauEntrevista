using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogDemo.Models
{
    public class ApplicationUserRegisterModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El {0} debe tener al menos {2} y como máximo {1} carácteres de longitud.", MinimumLength = 4)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int OptionId { get; set; }
    }
}
