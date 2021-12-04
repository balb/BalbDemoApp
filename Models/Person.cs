using System;
using System.ComponentModel.DataAnnotations;

namespace BalbDemoApp.Models
{
    public class Person
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Range(0, 99)]
        public int Age { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }
    }
}