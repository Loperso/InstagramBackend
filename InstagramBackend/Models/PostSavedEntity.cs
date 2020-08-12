using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class PostSavedEntity
    {
        [Key]
        public string PostSavedId { get; set; }

        public string ProfileId { get; set; }

        public ProfileEntity Profile { get; set; }

        public string PostId { get; set; }

        public PostEntity Post { get; set; }
    }
}
