using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Day = Organizer.Model.Day;

namespace Organizer
{
    public partial class RepeateConfig : Form
    {
        private readonly string[] _commands = { "Единожды", "Ежедневно", "Еженедельно", "Ежемесячно", "Ежегодно" };
        private DateTime _startTime;
        public event EventHandler ButtonSaveClick;

        public RepeateConfig()
        {
            InitializeComponent();
            NeadedDays = new List<Day>();
            TabCommands.DataSource = _commands;
            TabCommands.Text = _commands[0];
            Days.Enabled = Weeks.Enabled = Monthes.Enabled = false;

            TabCommands.TextChanged += TabCommands_TextChanged;
            Save.Click += SaveButton_Click;
        }

        public IList<Day> NeadedDays { get; set; }

        public DateTime StartTime
        {
            get => _startTime;
            set
            {
                _startTime = value;
                var day = _startTime.DayOfWeek;
                switch (day)
                {
                    case DayOfWeek.Monday: Mondey.Checked = true; break;
                    case DayOfWeek.Tuesday:
                        Tuesday.Checked = true;
                        break;
                    case DayOfWeek.Wednesday:
                        Wednesday.Checked = true;
                        break;
                    case DayOfWeek.Thursday:
                        Thursday.Checked = true;
                        break;
                    case DayOfWeek.Friday:
                        Friday.Checked = true;
                        break;
                    case DayOfWeek.Saturday:
                        Saturday.Checked = true;
                        break;
                    case DayOfWeek.Sunday:
                        Sunday.Checked = true;
                        break;
                }
            }
        }

        private void TabCommands_TextChanged(object sender, EventArgs args)
        {
            if (TabCommands.Text.Equals(_commands[0]) || TabCommands.Text.Equals(_commands[1]))
            {
                Days.Enabled = Weeks.Enabled = Monthes.Enabled = false;
            }
            else if (TabCommands.Text.Equals(_commands[2]))
            {
                Days.Enabled = true;
                Weeks.Enabled = Monthes.Enabled = false;
            }
            else if (TabCommands.Text.Equals(_commands[3]))
            {
                Days.Enabled = Weeks.Enabled = true;
                Monthes.Enabled = false;
            }
            else if (TabCommands.Text.Equals(_commands[4]))
            {
                Days.Enabled = Weeks.Enabled = Monthes.Enabled = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs args)
        {
            // единожды
            if (TabCommands.Text.Equals(_commands[0]))
            {
                var newDay = new Day { Date = StartTime.Date };
                NeadedDays.Add(newDay);
            }
            // ежедневно
            if (TabCommands.Text.Equals(_commands[1]))
            {
                for (var i = 0; i <= 364; ++i)
                {
                    var newDay = new Day { Date = StartTime.AddDays(i).Date };
                    NeadedDays.Add(newDay);
                }
            }
            // еженедельно
            if (TabCommands.Text.Equals(_commands[2]))
            {
                for (var i = 0; i <= 364; ++i)
                {
                    var newDay = new Day { Date = StartTime.AddDays(i).Date };
                    if (OneOfDay(newDay.Date.DayOfWeek)) NeadedDays.Add(newDay);
                }
            }
            // ежемесячно
            if (TabCommands.Text.Equals(_commands[3]))
            {
                for (var i = 0; i <= 364; ++i)
                {
                    var newDay = new Day { Date = StartTime.AddDays(i).Date };
                    if (OneOfDay(newDay.Date.DayOfWeek) && OneOfWeek(newDay.Date.Month)) NeadedDays.Add(newDay);
                }
            }
            // ежегодно
            if (TabCommands.Text.Equals(_commands[4]))
            {
                for (var i = 0; i <= 364; ++i)
                {
                    var newDay = new Day { Date = StartTime.AddDays(i).Date };
                    if (OneOfDay(newDay.Date.DayOfWeek) && OneOfWeek(newDay.Date.Day) && OneOfMonth(newDay.Date.Month)) NeadedDays.Add(newDay);
                }
            }
            Close();
            ButtonSaveClick?.Invoke(this, EventArgs.Empty);
        }

        private bool OneOfDay(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday: return Mondey.Checked;
                case DayOfWeek.Tuesday: return Tuesday.Checked;
                case DayOfWeek.Wednesday: return Wednesday.Checked;
                case DayOfWeek.Thursday: return Thursday.Checked;
                case DayOfWeek.Friday: return Friday.Checked;
                case DayOfWeek.Saturday: return Saturday.Checked;
                case DayOfWeek.Sunday: return Sunday.Checked;
                default: return false;
            }
        }

        private bool OneOfWeek(int day)
        {
            var week = day / 7;
            switch (week)
            {
                case 0: return FirstWeek.Checked;
                case 1: return SecondWeek.Checked;
                case 2: return ThirdWeek.Checked;
                case 3: return ForthWeek.Checked;
                case 4: return FirstWeek.Checked;
                default: return false;
            }
        }

        private bool OneOfMonth(int month)
        {
            switch (month)
            {
                case 1: return January.Checked;
                case 2: return February.Checked;
                case 3: return March.Checked;
                case 4: return April.Checked;
                case 5: return May.Checked;
                case 6: return June.Checked;
                case 7: return July.Checked;
                case 8: return August.Checked;
                case 9: return September.Checked;
                case 10: return October.Checked;
                case 11: return November.Checked;
                case 12: return December.Checked;
                default: return false;
            }
        }
    }
}
