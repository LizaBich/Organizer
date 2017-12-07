using System;
using System.Windows.Forms;
using Organizer.Model;

namespace Organizer
{
    public partial class AddOrEditNote : Form
    {
        public event EventHandler SaveButtonClicked;
        private Note _note;

        public AddOrEditNote(Note note = null)
        {
            InitializeComponent();
            buttonSave.Click += ButtonSave_Clicked;
            if (note != null) Note = note;
            else Note = new Note(0, String.Empty, String.Empty, DateTime.Now);
        }

        public Note Note
        {
            get => _note;
            private set
            {
                _note = value;
                noteName.Text = _note.Name;
                noteDescription.Text = _note.Content;
                priorityBox.Text = Convert.ToString(_note.Priority);
            }
        }

        private void ButtonSave_Clicked(object sender, EventArgs args)
        {
            Note.Name = noteName.Text;
            Note.Content = noteDescription.Text;
            Note.Priority = !priorityBox.Text.Equals(string.Empty) ? Convert.ToSByte(priorityBox.Text) : Convert.ToSByte(10);
            Close();
            SaveButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
