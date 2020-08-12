using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public CommentEntity Comment { get; set; }

        public string ProfileId { get; set; }

        public ProfileEntity Profile { get; set; }

        public ICollection<LikeSubCommentEntity> LikeSubComments { get; set; }

        public ICollection<TaggedSubCommentEntity> taggedSubComments { get; set; }

        public ICollection<HashtagSubComment> HashtagSubComments { get; set; }

    }
}
