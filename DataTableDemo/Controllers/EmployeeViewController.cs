using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace DataTableDemo.Controllers
{
    public class EmployeeViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            var emp = ControllerUtility.GetEmployee().FirstOrDefault(e => e.Id == id);
            return View(emp);
        }
        public IActionResult DataTableWithButton()
        {
            return View();
        }
    }
}