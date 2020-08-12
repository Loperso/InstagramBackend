using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class HashtagSubComment
    {
        [Key]
        public string HashtagSubCommentId { get; set; }

        public string HashtagId { get; set; }

        public HashtagEntity Hashtag { get; set; }

        public string SubCommentId { get; set; }

        public SubCommentEntity SubComment { get; set; }

    }
}
