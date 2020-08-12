using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class FollowHashtagEntity
    {
        [Key]
        public string FollowHashtagId { get; set; }

        public string HashtagId { get; set; }

        public HashtagEntity Hashtag { get; set; }

        public string ProfileId { get; set; }

        public ProfileEntity Profile { get; set; }

    }
}
