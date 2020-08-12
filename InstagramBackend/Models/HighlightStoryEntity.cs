using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class HighlightStoryEntity
    {
        [Key]
        public string HighlightStoryEntityId { get; set; }

        public string StoryId { get; set; }

        public StoryEntity Story { get; set; }

        public string HighlightId { get; set; }

        [ForeignKey("HighlightId")]
        [InverseProperty("HighlightStories")]
        public HighlightEntity Highlight { get; set; }

    }
}
