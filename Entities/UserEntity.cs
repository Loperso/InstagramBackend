﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    class UserEntity
    {
        public string UserId { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public ProfileEntity Profile{ get; set; }
    }
}