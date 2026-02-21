using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreEFCodeFirst.Controllers
{
    public class BatchController1 : Controller
    {
        // GET: BatchController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: BatchController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BatchController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BatchController1/Create
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

        // GET: BatchController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BatchController1/Edit/5
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

        // GET: BatchController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BatchController1/Delete/5
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
