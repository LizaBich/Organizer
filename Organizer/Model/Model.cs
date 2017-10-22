using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Organizer.Annotations;

namespace Organizer.Model
{
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

        public override string ToString()
        {
            return "Название мероприятия: " + EventName +
                   "\n\rМесто проведения: " + Place +
                   "\n\rВремя начала: " + StartTime.ToLongTimeString() +
                   "\n\nВремя окончания: " + EndTime.ToLongTimeString() +
                   "\n\rПовтор: " + Repeate +
                   "\n\rОписание:\n\r" + Description;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }

    public class Note : INotifyPropertyChanged, IEquatable<Note>
    {
        private Brush _color;
        private string _name;
        private string _content;
        private DateTime _timeOfChange;
        private int _priority;

        #region Properties

        public int Id { get; set; }

        public int Priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged("Priority");
            }
        }

        public string NoteName
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged("Content");
            }
        }

        public DateTime TimeOfChange
        {
            get => _timeOfChange;
            set
            {
                _timeOfChange = value;
                OnPropertyChanged("TimeOfChange");
            }
        }

        public string StringTimeOfChange => TimeOfChange.ToString("F");

        public Brush Color
        {
            get => _color;
            set
            {
                _color = value;
                OnPropertyChanged("Color");
            }
        }

        #endregion

        public Note(string nName, string content, DateTime date, Brush color, int priority)
        {
            NoteName = nName;
            Content = content;
            TimeOfChange = date;
            Color = color;
            Priority = priority;
        }

        public override string ToString() => NoteName + "\n" + Content;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }


        public Brush PriorityColor
        {
            get
            {
                switch (_priority)
                {
                    case 1: return Brushes.Red;
                    case 2: return Brushes.Yellow;
                    case 3: return Brushes.LimeGreen;
                    default: return Brushes.White;
                }
            }
        }


        public bool Equals(Note other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(_name, other._name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Note)obj);
        }

        public bool Equals(string obj)
        {
            return NoteName.Contains(obj);
        }

        public override int GetHashCode() => NoteName != null ? NoteName.GetHashCode() : 0;
    }
}
