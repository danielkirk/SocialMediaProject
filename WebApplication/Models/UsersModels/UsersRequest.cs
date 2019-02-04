using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class UsersRequest
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Gender { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        public DateTime DateJoined { get; set; }
    }
}