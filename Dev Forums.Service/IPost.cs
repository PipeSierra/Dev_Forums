using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dev_Forums.Data.Models;

namespace Dev_Forums.Service
{
	public interface IPost
	{
		Post GetById(int id);
		IEnumerable<Post> GetAll(int id);
		IEnumerable <Post> GetFilteredPost(string serachQry);
		IEnumerable<Post> GetPostByForum(int id);

		Task Add(Post post);
		Task Delete(int id);
		Task EditPostContent(int id, string newContent);
	}
}
