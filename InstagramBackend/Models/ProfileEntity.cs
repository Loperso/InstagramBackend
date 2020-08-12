using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InstagramBackend.Models
{
    public class ProfileEntity
    {
        [Key]
        public string ProfileId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Username { get; set; }

        public string Description { get; set; }

        public string UrlProfilePhoto { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Profile")]
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

        public ICollection<LikeCommentEntity> LikedComments { get; set; }

        public ICollection<SubCommentEntity> SubCommentsByProfile { get; set; }

        public ICollection<LikeSubCommentEntity> LikedSubComments { get; set; }

        public ICollection<TaggedCommentEntity> taggedComments { get; set; }

        public ICollection<TaggedSubCommentEntity> taggedSubComments { get; set; }

    }
}
