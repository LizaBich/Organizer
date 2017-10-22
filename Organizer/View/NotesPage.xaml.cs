using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
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
using Organizer.Annotations;
using Organizer.Model;

namespace Organizer.View
{
    /// <summary>
    /// Логика взаимодействия для NotesPage.xaml
    /// </summary>
    public partial class NotesPage : UserControl
    {
        private Note _note;

        private ObservableCollection<Note> _notes;
        public ObservableCollection<Note> Notes
        {
            get => _notes;
            set => _notes = value;
        }

        public NotesPage()
        {
            InitializeComponent();

            Notes = new ObservableCollection<Note>
            {
                new Note("Встреча", "Встреча с Аней. Надо принести ...", DateTime.Now, Brushes.Bisque, 1),
                new Note("Продукты", "Купить яблоки ...", DateTime.Now, Brushes.AliceBlue, 1)
            };
            NotesList.ItemsSource = Notes;
        }

        private void Edit_OnClick(object sender, RoutedEventArgs e)
        {
            AddOrEditNote en = new AddOrEditNote(NName.Text, NoteDescription.Text, NoteDescription.Background);
            en.SaveOnClick += GetChange;
            en.Show();
        }

        private void GetChange(object sender, EventArgs e)
        {
            NName.Text = ((AddOrEditNote) sender).NName;
            NoteDescription.Text = ((AddOrEditNote) sender).NoteContent;
            NoteDescription.Background = ((AddOrEditNote) sender).Color;
            DateOfChange.Text = (DateTime.Now).ToString(CultureInfo.InvariantCulture);
            ((AddOrEditNote)sender).Close();
        }

        private void AddNew(object sender, EventArgs e)
        {
            Note nn = new Note(((AddOrEditNote)sender).NName, ((AddOrEditNote)sender).NoteContent, DateTime.Now, ((AddOrEditNote)sender).Color, ((AddOrEditNote)sender).Priority);
            Notes.Add(nn);
            ((AddOrEditNote)sender).Close();
        }

        private void AddNote_OnClick(object sender, RoutedEventArgs e)
        {
            if (Notes.Count == 49)
            {
                MessageBox.Show("Слишком много заметок! Удалите лишние.", "Предупреждение", MessageBoxButton.OK);
                return;
            }
            AddOrEditNote en = new AddOrEditNote();
            en.SaveOnClick += AddNew;
            en.Show();
        }

        private void DeleteNote_OnClick(object sender, RoutedEventArgs e)
        {
            Notes.Remove((Note) NotesList.SelectedItem);
        }

        private void SearchButton_OnClick(object sender, RoutedEventArgs e)
        {
            foreach (Note a in Notes)
            {
                if (a.Equals(SearchName.Text))
                {
                    NotesList.SelectedItem = a;
                }
            }
        }
    }
}
