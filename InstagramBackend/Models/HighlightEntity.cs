using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class HighlightEntity
    {

        public string HighlightId { get; set; }

        public string Title { get; set; }

        public string HighlightPhoto { get; set; }

        public DateTime HighlightDate { get; set; }

        public string ProfileId { get; set; }

        public ProfileEntity Profile { get; set; }

    }
}
