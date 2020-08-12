using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class TaggedEntity
    {
        [Key]
        public string TaggedId { get; set; }

        public string ContentId { get; set; }

        [ForeignKey("ContentId")]
        [InverseProperty("Tagged")]
        public ContentEntity Content { get; set; }

        public string ProfileId { get; set; }

        [ForeignKey("ProfileId")]
        [InverseProperty("TaggedPosts")]
        public ProfileEntity ProfileTagged { get; set; }
    }
}
