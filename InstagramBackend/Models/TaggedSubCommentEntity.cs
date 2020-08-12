using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class TaggedSubCommentEntity
    {

        public string TaggedSubCommentId { get; set; }

        public string SubCommentId { get; set; }

        public SubCommentEntity SubComment { get; set; }

        public string ProfileTaggedId { get; set; }

        public ProfileEntity ProfileTagged { get; set; }

    }
}
