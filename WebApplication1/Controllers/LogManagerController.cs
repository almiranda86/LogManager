using LogManager.Domain.Command;
using LogManagerApplication.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LogManagerApplication.Controllers
{
    public class LogManagerController : Controller
    {
        // GET: LogManagerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LogManagerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LogManagerController/Create
        public Task<IActionResult> Create(CreateLogRequest createLogRequest, CancellationToken cancellationToken = default)
        {
            return this.HandleQueryRequest<CreateLogRequest, CreateLogResult>(createLogRequest, cancellationToken);
        }

        // POST: LogManagerController/Create
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

        // GET: LogManagerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LogManagerController/Edit/5
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

        // GET: LogManagerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LogManagerController/Delete/5
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
