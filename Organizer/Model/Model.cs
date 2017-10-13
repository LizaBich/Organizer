using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    public class Account
    {

        public Account()
        {
            Events = new ObservableCollection<CalendarEvent>();
            Notes = new ObservableCollection<Note>();
        }

        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public ObservableCollection<CalendarEvent> Events { get; set; }
        public ObservableCollection<Note> Notes { get; set; }
    }

    public class CalendarEvent : INotifyPropertyChanged
    {
        private string eventName;
        private string place;
        private DateTime start;
        private DateTime end;
        private string repeate;
        private string description;

        public CalendarEvent(string eName, string place, DateTime st, DateTime en, string desc)
        {
            EventName = eName;
            Place = place;
            StartTime = st;
            EndTime = en;
            Description = desc;
        }

        public int Id { get; set; }

        public string EventName
        {
            get => eventName;
            set
            {
                eventName = value;
                OnPropertyChanged("EventName");
            }
        }

        public string Place
        {
            get => place;
            set
            {
                place = value;
                OnPropertyChanged("Place");
            }
        }

        public DateTime StartTime
        {
            get => start;
            set
            {
                start = value;
                OnPropertyChanged("StartTime");
            }
        }

        public DateTime EndTime
        {
            get => end;
            set
            {
                end = value;
                OnPropertyChanged("EndTime");
            }
        }

        public string Repeate
        {
            get => repeate;
            set
            {
                repeate = value;
                OnPropertyChanged("Repeate");
            }
        }

        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }

    public class Note : INotifyPropertyChanged
    {
        private string name;
        private string content;
        private DateTime timeOfChange;
        private ObservableCollection<object> files;

        
        public Note(string nName, string content, DateTime date)
        {
            Name = nName;
            Content = content;
            TimeOfChange = date;
        }

        public int Id { get; set; }
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Content
        {
            get => content;
            set
            {
                content = value;
                OnPropertyChanged("Content");
            }
        }

        public DateTime TimeOfChange
        {
            get => timeOfChange;
            set
            {
                timeOfChange = value;
                OnPropertyChanged("TimeOfChange");
            }
        }

        public ObservableCollection<object> Files
        {
            get => files;
            set
            {
                files = value;
                OnPropertyChanged("Files");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
