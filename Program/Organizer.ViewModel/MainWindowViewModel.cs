using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organizer.Model;

namespace Organizer.ViewModel
{
    public class MainWindowViewModel
    {
        public IList<Note> GetNotes()
        {
            var result = new List<Note>
            {
                new Note((sbyte) 1, "First Note", "Content of note", DateTime.Now),
                new Note((sbyte) 2, "Second note", "Content of second note", DateTime.Now)
            };
            return result;
        }

        public IDictionary<DateTime, IList<CalendarEvent>> GetEvents()
        {
            var today = new List<CalendarEvent>
            {
                new CalendarEvent("University", "Should doing labs", "Minsk", DateTime.Now, DateTime.Now)
            };

            var tommorow = new List<CalendarEvent>
            {
                new CalendarEvent("Epam labs", "Will listen lecture", "Epam Training Center", new DateTime(2017, 12, 08, 10, 00, 00), new DateTime(2017, 12, 08, 12, 00, 00))
            };
            
            var result = new Dictionary<DateTime, IList<CalendarEvent>>();
            result.Add(DateTime.Today, today);
            result.Add(tommorow[0].StartTime.Date, tommorow);
            return result;
        }
    }
}
