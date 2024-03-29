﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.DataClassification;

namespace AspCoreCaslışması.ViewComponents.Blog
{
	public class WriterLastBlog : ViewComponent
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
		public IViewComponentResult Invoke()
		{
			var values = bm.GetBlogListByWriter(1);
			return View(values);
		}
	}
}
