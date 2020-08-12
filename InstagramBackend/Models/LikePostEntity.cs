using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class LikePostEntity
    {
        [Key]
        public string LikePostId { get; set; }

        public DateTime LikePostDate { get; set; }

        public string ProfileId { get; set; }

        public ProfileEntity Profile { get; set; }

        
    }
}
