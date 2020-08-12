using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class TaggedSubCommentEntity
    {

        public string TaggedSubCommentId { get; set; }

        public string SubCommentId { get; set; }

        [ForeignKey("SubCommentId")]
        [InverseProperty("TaggedProfiles")]
        public SubCommentEntity SubComment { get; set; }

        public string ProfileTaggedId { get; set; }

        [ForeignKey("ProfileTaggedId")]
        [InverseProperty("TaggedComments")]
        public ProfileEntity ProfileTagged { get; set; }

    }
}
