using System;

namespace Organizer.Model
{
    public class CalendarEvent
    {
        public CalendarEvent(string name, string content, string place, DateTime startTime, DateTime endTime)
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
    }
}
