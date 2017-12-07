using DI_container.Common;
using DI_container.Exceptions;
using Organizer.Model;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;

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
        public bool AddToDatabase<T>(IEnumerable<T> items) where T : class
        {
            if (typeof(T) == typeof(Note))
            {
                using (var db = _container.Resolve<NoteContext>())
                {
                    foreach (var item in items)
                    {
                        db.Notes.Add(item as Note ?? throw new InvalidOperationException());
                    }
                    db.SaveChanges();
                    return true;
                }
            }
            if (typeof(T) != typeof(CalendarEvent)) throw new ArgumentException($"Invalid type {typeof(T)}");
            using (var db = _container.Resolve<CalendarEventContext>())
            {
                foreach (var item in items)
                {
                    db.Events.Add(item as CalendarEvent ?? throw new InvalidOperationException());
                }
                db.SaveChanges();
                return true;
            }
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
                    return result;
                }
            }
            if (typeof(T) != typeof(CalendarEvent)) throw new ArgumentException($"Invalid type {typeof(T)}");
            using (var db = _container.Resolve<CalendarEventContext>())
            {
                var result = db.Events;
                return result;
            }
        }
    }
}
