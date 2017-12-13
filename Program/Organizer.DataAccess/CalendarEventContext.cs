using Organizer.Model;
using System.Data.Entity;

namespace Organizer.DataAccess
{
    public sealed class CalendarEventContext : DbContext
    {
        public CalendarEventContext() : base("Name=DbConnection")
        {}

        public DbSet<CalendarEvent> Events { get; set; }

        public DbSet<Day> Days { get; set; }
    }
}
