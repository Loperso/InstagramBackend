using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class ContentStoryEntity
    {
        [Key]
        public string ContentStoryId { get; set; }

        [Required]
        public string UrlStorage { get; set; }

        public string StoryId { get; set; }

        public StoryEntity Story { get; set; }
    }
}
