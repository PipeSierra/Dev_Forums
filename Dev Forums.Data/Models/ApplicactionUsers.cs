using System;
using Microsoft.AspNetCore.Identity;

namespace Dev_Forums.Data.Models
{
	public class ApplicactionUser : IdentityUser
	{
		public int Rating { get; set; }
		public string ProfileUser { get; set; }
		public DateTime MemberSince { get; set; }
		public bool IsActive { get; set; }
	}
}