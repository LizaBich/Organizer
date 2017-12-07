using System.Collections.Generic;
using System.Windows.Forms;
using Organizer.Model;
using Organizer.ViewModel;
using System;
using System.Linq;
using System.Text;

namespace Organizer
{
    public partial class MainWindow : Form
    {
        private readonly MainWindowViewModel _mainWindowViewModel;
        private IList<Note> _tempList;
        private IList<CalendarEvent> _currentEvents;
        private int _eventIndex;
        private DateTime _selectedDate;
        private int _noteIndex;
        private bool _isCreatedNew;
        private bool _isSearching;

        public MainWindow()
        {
            InitializeComponent();
            noteDescription.Enabled = false;
            _mainWindowViewModel = new MainWindowViewModel();
            Load += WindowLoaded;
            Closed += WindowUnloaded;

            notesList.Click += NoteListItemSelected;
            buttonNoteEdit.Click += CallEditeNoteWindow;
            buttonNoteDelete.Click += DeleteNoteButtonClicked;
            buttonNoteAdd.Click += CallCreateNoteWindow;
            buttonSearch.Click += SearchNoteButtonClicked;
            nameForSearch.TextChanged += SearchNoteTextChanged;

            monthCalendar.DateSelected += UpdateListOfEvents;
            eventsList.ItemSelectionChanged += EventListItemSelected;
            buttonEventEdit.Click += ButtonEventEdit_Clicked;
            buttonEventDelete.Click += DeleteEventButton_Clicked;
        }

        public IList<Note> NotesList { get; private set; }
        public IDictionary<DateTime, IList<CalendarEvent>> EventsList { get; private set; }


        private void WindowLoaded(object sender, EventArgs args)
        {
            NotesList = _mainWindowViewModel.GetNotes();
            UpdateNoteListBox();
            EventsList = _mainWindowViewModel.GetEvents();
        }

        private void WindowUnloaded(object sender, EventArgs args)
        {

        }

        private void UpdateNoteListBox()
        {
            notesList.Clear();
            if (_isSearching)
            {
                foreach (var note in _tempList)
                {
                    notesList.Items.Add(note.Name);
                }
            }
            else
            {
                foreach (var note in NotesList)
                {
                    notesList.Items.Add(note.Name);
                }
            }

        }


        private void NoteListItemSelected(object sender, EventArgs args)
        {
            _noteIndex = notesList.SelectedItems[0].Index;
            var description = new StringBuilder();
            description.AppendLine(_isSearching ? _tempList[_noteIndex].Content : NotesList[_noteIndex].Content);
            noteDescription.Text = description.ToString();
            labelNoteChange.Text = NotesList[_noteIndex].TimeOfChange.ToShortDateString();
            labelPriority.Text = Convert.ToString(NotesList[_noteIndex].Priority);
        }

        private void CallEditeNoteWindow(object sender, EventArgs args)
        {
            var createWindow = new AddOrEditNote(NotesList[_noteIndex]);
            _isCreatedNew = false;
            createWindow.SaveButtonClicked += SaveNoteChanges;
            createWindow.Show();
        }

        private void CallCreateNoteWindow(object sender, EventArgs args)
        {
            var createWindow = new AddOrEditNote();
            _isCreatedNew = true;
            createWindow.SaveButtonClicked += SaveNoteChanges;
            createWindow.Show();
        }

        private void SaveNoteChanges(object sender, EventArgs args)
        {
            if (!(sender is AddOrEditNote))
                throw new ArgumentException(
                    $"Can't cast object of type {sender.GetType()} to the AddOrEditNote type!");
            if (_isCreatedNew)
            {
                var note = ((AddOrEditNote)sender).Note;
                NotesList.Add(note);
                NotesList = NotesList.OrderBy(n => n.Priority).ToList();
                UpdateNoteListBox();
            }
            else
            {

                NotesList[_noteIndex].Name = ((AddOrEditNote)sender).Note.Name;
                NotesList[_noteIndex].Content = ((AddOrEditNote)sender).Note.Content;
                NotesList[_noteIndex].TimeOfChange = DateTime.Now;
                if (((AddOrEditNote)sender).Note.Priority != 10)
                    NotesList[_noteIndex].Priority = ((AddOrEditNote)sender).Note.Priority;
                NotesList = NotesList.OrderBy(n => n.Priority).ToList();
                UpdateNoteListBox();
                var description = new StringBuilder();
                description.AppendLine(NotesList[_noteIndex].Content);
                labelNoteChange.Text = NotesList[_noteIndex].TimeOfChange.ToShortDateString();
                labelPriority.Text = Convert.ToString(NotesList[_noteIndex].Priority);
                noteDescription.Text = description.ToString();
            }
        }


        private void DeleteNoteButtonClicked(object sender, EventArgs args)
        {
            NotesList.RemoveAt(_noteIndex);
            if (NotesList.Count == 0)
            {
                noteDescription.Text = labelNoteChange.Text = labelPriority.Text = string.Empty;
                return;
            }
            int index;
            if (_noteIndex >= 0 && _noteIndex < NotesList.Count)
            {
                index = _eventIndex;
            }
            else
            {
                index = _eventIndex - 1;
            }
            var description = new StringBuilder();
            description.AppendLine(NotesList[index].Content);
            labelNoteChange.Text = NotesList[_noteIndex].TimeOfChange.ToShortDateString();
            labelPriority.Text = Convert.ToString(NotesList[_noteIndex].Priority);
            noteDescription.Text = description.ToString();
            UpdateNoteListBox();
        }

        private void SearchNoteButtonClicked(object sender, EventArgs args)
        {
            if (nameForSearch.Text.Equals(String.Empty))
            {
                MessageBox.Show("Имя заметки для поиска не указано! Укажите имя.", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                _tempList = NotesList.Where(note => note.Name.Contains(nameForSearch.Text)).ToList();
                if (_tempList == null)
                {
                    MessageBox.Show("Заметка с таким именем не найдена.", "Warning", MessageBoxButtons.OK);
                    return;
                }
                _isSearching = true;
                UpdateNoteListBox();
            }
        }

        private void SearchNoteTextChanged(object sender, EventArgs args)
        {
            if (!nameForSearch.Text.Equals(String.Empty)) return;
            _isSearching = false;
            UpdateNoteListBox();
        }

        private void UpdateListOfEvents(object sender, EventArgs args)
        {
            _selectedDate = monthCalendar.SelectionStart.Date;
            try
            {
                _currentEvents = EventsList[_selectedDate];
            }
            catch (KeyNotFoundException)
            {
                _currentEvents = new List<CalendarEvent>();
                EventsList.Add(_selectedDate, _currentEvents);
            }
            eventsList.Clear();
            foreach (var ev in _currentEvents)
            {
                eventsList.Items.Add(ev.Name);
            }
        }

        private void SimpleUpdate()
        {
            eventsList.Clear();
            foreach (var ev in _currentEvents)
            {
                eventsList.Items.Add(ev.Name);
            }
        }

        private void EventListItemSelected(object sender, EventArgs args)
        {
            if (eventsList.SelectedItems.Count <= 0) return;
            _eventIndex = eventsList.SelectedItems[0].Index;
            var description = new StringBuilder();
            description.AppendLine($"Место проведения: {_currentEvents[_eventIndex].Place}");
            description.AppendLine($"Время начала: {_currentEvents[_eventIndex].StartTime.ToShortTimeString()}");
            description.AppendLine($"Время окончания: {_currentEvents[_eventIndex].EndTime.ToShortTimeString()}");
            description.AppendLine("Описание: ");
            description.AppendLine(_currentEvents[_eventIndex].Content);
            eventDescription.Text = description.ToString();
        }

        private void ButtonEventAdd_Click(object sender, EventArgs e)
        {
            var createWindow = new AddOrEditEvent();
            _isCreatedNew = true;
            createWindow.SaveButtonClicked += SaveEventChanges;
            createWindow.WindowClosed += Window_Closed;
            Enabled = false;
            createWindow.Show();
        }

        private void ButtonEventEdit_Clicked(object sender, EventArgs e)
        {
            var createWindow = new AddOrEditEvent(_currentEvents[_eventIndex]);
            _isCreatedNew = false;
            createWindow.SaveButtonClicked += SaveEventChanges;
            createWindow.WindowClosed += Window_Closed;
            Enabled = false;
            createWindow.Show();
        }

        private void SaveEventChanges(object sender, EventArgs args)
        {
            Enabled = true;
            if (!(sender is AddOrEditEvent))
                throw new ArgumentException(
                    $"Can't cast object of type {sender.GetType()} to the AddOrEditEvent type!");
            if (_isCreatedNew)
            {
                var nEvent = ((AddOrEditEvent)sender).Event;
                //_currentEvents.Add(nEvent);
                EventsList[_selectedDate].Add(nEvent);
                SimpleUpdate();
            }
            else
            {
                _currentEvents[_eventIndex].Name = ((AddOrEditEvent)sender).Event.Name;
                _currentEvents[_eventIndex].Content = ((AddOrEditEvent)sender).Event.Content;
                _currentEvents[_eventIndex].StartTime = ((AddOrEditEvent)sender).Event.StartTime;
                _currentEvents[_eventIndex].EndTime = ((AddOrEditEvent)sender).Event.EndTime;

                SimpleUpdate();
                var description = new StringBuilder();
                description.AppendLine($"Место проведения: {_currentEvents[_eventIndex].Place}");
                description.AppendLine($"Время начала: {_currentEvents[_eventIndex].StartTime.ToShortTimeString()}");
                description.AppendLine($"Время окончания: {_currentEvents[_eventIndex].EndTime.ToShortTimeString()}");
                description.AppendLine("Описание: ");
                description.AppendLine(_currentEvents[_eventIndex].Content);
                noteDescription.Text = description.ToString();
            }
        }

        private void DeleteEventButton_Clicked(object sender, EventArgs args)
        {
            EventsList[_selectedDate].RemoveAt(_eventIndex);
            if (EventsList[_selectedDate].Count == 0)
            {
                eventDescription.Text = String.Empty;
                SimpleUpdate();
                return;
            }
            int index;
            if (_eventIndex >= 0 && _eventIndex < EventsList[_selectedDate].Count)
            {
                index = _eventIndex;
            }
            else
            {
                index = _eventIndex - 1;
            }
            var description = new StringBuilder();
            description.AppendLine($"Место проведения: {EventsList[_selectedDate][index].Place}");
            description.AppendLine($"Время начала: {EventsList[_selectedDate][index].StartTime.ToShortTimeString()}");
            description.AppendLine($"Время окончания: {EventsList[_selectedDate][index].EndTime.ToShortTimeString()}");
            description.AppendLine("Описание: ");
            description.AppendLine(EventsList[_selectedDate][index].Content);
            noteDescription.Text = description.ToString();
            SimpleUpdate();
        }

        private void Window_Closed(object sender, EventArgs args) => Enabled = true;
    }
}
