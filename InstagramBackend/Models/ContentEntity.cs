using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class ContentEntity
    {

        public string ContentId { get; set; }

        public string UrlStorage { get; set; }

        public string PostId { get; set; }

        public PostEntity Post { get; set; }

        public ICollection<TaggedEntity> Taggeds{ get; set; }
    }
}
