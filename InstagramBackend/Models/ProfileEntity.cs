using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramBackend.Models
{
    public class ProfileEntity
    {

        public string ProfileId { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public string Description { get; set; }

        public string ProfilePhoto { get; set; }

        public string UserId { get; set; }

        public UserEntity User { get; set; }

        public ICollection<PostEntity> Posts{ get; set; }

        public ICollection<TaggedEntity> TaggedPosts{ get; set; }

        public ICollection<LikePostEntity> LikesGiven { get; set; }

        public ICollection<PostSavedEntity> PostsSaved { get; set; }

        public ICollection<StoryEntity> Stories { get; set; }

        public ICollection<HighlightEntity> Highlights { get; set; }

        public ICollection<FollowProfileEntity> Followers { get; set; }

        public ICollection<FollowProfileEntity> Followed { get; set; }

        public ICollection<FollowHashtagEntity> FollowHashtags { get; set; }

        public ICollection<CommentEntity> Comments { get; set; }

        public ICollection<LikeCommentEntity> LikeComments { get; set; }

        public ICollection<SubCommentEntity> SubComments { get; set; }

        public ICollection<LikeSubCommentEntity> LikeSubComments { get; set; }

    }
}
