using Organizer.Model;
using System.Data.Entity;

namespace Organizer.DataAccess
{
    public sealed class CalendarEventContext : DbContext
    {
        public CalendarEventContext() : base("DbConnection")
        {}

        public DbSet<CalendarEvent> Events { get; set; }
    }
}
