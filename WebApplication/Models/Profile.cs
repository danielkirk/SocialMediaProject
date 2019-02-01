using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Profile
    {
        [StringLength(100, MinimumLength = 2)]
        [Required]
        public string Name { get; set; }

        public string Teams { get; set; }

        [Required]
        public string Bio { get; set; }

        [Required]
        public string Styles { get; set; }

        [Range(0, 90)]
        [Required]
        public int Experience { get; set; }

        public DateTime DateJoined { get; set; }

    }
}