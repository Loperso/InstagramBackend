using InstagramBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.DataAccess
{
    public class InstagramBackendContext: DbContext
    {

        public DbSet<CommentEntity> Comment { get; set; }

        public DbSet<ContentEntity> Content { get; set; }

        public DbSet<ContentStoryEntity> ContentStory { get; set; }

        public DbSet<FollowHashtagEntity> FollowHashtag { get; set; }

        public DbSet<FollowProfileEntity> FollowProfiles { get; set; }

        public DbSet<HashtagCommentEntity> HashtagComment { get; set; }

        public DbSet<HashtagEntity> Hashtag { get; set; }

        public DbSet<HashtagPostEntity> HashtagPost { get; set; }

        public DbSet<HashtagStoryEntity> HashtagStory { get; set; }

        public DbSet<HashtagSubCommentEntity> HashtagSubComment { get; set; }

        public DbSet<HighlightEntity> Highlight { get; set; }

        public DbSet<HighlightStoryEntity> HighlightStory { get; set; }

        public DbSet<LikeCommentEntity> LikeComment { get; set; }

        public DbSet<LikePostEntity> LikePost { get; set; }

        public DbSet<LikeSubCommentEntity> LikeSubComment { get; set; }

        public DbSet<PostEntity> Post { get; set; }

        public DbSet<PostSavedEntity> PostSaved { get; set; }

        public DbSet<ProfileEntity> Profile { get; set; }

        public DbSet<StoryEntity> Story { get; set; }

        public DbSet<SubCommentEntity> SubComment { get; set; }

        public DbSet<TaggedCommentEntity> TaggedComment { get; set; }

        public DbSet<TaggedEntity> Tagged { get; set; }

        public DbSet<TaggedSubCommentEntity> TaggedSubComment { get; set; }

        public DbSet<TypePostEntity> TypePost { get; set; }

        public DbSet<UserEntity> User { get; set; }

        public InstagramBackendContext(DbContextOptions<InstagramBackendContext> options) : base(options)
        { 
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}
