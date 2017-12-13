using System;
using System.Collections.Generic;

namespace Organizer.Model
{
    public class Day
    {
        public Day()
        {
            Events = new List<CalendarEvent>();
        }

        public Day(DateTime date) : this()
        {
            Date = date;
        }

        public Day(DateTime date, IList<CalendarEvent> events) : this(date)
        {
            Events = events;
        }

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public IList<CalendarEvent> Events { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Day)) return false;
            return (obj as Day).Date == Date;
        }

        public override int GetHashCode()
        {
            return Id * 89475 / 2 + 8984938;
        }
    }
}
