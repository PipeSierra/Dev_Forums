using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dev_Forums.Data;
using Dev_Forums.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Dev_Forums.Service
{
	public class ForumService : IForum
	{
		private readonly ApplicationDbContext _context;
		public ForumService(ApplicationDbContext context)
		{
			_context = context;
		}

		public Task Create(Forum forum)
		{
			throw new NotImplementedException();
		}

		public Task Delete(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ApplicactionUser> GetActveUsers()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Forum> GetAll()
		{
			//the include method is invoked in order to load the Posts related to the forums, so they not be null when they be evaluated
			return _context.Forums.Include(forum => forum.Posts);
		}

		public Forum GetById(int id)
		{
			var forum = _context.Forums.Where(f => f.Id == id)
				.Include(f => f.Posts)
					.ThenInclude(p => p.User)
				.Include(f => f.Posts)
					.ThenInclude(p => p.PostReplies)
						.ThenInclude(r => r.User)
				.FirstOrDefault();

			return forum;
		}

		public Task UpdateForumDescription(int forumId, string newDescription)
		{
			throw new NotImplementedException();
		}

		public Task UpdateForumTitle(int forumId, string newtitle)
		{
			throw new NotImplementedException();
		}
	}
}
