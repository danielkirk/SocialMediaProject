using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Post
    {
        [Required]
        public string Content { get; set; }

        public DateTime DateCreated { get; set; }
    }
}