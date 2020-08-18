using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InstagramBackend.Models
{
    public class UserEntity
    {
        [Key]
        public string UserId { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string Email { get; set; }

        public string Phone { get; set; }

        [Required]
        public string Password { get; set; }

        public ProfileEntity Profile{ get; set; }
    }
}
