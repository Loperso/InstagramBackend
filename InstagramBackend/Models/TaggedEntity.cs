using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class TaggedEntity
    {

        public string TaggedId { get; set; }

        public string ContentId { get; set; }

        public ContentEntity Content { get; set; }

        public string ProfileId { get; set; }

        public ProfileEntity ProfileTagged { get; set; }
    }
}
