using citb517_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace citb517_2.Controllers
{
    public class HomeController : Controller
    {
        private CommentContext _db = new CommentContext();

        public ActionResult Index()
        {
            var showComments = from comment in _db.Comments orderby comment.DateAdded descending select comment;
            ViewBag.Comments = showComments.ToList();
            ViewBag.Db = _db;

            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PostComment(CommentModel commentModel)
        {
            Comment comment = new Comment();
          
            comment.Name = commentModel.Name;
            comment.Text = commentModel.Comment;
            comment.DateAdded = DateTime.UtcNow;

            _db.Comments.Add(comment);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}