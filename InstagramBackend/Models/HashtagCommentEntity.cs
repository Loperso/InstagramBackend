using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class HashtagCommentEntity
    {
        [Key]
        public string HashtagCommentId { get; set; }

        public string HashtagId { get; set; }

        [ForeignKey("HashtagId")]
        [InverseProperty("CommentsWithHashtag")]
        public HashtagEntity Hashtag { get; set; }

        public string CommentId { get; set; }

        [ForeignKey("CommentId")]
        [InverseProperty("HashtagsInComment")]
        public CommentEntity Comment { get; set; }

    }
}
