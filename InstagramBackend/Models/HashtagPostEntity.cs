using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class HashtagPostEntity
    {
        [Key]
        public string HashtagPostId { get; set; }

        public string HashtagId { get; set; }

        [ForeignKey("HashtagId")]
        [InverseProperty("PostsWithHashtag")]
        public HashtagEntity Hashtag { get; set; }

        public string PostId { get; set; }

        [ForeignKey("PostId")]
        [InverseProperty("HashtagsInPost")]
        public PostEntity Post { get; set; }

    }
}
