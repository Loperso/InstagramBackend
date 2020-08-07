using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class FollowProfileEntity
    {

        public string FollowProfileId { get; set; }

        public DateTime FollowDate { get; set; }

        public string FollowerId { get; set; }

        [ForeignKey("FollowerId")]
        [InverseProperty("Followers")]
        public ProfileEntity Follower { get; set; }

        public string FollowedId { get; set; }

        [ForeignKey("FollowedId")]
        [InverseProperty("Followed")]
        public ProfileEntity Followed { get; set; }

    }
}
