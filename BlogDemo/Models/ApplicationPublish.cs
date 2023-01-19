using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogDemo.Models
{
    public class ApplicationPublish
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int idBlog { get; set; }

        [Required]
        public bool Publicar { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAprobador { get; set; }
    }
}
