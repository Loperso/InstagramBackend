using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class LikeSubCommentEntity
    {
        [Key]
        public string LikeSubCommentId { get; set; }

        [Required]
        public DateTime LikeSubCommentDate { get; set; }

        public string SubCommentId { get; set; }

        public SubCommentEntity SubComment { get; set; }

        public string ProfileId { get; set; }

        public ProfileEntity Profile { get; set; }

    }
}
