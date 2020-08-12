using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class CommentEntity
    {
        [Key]
        public string CommentId { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime CommentDate { get; set; }

        public string PostId { get; set; }

        [ForeignKey("PostId")]
        [InverseProperty("Comments")]
        public PostEntity Post { get; set; }

        public string ProfileId { get; set; }

        [ForeignKey("ProfileId")]
        [InverseProperty("Comments")]
        public ProfileEntity Profile { get; set; }

        public ICollection<LikeCommentEntity> Likes { get; set; }

        public ICollection<SubCommentEntity> SubComments { get; set; }

        public ICollection<TaggedCommentEntity> TaggedProfiles { get; set; }

        public ICollection<HashtagCommentEntity> HashtagsInComments { get; set; }

    }
}
