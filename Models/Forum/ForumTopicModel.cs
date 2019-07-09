using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dev_Forums.Models.Posts;

namespace Dev_Forums.Models.Forum
{
	public class ForumTopicModel
	{
		public ForumListingModel Forum { get; set; }
		public IEnumerable<PostListingModel> Posts { get; set; }

	}
}
