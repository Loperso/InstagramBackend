using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class ContentStoryEntity
    {

        public string ContentStoryId { get; set; }

        public string UrlStorage { get; set; }

        public string StoryId { get; set; }

        public StoryEntity Story { get; set; }
    }
}
