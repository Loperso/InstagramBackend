using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class TaggedCommentEntity
    {
        [Key]
        public string TaggedCommentId { get; set; }

        public string CommentId { get; set; }

        [ForeignKey("CommentId")]
        [InverseProperty("TaggedProfiles")]
        public CommentEntity Comment { get; set; }

        public string ProfileTaggedId { get; set; }

        [ForeignKey("ProfileTaggedId")]
        [InverseProperty("TaggedComments")]
        public ProfileEntity ProfileTagged { get; set; }

    }
}
