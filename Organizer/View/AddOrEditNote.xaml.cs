using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;
using Organizer.Annotations;

namespace Organizer.View
{
    struct ColorItem
    {
        public Brush Color;

        public ColorItem(Brush color)
        {
            Color = color;
        }
    }

    /// <summary>
    /// Логика взаимодействия для AddOrEditNote.xaml
    /// </summary>
    public partial class AddOrEditNote : Window
    {
        private readonly List<int> PriorityList = new List<int> {1, 2, 3};

        public EventHandler SaveOnClick;

        public string NName { get; private set; }

        public string NoteContent { get; private set; }

        public Brush Color { get; private set; }

        public int Priority { get; private set; }

        public DateTime Time { get; private set; }

        public AddOrEditNote(string name = "Название", string content = "Описание", Brush color = null, int priority = 3)
        {
            InitializeComponent();

            NoteName.Text = name;
            NoteName.Background = color;
            NoteName.BorderBrush = color;
            NoteDefinition.Text = content;
            NoteDefinition.Background = color;
            NoteDefinition.BorderBrush = color;
            NotePriority.Text = 3.ToString();

            NotePriority.ItemsSource = PriorityList;
        }

        private void Save_OnClick(object sender, RoutedEventArgs e)
        {
            NName = NoteName.Text;
            NoteContent = NoteDefinition.Text;
            Time = DateTime.Now;
            Priority = Convert.ToInt32(NotePriority.Text);
            SaveOnClick?.Invoke(this, EventArgs.Empty);
        }

        private void BisqueColor_OnClick(object sender, RoutedEventArgs e)
        {
            Color = (sender as Button)?.Background;
            NoteName.Background = (sender as Button)?.Background;
            NoteDefinition.Background = (sender as Button)?.Background;
        }

        private void BurlyWoodColor_OnClick(object sender, RoutedEventArgs e)
        {
            Color = (sender as Button)?.Background;
            NoteName.Background = (sender as Button)?.Background;
            NoteDefinition.Background = (sender as Button)?.Background;
        }

        private void GoldColor_OnClick(object sender, RoutedEventArgs e)
        {
            Color = (sender as Button)?.Background;
            NoteName.Background = (sender as Button)?.Background;
            NoteDefinition.Background = (sender as Button)?.Background;
        }

        private void VioletColor_OnClick(object sender, RoutedEventArgs e)
        {
            Color = (sender as Button)?.Background;
            NoteName.Background = (sender as Button)?.Background;
            NoteDefinition.Background = (sender as Button)?.Background;
        }

        private void TomatoColor_OnClick(object sender, RoutedEventArgs e)
        {
            Color = (sender as Button)?.Background;
            NoteName.Background = (sender as Button)?.Background;
            NoteDefinition.Background = (sender as Button)?.Background;
        }

        private void StellBlueColor_OnClick(object sender, RoutedEventArgs e)
        {
            Color = (sender as Button)?.Background;
            NoteName.Background = (sender as Button)?.Background;
            NoteDefinition.Background = (sender as Button)?.Background;
        }

        private void UIElement_OnPreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer viewer = sender as ScrollViewer;
            if (e.Delta > 0)
                viewer?.LineLeft();
            else 
                viewer?.LineRight();
            e.Handled = true;
        }
    }
}
