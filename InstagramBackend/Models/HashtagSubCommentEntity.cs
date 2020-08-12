using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class HashtagSubCommentEntity
    {
        [Key]
        public string HashtagSubCommentId { get; set; }

        public string HashtagId { get; set; }

        [ForeignKey("HashtagId")]
        [InverseProperty("SubCommentsWithHashtag")]
        public HashtagEntity Hashtag { get; set; }

        public string SubCommentId { get; set; }

        [ForeignKey("SubCommentId")]
        [InverseProperty("HashtagsSubComment")]
        public SubCommentEntity SubComment { get; set; }

    }
}
