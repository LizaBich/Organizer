using DI_container.Common;
using Organizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.EnterpriseServices;
using System.Linq;
using DI_container.Exceptions;
using CalendarEvent = Organizer.Model.CalendarEvent;

namespace Organizer.DataAccess
{
    /// <summary>
    /// Класс, предоставляющий доступ к бд
    /// </summary>
    public sealed class DataManager
    {
        /// <summary>
        /// DI контейнер для внедрения зависимостей
        /// </summary>
        private readonly IDiContainer _container;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="container">DI контейнер для внедрения зависимостей</param>
        public DataManager(IDiContainer container)
        {
            _container = container;
            _container.Register<NoteContext>();
            _container.Register<CalendarEventContext>();
        }

        /// <summary>
        /// Позволяет добавить в бд таблицу
        /// </summary>
        /// <typeparam name="T">Тип вносимой сущности</typeparam>
        /// <param name="items">Перечисление элементов</param>
        /// <exception cref="InvalidOperationException">InvalidOperationException</exception>
        /// <exception cref="RegistrationException">RegistrationException</exception>
        public bool AddToDatabase(IEnumerable<Note> items = null, IDictionary<Day, IList<CalendarEvent>> evItems = null)
        {
            // Внесение в базу данных заметок
            if (items != null && evItems == null) return AddNotesToDb(items);
            // Внесение в бвзу данных событий
            if (items == null && evItems != null) return AddEventsToDb(evItems);
            throw new ArgumentException("Invalid arguments");
        }


        /// <summary>
        /// Метод для получения данных из бд
        /// </summary>
        /// <typeparam name="T">Тип входных данных</typeparam>
        /// <returns>DbSet, содержащий элементы типа Note
        /// или CalendarEvent</returns>
        /// <exception cref="CreationException">CreationException</exception>
        /// <exception cref="ArgumentException">ArgumentException</exception>
        public object GetFromDatabase<T>() where T : class
        {
            if (typeof(T) == typeof(Note))
            {
                using (var db = _container.Resolve<NoteContext>())
                {
                    var result = db.Notes;
                    result.Load();
                    return result.Local.ToList();
                }
            }
            if (typeof(T) != typeof(CalendarEvent)) throw new ArgumentException($"Invalid type {typeof(T)}");
            using (var db = _container.Resolve<CalendarEventContext>())
            {
                IDictionary<Day, IList<CalendarEvent>> result = new Dictionary<Day, IList<CalendarEvent>>();
                foreach (var day in db.Days.Include(e => e.Events))
                {
                    result.Add(day, day.Events);
                }
                return result;
            }
        }

        /// <summary>
        /// Метод для удаления элемента из бд
        /// </summary>
        /// <param name="obj">Ссылка на объект, который надо удалить</param>
        public void Remove(object obj)
        {
            switch (obj)
            {
                case Note _:
                    using (var db = _container.Resolve<NoteContext>())
                    {
                        db.Notes.Attach(obj as Note ?? throw new InvalidOperationException("Argument can'y be null."));
                        db.Entry((Note)obj).State = EntityState.Deleted;
                        db.SaveChanges();
                    }
                    break;
                case CalendarEvent _:
                    using (var db = _container.Resolve<CalendarEventContext>())
                    {
                        var evEdit = db.Events.First(item => item.Id == ((CalendarEvent)obj).Id);
                        db.Events.Attach(evEdit);
                        db.Entry(evEdit).State = EntityState.Deleted;
                        db.SaveChanges();
                    }
                    break;
                default:
                    throw new ArgumentException($"Can't cast type {obj.GetType()} to the Note or CalendarEvent types");
            }
        }

        private bool AddNotesToDb(IEnumerable<Note> notes)
        {
            using (var db = _container.Resolve<NoteContext>())
            {
                var notAdded = notes.Where(note => note.Id == 0);
                var added = notes.Except(notAdded);
                foreach (var item in added)
                {
                    var notChangedItem = db.Notes.First(note => note.Id == item.Id);
                    notChangedItem.Color = item.Color;
                    notChangedItem.Content = item.Content;
                    notChangedItem.Name = item.Name;
                    notChangedItem.Priority = item.Priority;
                    notChangedItem.TimeOfChange = item.TimeOfChange;
                }
                foreach (var item in notAdded)
                {
                    db.Notes.Add(item);
                }
                db.SaveChanges();
            }
            return true;
        }

        private bool AddEventsToDb(IDictionary<Day, IList<CalendarEvent>> fullEvents)
        {
            var lists = fullEvents.Values.Where(item => item.Count > 0);

            var events = (from list in lists
                          from ev in list
                          select ev).Distinct();

            var days = fullEvents.Keys /*.Where(item => item.Events.Count != 0)*/;
            var notAddedEvents = events.Where(ev => ev.Id == 0);
            var addedEvents = events.Except(notAddedEvents);

            using (var db = _container.Resolve<CalendarEventContext>())
            {
                // Редактирование
                foreach (var ev in addedEvents)
                {
                    var temp = db.Events.First(item => item.Id == ev.Id);
                    temp.StartTime = ev.StartTime;
                    temp.Content = ev.Content;
                    temp.EndTime = ev.EndTime;
                    temp.Name = ev.Name;
                    temp.Place = ev.Place;
                }
                // Добавление новых
                db.Events.AddRange(notAddedEvents);
                db.SaveChanges();
                foreach (var day in days)
                {
                    foreach (var ev in events)
                    {
                        if (fullEvents[day].Contains(ev) && !day.Events.Contains(ev))
                        {
                            day.Events.Add(ev);
                        }
                    }
                }
                var notAddedDays = days.Where(day => day.Id == 0);
                db.Days.AddRange(notAddedDays);
                db.SaveChanges();  
            }
            return true;
        }
    }
}
