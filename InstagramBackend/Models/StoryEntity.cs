using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class StoryEntity
    {

        public string StoryId { get; set; }

        public DateTime StoryDate { get; set; }

        public string ProfileId { get; set; }

        public ProfileEntity Profile { get; set; }

        public ICollection<ContentStoryEntity> ContentStory { get; set; }

        public ICollection<HighlightStoryEntity> HighlightsWithStory { get; set; }

        public ICollection<HashtagStoryEntity> HashtagStories { get; set; }
    }
}
