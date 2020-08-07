using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class CommentEntity
    {

        public string CommentId { get; set; }

        public string Content { get; set; }

        public DateTime CommentDate { get; set; }

        public string PostId { get; set; }

        public PostEntity Post { get; set; }

        public string ProfileId { get; set; }

        public ProfileEntity Profile { get; set; }

        public ICollection<LikeCommentEntity> LikeComments { get; set; }

        public ICollection<SubCommentEntity> SubComments { get; set; }

    }
}
