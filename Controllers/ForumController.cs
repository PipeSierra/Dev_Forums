﻿using System;
using System.Linq;
using Dev_Forums.Data.Models;
using Dev_Forums.Models.Forum;
using Dev_Forums.Models.Posts;
using Dev_Forums.Service;
using Microsoft.AspNetCore.Mvc;

namespace Dev_Forums.Controllers
{
	public class ForumController : Controller
	{
		private readonly IForum _forumService;

		public ForumController(IForum forumService)
		{
			_forumService = forumService;
		}


		public IActionResult Index()
		{
			var forums = _forumService.GetAll()
				.Select(forum => new ForumListingModel
				{
					Id = forum.Id,
					Name = forum.Title,
					Description = forum.Description
				});

			var model = new ForumIndexModel
			{
				ForumList = forums
			};
			return View(model);
		}

		public IActionResult Topic(int id)
		{
			var forum = _forumService.GetById(id);
			var posts = forum.Posts;

			var postListings = posts.Select(post => new PostListingModel
			{
				Id = post.Id,
				AuthorId = post.User.Id,
				AuthorRating = post.User.Rating,
				Title = post.Title,
				DatePosted = post.Created.ToString(),
				RepliesCount = post.PostReplies.Count(),
				Forum = BuildForumListing(post)
			});

			var model = new ForumTopicModel
			{
				Posts = postListings,
				Forum = BuildForumListing(forum)
			};

			return View(model);
		}

		//algo ameme
		private ForumListingModel BuildForumListing(Post post)
		{
			var forum = post.Forum;
			return BuildForumListing(forum);
		}
		private ForumListingModel BuildForumListing(Forum forum)
		{
			return new ForumListingModel
			{
				Id = forum.Id,
				Name = forum.Title,
				Description = forum.Description,
				ImageUrl = forum.ImageUrl
			};
		}
	}
}