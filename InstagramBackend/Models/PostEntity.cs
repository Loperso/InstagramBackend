using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class PostEntity
    {

        public string PostId { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public DateTime PostDate { get; set; }

        public string ProfileId { get; set; }

        public ProfileEntity Profile { get; set; }

        public string TypePostId { get; set; }

        public TypePostEntity TypePost{ get; set; }

        public ICollection<ContentEntity> TaggedContent{ get; set; }

        public ICollection<LikePostEntity> Likes { get; set; }

        public ICollection<PostSavedEntity> PostSavedByProfiles { get; set; }

        public ICollection<HashtagPostEntity> HashtagPosts { get; set; }

        public ICollection<CommentEntity> Comments { get; set; }


    }
}
