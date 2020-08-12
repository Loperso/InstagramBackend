using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("ProfileId")]
        [InverseProperty("Stories")]
        public ProfileEntity Profile { get; set; }

        public ICollection<ContentStoryEntity> ContentStory { get; set; }

        public ICollection<HighlightStoryEntity> HighlightsWithStory { get; set; }

        public ICollection<HashtagStoryEntity> HashtagsStory { get; set; }
    }
}
