using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    class ProfileEntity
    {

        public string ProfileId { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public string Description { get; set; }

        public string ProfilePhoto { get; set; }

        public string UserId { get; set; }

        public UserEntity User { get; set; }
    }
}
