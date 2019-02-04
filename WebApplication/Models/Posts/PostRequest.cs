using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class PostRequest
    {
        [Required]
        public string AspNetUserId { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime DateCreated { get; set; }
    }
}