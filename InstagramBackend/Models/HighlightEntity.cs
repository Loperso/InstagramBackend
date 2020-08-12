using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class HighlightEntity
    {
        [Key]
        public string HighlightId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string UrlHighlightPhoto { get; set; }

        [Required]
        public DateTime HighlightDate { get; set; }

        public string ProfileId { get; set; }

        [ForeignKey("ProfileId")]
        [InverseProperty("Highlights")]
        public ProfileEntity HighlightProfile { get; set; }

        public ICollection<HighlightStoryEntity> HighlightStories { get; set; }

    }
}
