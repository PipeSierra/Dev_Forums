using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dev_Forums.Data;
using Dev_Forums.Data.Models;

namespace Dev_Forums.Service
{
	public class PostService : IPost
	{
		private readonly ApplicationDbContext _context;
		public PostService(ApplicationDbContext context)
		{
			_context = context;
		}

		public Task Add(Post post)
		{
			throw new NotImplementedException();
		}

		public Task Delete(int id)
		{
			throw new NotImplementedException();
		}

		public Task EditPostContent(int id, string newContent)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Post> GetAll(int id)
		{
			throw new NotImplementedException();
		}

		public Post GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Post> GetFilteredPost(string serachQry)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Post> GetPostByForum(int id)
		{
			return _context.Forums
				.Where(f => f.Id == id)
				.FirstOrDefault()
				.Posts;

		}

	}
}
