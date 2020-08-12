using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class TaggedCommentEntity
    {

        public string TaggedCommentId { get; set; }

        public string CommentId { get; set; }

        public CommentEntity Comment { get; set; }

        public string ProfileTaggedId { get; set; }

        public ProfileEntity ProfileTagged { get; set; }

    }
}
