using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class LikeSubCommentEntity
    {
        [Key]
        public string LikeSubCommentId { get; set; }

        [Required]
        public DateTime LikeSubCommentDate { get; set; }

        public string SubCommentId { get; set; }

        [ForeignKey("SubCommentsId")]
        [InverseProperty("Likes")]
        public SubCommentEntity SubComment { get; set; }

        public string ProfileId { get; set; }

        [ForeignKey("ProfileId")]
        [InverseProperty("PostsSaved")]
        public ProfileEntity LikedSubComments { get; set; }

    }
}
