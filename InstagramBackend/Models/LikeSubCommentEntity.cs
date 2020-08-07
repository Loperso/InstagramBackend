using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class LikeSubCommentEntity
    {

        public string LikeSubCommentId { get; set; }

        public DateTime LikeSubCommentDate { get; set; }

        public string SubCommentId { get; set; }

        public SubCommentEntity SubComment { get; set; }

        public string ProfileId { get; set; }

        public ProfileEntity Profile { get; set; }

    }
}
