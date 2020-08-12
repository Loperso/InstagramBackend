using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class PostSavedEntity
    {
        [Key]
        public string PostSavedId { get; set; }

        public string ProfileId { get; set; }

        [ForeignKey("ProfileId")]
        [InverseProperty("PostsSaved")]
        public ProfileEntity Profile { get; set; }

        public string PostId { get; set; }

        [ForeignKey("PostId")]
        [InverseProperty("PostSavedByProfiles")]
        public PostEntity Post { get; set; }
    }
}
