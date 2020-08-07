﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramBackend.Models
{
    public class HighlightStoryEntity
    {

        public string HighlightStoryEntityId { get; set; }

        public string StoryId { get; set; }

        public StoryEntity Story { get; set; }

        public string HighlightId { get; set; }

        public HighlightEntity Highlight { get; set; }

    }
}