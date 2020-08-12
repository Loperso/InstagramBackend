using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("ProfileId")]
        [InverseProperty("LikesGiven")]
        public ProfileEntity ProfileLikes { get; set; }

        public string PostId { get; set; }

        [ForeignKey("PostId")]
        [InverseProperty("Likes")]
        public PostEntity LikeProfile { get; set; }
    }
}
