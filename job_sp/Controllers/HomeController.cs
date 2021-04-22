using System.Web.Mvc;

namespace job_sp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult login(string username , string password)
        {
            var lg = new Models.loginModel() ;
            lg.username = "abc";
            lg.password = "abc";
            if (username == lg.username && password == lg.password)
            {
               return Redirect("/ung_vien/page_UV");
            }
            else
            return View();
        }
        public ActionResult home_page()
        {
            return View();
        }
    }
}
