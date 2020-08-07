using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class HashtagPostEntity
    {

        public string HashtagPostId { get; set; }

        public string HashtagId { get; set; }

        public HashtagEntity Hashtag { get; set; }

        public string PostId { get; set; }

        public PostEntity Post { get; set; }

    }
}
