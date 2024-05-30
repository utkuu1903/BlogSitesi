﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSitesi.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName {  get; set; }
        public string Password { get; set; }
        public List<Post> Posts { get; set; }


    }
}
