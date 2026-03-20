using Microsoft.AspNetCore.Mvc;
using EventManagementMVC.Models;
using Microsoft.AspNetCore.Authorization;

namespace EventManagementMVC.Controllers
{
    [Authorize]
    public class EventsController : Controller
    {
        // Show all events
        public IActionResult Index()
        {
            var events = EventRepository.GetAll();
            return View(events);
        }

        // Show create page
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Event ev)
        {
            if (ModelState.IsValid)
            {
                EventRepository.Add(ev);
                return RedirectToAction(nameof(Index));
            }
            return View(ev);
        }

        // Show edit page
        public IActionResult Edit(int id)
        {
            var ev = EventRepository.Get(id);
            if (ev == null) return NotFound();
            return View(ev);
        }

        [HttpPost]
        public IActionResult Edit(Event ev)
        {
            if (ModelState.IsValid)
            {
                EventRepository.Update(ev);
                return RedirectToAction(nameof(Index));
            }
            return View(ev);
        }

        // Delete event
        public IActionResult Delete(int id)
        {
            EventRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}