using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class SubCommentEntity
    {

        public string SubCommentId { get; set; }

        public string Content { get; set; }

        public DateTime SubCommentDate { get; set; }

        public string CommentId { get; set; }

        public CommentEntity Comment { get; set; }

        public string ProfileId { get; set; }

        public ProfileEntity Profile { get; set; }

        public ICollection<LikeSubCommentEntity> LikeSubComments { get; set; }

    }
}
