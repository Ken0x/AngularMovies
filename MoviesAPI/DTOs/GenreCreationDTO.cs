using MoviesAPI.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.DTOs
{
    public class GenreCreationDTO
    {
        [Required(ErrorMessage = "The filed with name {0} is required")]
        [StringLength(50)]
        [FirstLetterUppercase]
        public string Name { get; set; }
    }
}
