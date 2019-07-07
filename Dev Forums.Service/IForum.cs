using System.Collections.Generic;
using System.Threading.Tasks;
using Dev_Forums.Data.Models;

namespace Dev_Forums.Service
{
	public interface IForum
	{
		Forum GetById(int id);
		IEnumerable<Forum> GetAll();
		IEnumerable<ApplicactionUser> GetActveUsers();

		Task Create(Forum forum);
		Task Delete(int id);
		Task UpdateForumTitle(int forumId, string newtitle);
		Task UpdateForumDescription(int forumId, string newDescription);
	}
}