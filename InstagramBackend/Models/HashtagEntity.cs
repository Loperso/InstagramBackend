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

        public ICollection<HashtagStoryEntity> StoriesWithHashtag { get; set; }

        public ICollection<HashtagPostEntity> PostsWithHashtag { get; set; }

        public ICollection<FollowHashtagEntity> HashtagFollowers { get; set; }

        public ICollection<HashtagCommentEntity> CommentsWithHashtag { get; set; }

        public ICollection<HashtagSubCommentEntity> SubCommentsWithHashtag { get; set; }

    }
}
