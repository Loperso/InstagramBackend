using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class HashtagStoryEntity
    {
        [Key]
        public string HashtagStoryId { get; set; }

        public string HashtagId { get; set; }

        public HashtagEntity Hashtag { get; set; }

        public string StoryId { get; set; }

        public StoryEntity Story { get; set; }
    }
}
