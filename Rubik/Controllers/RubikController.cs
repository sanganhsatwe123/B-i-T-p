using Rubik.Models;
using System.Linq;
using System.Web.Mvc;

namespace Rubik.Controllers
{
    public class RubikController : Controller
    {
        // GET: Rubik
        RubikStoreContext data = new RubikStoreContext();
        public ActionResult Index()
        {
            var all_rubik = from s in data.Rubiks select s;
            return View(all_rubik);
        }
    }
}