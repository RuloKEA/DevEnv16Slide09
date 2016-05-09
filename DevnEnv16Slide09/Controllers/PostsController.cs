
using DevnEnv16Slide09.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevnEnv16Slide09.Controllers
{
    public class PostsController : Controller
    {
        // GET: Posts
        public ActionResult Index()
        {
            if (Session["posts"] == null)
            {
                List<Post> myPosts = new List<Post>();
                Post post = new Post {  Title= "junk", Body = "sdfsdf" };
                Post post1 = new Post { Title = "jwadsaunk", Body = "sdfsasddf"};
                myPosts.Add(post);
                myPosts.Add(post1);
                Session["posts"] = myPosts;
            }
            List<Post> posts = (List<Post>)Session["posts"];
            return View(posts);
        }
        //GET
        public ActionResult About()
        {
            return View();
        }
        //POST
        [HttpPost]
        public ActionResult About(string username, string password)
        {
            
            return Content(username+" "+password);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Post post)
        {
            if(ModelState.IsValid)
            {
                //get list from session
                List<Post> myPosts = (List<Post>)Session["posts"];
                // add post to list
                myPosts.Add(post);
                //save list in session
                // Session["posts"] = myPosts;
                //redrect to index
                return RedirectToAction("index");
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            List<Post> myPosts = (List<Post>)Session["posts"];
            Post post = myPosts.Find(m => m.PostId == id);
         
            return View(post);
        }

        public ActionResult Edit(int id)
        {
            List<Post> myPosts = (List<Post>)Session["posts"];
            Post post = myPosts.Find(m => m.PostId == id);

            return View(post);
        }

        [HttpPost]
        public ActionResult Edit(Post post)
        {
            if (ModelState.IsValid)
            {
                //get list from session
                List<Post> myPosts = (List<Post>)Session["posts"];
                Post oldPost = myPosts.Find(p => p.PostId == post.PostId);
                oldPost.Title = post.Title;
                oldPost.Body = post.Body;

                //for (int i = 0; i < myPosts.Count; i++)
                //{
                //    if (myPosts[i].PostId == post.PostId)
                //    {
                //        myPosts[i].Title = post.Title;
                //        myPosts[i].Body = post.Body;
                //        break;
                //    }
                //}

                //redrect to index
                return RedirectToAction("index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            List<Post> myPosts = (List<Post>)Session["posts"];
            Post post = myPosts.Find(m => m.PostId == id);
            myPosts.Remove(post);
            return RedirectToAction("index");
        }

        public ActionResult Junk()
        {
            ViewBag.message = "Hello from controller";
            return PartialView("_Junk");
        }
    }
}