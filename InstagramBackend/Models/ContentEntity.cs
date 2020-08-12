using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("PostId")]
        [InverseProperty("ContentsPost")]
        public PostEntity Post { get; set; }

        public ICollection<TaggedEntity> Tagged{ get; set; }

    }
}
