using ASPDemo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ASPDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        private async Task<ActionResult> ListPeople()
        {
            IEnumerable<Person> people = await ApiHelper.RequestPeople();
            return View(people);
        }

        public async Task<ActionResult> ListPeopleServerSide()
        {
            return await ListPeople();
        }

        public async Task<ActionResult> ListPeopleClientSide()
        {
            return await ListPeople();
        }
    }
}