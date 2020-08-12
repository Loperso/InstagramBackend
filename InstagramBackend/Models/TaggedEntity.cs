using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class TaggedEntity
    {
        [Key]
        public string TaggedId { get; set; }

        public string ContentId { get; set; }

        [Required]
        public ContentEntity Content { get; set; }

        public string ProfileId { get; set; }

        public ProfileEntity ProfileTagged { get; set; }
    }
}
