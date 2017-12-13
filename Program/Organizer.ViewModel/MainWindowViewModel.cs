using System;
using System.Collections.Generic;
using Organizer.Model;
using System.Drawing;
using DI_container.Common;
using Organizer.DataAccess;

namespace Organizer.ViewModel
{
    public class MainWindowViewModel
    {
        private readonly IDiContainer _container;
        private readonly DataManager _manager;

        public MainWindowViewModel(IDiContainer container)
        {
            _container = container;
            _container.Register<DataManager>();
            _manager = _container.Resolve<DataManager>(parameters: new object[]{_container});
        }

        public IList<Note> GetNotes() => _manager.GetFromDatabase<Note>() as List<Note>;

        public IDictionary<Day, IList<CalendarEvent>> GetEvents()
        {
            //var today = new CalendarEvent("University", "Should doing labs", "Minsk", DateTime.Now, DateTime.Now);

            //var tommorow =  new CalendarEvent("Epam labs", "Will listen lecture", "Epam Training Center", DateTime.Today, DateTime.Now);

            //var result = new Dictionary<Day, IList<CalendarEvent>>
            //{
            //    { new Day(DateTime.Today), new List<CalendarEvent>{ today, tommorow} }
            //};

            //_manager.AddToDatabase(evItems: result);
            return _manager.GetFromDatabase<CalendarEvent>() as IDictionary<Day, IList<CalendarEvent>>;
        }

        public void Remove(object obj) => _manager.Remove(obj);

        public void UpdateDatabase<T>(IEnumerable<T> items)
        {
            if (typeof(T) == typeof(Note))
            {
                _manager.AddToDatabase(items as IEnumerable<Note>);
            }
            if (items is IDictionary<Day, IList<CalendarEvent>>)
            {
                _manager.AddToDatabase(evItems: items as IDictionary<Day, IList<CalendarEvent>>);
            }
        }
    }
}

