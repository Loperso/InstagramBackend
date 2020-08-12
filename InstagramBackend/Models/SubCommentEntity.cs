using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class SubCommentEntity
    {
        [Key]
        public string SubCommentId { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime SubCommentDate { get; set; }

        public string CommentId { get; set; }

        [ForeignKey("ProfileId")]
        [InverseProperty("SubComments")]
        public CommentEntity Comment { get; set; }

        public string ProfileId { get; set; }

        [ForeignKey("ProfileId")]
        [InverseProperty("SubCommentsByProfile")]
        public ProfileEntity Profile { get; set; }

        public ICollection<LikeSubCommentEntity> Likes { get; set; }

        public ICollection<TaggedSubCommentEntity> taggedProfiles { get; set; }

        public ICollection<HashtagSubCommentEntity> HashtagsSubComment { get; set; }

    }
}
