using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PizarraQuirofano.Controllers
{
    public class PizarraController : Controller
    {
        // GET: PizarraController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PizarraController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PizarraController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PizarraController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizarraController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PizarraController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizarraController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PizarraController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
