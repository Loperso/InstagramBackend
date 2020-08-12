using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class TypePostEntity
    {
        [Key]
        public string TypePostId { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<PostEntity> Post { get; set; }
    }
}
