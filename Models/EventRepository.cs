using System.Collections.Generic;
using System.Linq;

namespace EventManagementMVC.Models
{
    public static class EventRepository
    {
        private static List<Event> _events = new List<Event>();
        private static int _nextId = 1;

        public static List<Event> GetAll() => _events;

        public static void Add(Event ev)
        {
            ev.Id = _nextId++;
            _events.Add(ev);
        }

        public static Event? Get(int id) => _events.FirstOrDefault(e => e.Id == id);

        public static void Update(Event ev)
        {
            var existing = Get(ev.Id);
            if (existing != null)
            {
                existing.Title = ev.Title;
                existing.Description = ev.Description;
                existing.Date = ev.Date;
                existing.Time = ev.Time;
                existing.Location = ev.Location;
            }
        }

        public static void Delete(int id)
        {
            var ev = Get(id);
            if (ev != null)
            {
                _events.Remove(ev);
            }
        }
    }
}