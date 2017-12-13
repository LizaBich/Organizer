using System;
using System.Drawing;
using System.Windows.Forms;
using Organizer.Model;

namespace Organizer
{
    public partial class AddOrEditNote : Form
    {
        public event EventHandler WindowClosed;
        public event EventHandler SaveButtonClicked;
        private Note _note;
        private readonly string[] _priorities = { "1", "2", "3" };

        public AddOrEditNote(Note note = null)
        {
            InitializeComponent();
            priorityBox.DataSource = _priorities;
            buttonSave.Click += ButtonSave_Clicked;
            buttonChangeColor.Click += ButtonColorChange_Clicked;
            Closed += Window_Closed;
            Note = note ?? new Note(0, String.Empty, String.Empty, DateTime.Now, Color.White);
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
            Note.Priority = !priorityBox.Text.Equals(string.Empty) ? Convert.ToByte(priorityBox.Text) : Convert.ToByte(10);
            Close();
            SaveButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Window_Closed(object sender, EventArgs args) => WindowClosed?.Invoke(this, EventArgs.Empty);

        private void ButtonColorChange_Clicked(object sender, EventArgs args)
        {
            var result = colorDialog1.ShowDialog(this);
            if (result != DialogResult.OK) return;
            noteDescription.BackColor = colorDialog1.Color;
            Note.Color = colorDialog1.Color;
        }
    }
}
