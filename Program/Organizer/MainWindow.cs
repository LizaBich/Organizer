using Organizer.ViewModel;
using System.Windows.Forms;

namespace Organizer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            noteDescription.Enabled = false;
            _mainWindowViewModel = new MainWindowViewModel(_container);
            Load += WindowLoaded;

            notesList.Click += NoteListItemSelected;
            buttonNoteEdit.Click += CallEditeNoteWindow;
            buttonNoteDelete.Click += DeleteNoteButtonClicked;
            buttonNoteAdd.Click += CallCreateNoteWindow;
            buttonSearch.Click += SearchNoteButtonClicked;
            nameForSearch.TextChanged += SearchNoteTextChanged;

            monthCalendar.DateSelected += UpdateListOfEvents;
            eventsList.Click += EventListItemSelected;
            buttonEventEdit.Click += ButtonEventEdit_Clicked;
            buttonEventDelete.Click += DeleteEventButton_Clicked;
        }
    }
}
