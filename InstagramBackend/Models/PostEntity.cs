﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class PostEntity
    {
        [Key]
        public string PostId { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        [Required]
        public DateTime PostDate { get; set; }

        public string ProfileId { get; set; }

        [ForeignKey("ProfileId")]
        [InverseProperty("Posts")]
        public ProfileEntity Profile { get; set; }

        public string TypePostId { get; set; }

        [ForeignKey("TypePostId")]
        [InverseProperty("Posts")]
        public TypePostEntity TypePost{ get; set; }

        public ICollection<ContentEntity> ContentsPost{ get; set; }

        public ICollection<LikePostEntity> Likes { get; set; }

        public ICollection<PostSavedEntity> PostSavedByProfiles { get; set; }

        public ICollection<HashtagPostEntity> HashtagsInPost { get; set; }

        public ICollection<CommentEntity> Comments { get; set; }


    }
}
