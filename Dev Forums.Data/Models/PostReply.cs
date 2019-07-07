using System;

namespace Dev_Forums.Data.Models
{
     public class PostReply
     {
          public int Id { get; set; }
          public string Content { get; set; }
          public DateTime Created { get; set; }

          public virtual ApplicactionUser User{ get; set; }
          public virtual Post Post{ get; set; }
     }
}