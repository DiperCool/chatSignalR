﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatSignalR.Model
{
    public class Massage
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public User User { get; set; }



    }
}
