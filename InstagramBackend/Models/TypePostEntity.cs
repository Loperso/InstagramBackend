using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class TypePostEntity
    {

        public string TypePostId { get; set; }

        public string Name { get; set; }

        public ICollection<PostEntity> Post { get; set; }
    }
}
