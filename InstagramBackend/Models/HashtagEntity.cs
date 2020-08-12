using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class HashtagEntity
    {
        [Key]
        public string HashtagId { get; set; }

        [Required]
        public string HashtagTitle { get; set; }

        public ICollection<HashtagStoryEntity> HashtagStories { get; set; }

        public ICollection<HashtagPostEntity> HashtagPosts { get; set; }

        public ICollection<FollowHashtagEntity> HashtagFollowers { get; set; }

        public ICollection<HashtagCommentEntity> HashtagComments { get; set; }

        public ICollection<HashtagSubComment> HashtagSubComments { get; set; }

    }
}
