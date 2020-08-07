using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class HashtagEntity
    {

        public string HashtagId { get; set; }

        public string HashtagTitle { get; set; }

        public ICollection<HashtagStoryEntity> HashtagStories { get; set; }

        public ICollection<HashtagPostEntity> HashtagPosts { get; set; }

        public ICollection<FollowHashtagEntity> HashtagFollowers { get; set; }

    }
}
