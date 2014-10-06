using System.Web.Mvc;
using System.Diagnostics;

namespace GlimpseExperiments.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Trace.Write("This is a trace message");
            Trace.TraceWarning("Warning");
            Trace.TraceInformation("Information");
            Trace.TraceError("Error");
            Trace.Write("Category", "Message");

            Session["testData"] = "test value";
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
