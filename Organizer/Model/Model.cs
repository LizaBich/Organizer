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
        private string _eventName;
        private string _place;
        private DateTime _start;
        private DateTime _end;
        private string _repeate;
        private string _description;
        private Brush _color;

        public CalendarEvent(string eName, string place, DateTime st, DateTime en, string desc, Brush color)
        {
            EventName = eName;
            Place = place;
            StartTime = st;
            EndTime = en;
            Description = desc;
            Color = color;
        }

        public int Id { get; set; }

        public Brush Color
        {
            get => _color;
            set
            {
                _color = value;
                OnPropertyChanged("Color");
            }
        }

        public string EventName
        {
            get => _eventName;
            set
            {
                _eventName = value;
                OnPropertyChanged("EventName");
            }
        }

        public string Place
        {
            get => _place;
            set
            {
                _place = value;
                OnPropertyChanged("Place");
            }
        }

        public DateTime StartTime
        {
            get => _start;
            set
            {
                _start = value;
                OnPropertyChanged("StartTime");
            }
        }

        public DateTime EndTime
        {
            get => _end;
            set
            {
                _end = value;
                OnPropertyChanged("EndTime");
            }
        }

        public string Repeate
        {
            get => _repeate;
            set
            {
                _repeate = value;
                OnPropertyChanged("Repeate");
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }

        public string FullDescription => ToString();

        public override string ToString() =>"Место проведения: " + Place +
                   "\nВремя начала: " + StartTime.ToLongTimeString() +
                   "\nВремя окончания: " + EndTime.ToLongTimeString() +
                   "\nПовтор: " + Repeate +
                   "\nОписание:\n" + Description;

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
