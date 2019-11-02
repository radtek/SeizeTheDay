﻿using System.Web.Mvc;

namespace SeizeTheDay.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ForumPostController : Controller
    {
        // GET: Admin/ForumPost
        public ActionResult Index()
        {
            return View();
        }
    }
}