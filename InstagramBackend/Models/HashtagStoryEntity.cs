using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class HashtagStoryEntity
    {

        public string HashtagStoryId { get; set; }

        public string HashtagId { get; set; }

        public HashtagEntity Hashtag { get; set; }

        public string StoryId { get; set; }

        public StoryEntity Story { get; set; }
    }
}
