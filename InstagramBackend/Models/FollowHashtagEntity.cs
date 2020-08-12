using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class FollowHashtagEntity
    {
        [Key]
        public string FollowHashtagId { get; set; }

        public string HashtagId { get; set; }

        [ForeignKey("HashtagId")]
        [InverseProperty("HashtagFollowers")]
        public HashtagEntity Hashtag { get; set; }

        public string ProfileId { get; set; }

        [ForeignKey("ProfileId")]
        [InverseProperty("FollowHashtags")]
        public ProfileEntity FollowHashtagProfile { get; set; }

    }
}
