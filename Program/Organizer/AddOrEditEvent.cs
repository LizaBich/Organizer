using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Organizer.Model;
using Day = Organizer.Model.Day;

namespace Organizer
{
    public partial class AddOrEditEvent : Form
    {
        public event EventHandler WindowClosed;
        public event EventHandler SaveButtonClicked;
        private CalendarEvent _event;

        public AddOrEditEvent(CalendarEvent calendarEvent = null)
        {
            InitializeComponent();

            buttonEventSave.Click += ButtonSave_Clicked;
            FormClosed += Window_Closed;
            buttonRepeateConfig.Click += ButtonConfig_Click;

            if (calendarEvent == null)
                Event = new CalendarEvent(String.Empty, String.Empty, String.Empty, DateTime.Today,
                    DateTime.Today);
            else Event = calendarEvent;
        }

        public IList<Day> NeadedDays { get; set; }
        public DateTime SelectedDate { get; set; }

        public CalendarEvent Event
        {
            get => _event;
            set
            {
                _event = value;
                eventName.Text = _event.Name;
                eventDescription.Text = _event.Content;
                eventPlace.Text = _event.Place;
                eventStart.Text = _event.StartTime.ToShortTimeString();
                eventEnd.Text = _event.EndTime.ToShortTimeString();
            } 
        }

        private void ButtonSave_Clicked(object sender, EventArgs args)
        {
            Event.Name = eventName.Text;
            Event.Content = eventDescription.Text;
            Event.Place = eventPlace.Text;
            Event.StartTime = Convert.ToDateTime(eventStart.Text);
            Event.EndTime = Convert.ToDateTime(eventEnd.Text);
            Close();
            SaveButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Window_Closed(object sender, EventArgs args) => WindowClosed?.Invoke(this, EventArgs.Empty);

        private void ButtonConfig_Click(object sender, EventArgs args)
        {
            var configWindow = new RepeateConfig
            {
                StartTime = SelectedDate,
                NeadedDays = NeadedDays
            };
            configWindow.ButtonSaveClick += RepeateConfigSaveButton_Click;
            configWindow.Show();
        }

        private void RepeateConfigSaveButton_Click(object sender, EventArgs args)
        {
            NeadedDays = (sender as RepeateConfig).NeadedDays;
        }
    }
}
