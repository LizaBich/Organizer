using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Organizer.Model;

namespace Organizer.View
{
    /// <summary>
    /// Логика взаимодействия для CalendarEventsPage.xaml
    /// </summary>
    public partial class CalendarEventsPage : UserControl
    {
        private CalendarEvent _event;

        private ObservableCollection<CalendarEvent> _events;

        public ObservableCollection<CalendarEvent> Events
        {
            get => _events;
            set => _events = value;
        }

        public CalendarEventsPage()
        {
            InitializeComponent();

            Events = new ObservableCollection<CalendarEvent>
            {
                new CalendarEvent("Сходить на англ", "Minsk", DateTime.Now, DateTime.Now, "Надо сходить на занятие по английскому. Сделать домашку!", Brushes.BlanchedAlmond),
                new CalendarEvent("Тренажёрка", "Minsk", DateTime.Today, DateTime.Today, "Надо сделать упражнения для рук и пресса", Brushes.AntiqueWhite)
            };

            EventsList.ItemsSource = Events;
        }
    }
}
