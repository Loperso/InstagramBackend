using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class LikeCommentEntity
    {
        [Key]
        public string LikeCommentId { get; set; }

        [Required]
        public DateTime LikeCommentDate { get; set; }

        public string CommentId { get; set; }

        [ForeignKey("CommentId")]
        [InverseProperty("Likes")]
        public CommentEntity Comment { get; set; }

        public string ProfileId { get; set; }

        [ForeignKey("ProfileId")]
        [InverseProperty("LikedComments")]
        public ProfileEntity Profile { get; set; }

    }
}
