﻿using System;
using System.Collections.Generic;

namespace Dev_Forums.Data.Models
{
	public class Post
     {
          public int Id { get; set; }
          public string Title { get; set; }
          public string Content { get; set; }
          public DateTime Created { get; set; }

          public virtual ApplicactionUser User { get; set; }
          public virtual Forum Forum { get; set; }
          public virtual IEnumerable<PostReply> PostReplies { get; set; }
     }
}