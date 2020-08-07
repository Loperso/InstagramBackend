using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class LikePostEntity
    {

        public string LikePostId { get; set; }

        public DateTime LikePostDate { get; set; }

        public string ProfileId { get; set; }

        public ProfileEntity Profile { get; set; }

        
    }
}
