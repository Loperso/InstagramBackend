using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class HashtagStoryEntity
    {
        [Key]
        public string HashtagStoryId { get; set; }

        public string HashtagId { get; set; }

        [ForeignKey("HashtagId")]
        [InverseProperty("StoriesWithHashtag")]
        public HashtagEntity Hashtag { get; set; }

        public string StoryId { get; set; }

        [ForeignKey("StoryId")]
        [InverseProperty("HashtagsStory")]
        public StoryEntity Story { get; set; }
    }
}
