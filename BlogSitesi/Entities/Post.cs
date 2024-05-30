﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSitesi.Entities
{
    public class Post
    {
        public int PostId {  get; set; }    
        public string Title { get; set; }   
        public string Content { get; set; }
        public string ImagePath { get; set; } 
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
