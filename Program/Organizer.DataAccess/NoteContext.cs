using Organizer.Model;
using System.Data.Entity;

namespace Organizer.DataAccess
{
    /// <inheritdoc cref="DbContext"/>
    /// <summary>
    /// Данный класс определяет контекст данных для Note.
    /// Посредник между бд и классами. 
    /// </summary>
    public sealed class NoteContext : DbContext
    {
        /// <inheritdoc cref="DbContext(string)"/>
        /// <summary>
        /// Конструктор класса
        /// DbConnection - имя строки подключения к бд
        /// </summary>
        public NoteContext() : base("DbConnection")
        {
            
        }

        /// <summary>
        /// Набор сущностей, получаемых из базы
        /// </summary>
        public DbSet<Note> Notes { get; set; }
    }
}
