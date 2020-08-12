using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class ContentEntity
    {
        [Key]
        public string ContentId { get; set; }

        [Required]
        public string UrlStorage { get; set; }

        public string PostId { get; set; }

        public PostEntity Post { get; set; }

        public ICollection<TaggedEntity> Taggeds{ get; set; }
    }
}
