using System;
using System.Collections.Generic;

namespace Organizer.Model
{
    public class CalendarEvent
    {
        public CalendarEvent()
        {
            Days = new List<DateTime>();
        }

        public CalendarEvent(string name, string content, string place, DateTime startTime, DateTime endTime) : this()
        {
            Name = name;
            Content = content;
            Place = place;
            StartTime = startTime;
            EndTime = endTime;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public string Place { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public IList<DateTime> Days { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is CalendarEvent)) return false;
            var ev = obj as CalendarEvent;
            return ev.Name.Equals(Name) && ev.Place.Equals(Place)
                && ev.StartTime.Equals(StartTime) && ev.Content.Equals(Content)
                && ev.EndTime.Equals(EndTime);
        }

        public override int GetHashCode()
        {
            return (Id * 15 / 2 + 1024) * 512;
        }
    }
}
