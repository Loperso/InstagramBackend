using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class FollowHashtagEntity
    {

        public string FollowHashtagId { get; set; }

        public string HashtagId { get; set; }

        public HashtagEntity Hashtag { get; set; }

        public string ProfileId { get; set; }

        public ProfileEntity Profile { get; set; }

    }
}
