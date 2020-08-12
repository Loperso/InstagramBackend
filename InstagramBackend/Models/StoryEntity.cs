using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class StoryEntity
    {
        [Key]
        public string StoryId { get; set; }

        [Required]
        public DateTime StoryDate { get; set; }

        public string ProfileId { get; set; }

        public ProfileEntity Profile { get; set; }

        public ICollection<ContentStoryEntity> ContentStory { get; set; }

        public ICollection<HighlightStoryEntity> HighlightsWithStory { get; set; }

        public ICollection<HashtagStoryEntity> HashtagStories { get; set; }
    }
}
