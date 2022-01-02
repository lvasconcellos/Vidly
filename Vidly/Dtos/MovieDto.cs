using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;

        [Required]
        [Range(1, 20, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public byte NumberInStock { get; set; }


        public byte GenreId { get; set; }
        public GenreDto Genre { get; set; }
    }
}