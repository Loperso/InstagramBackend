using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class LikeCommentEntity
    {

        public string LikeCommentId { get; set; }

        public DateTime LikeCommentDate { get; set; }

        public string CommentId { get; set; }

        public CommentEntity Comment { get; set; }

        public string ProfileId { get; set; }

        public ProfileEntity Profile { get; set; }

    }
}
