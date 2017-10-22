using Organizer.ViewModel;
using Organizer.View;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Organizer
{
    public enum ViewType
    {
        NotePage,
        EventPage
    }

    public enum WindowType
    {
        NoteWindow,
        EventWindow
    }

    public interface IMainWindowsCodeBehind
    {
        void LoadView(ViewType typeView);
        //void OpenWindow(WindowType winType);
    }

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindowsCodeBehind
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel vm = new MainWindowViewModel
            {
                CodeBehind = this
            };
            DataContext = vm;
            LoadView(ViewType.EventPage);
        }

        public void LoadView(ViewType typeView)
        {
            switch (typeView)
            {
                case ViewType.EventPage:
                    CalendarEventsPage ePage = new CalendarEventsPage();
                    EventPageViewModel vm = new EventPageViewModel(this);
                    ePage.DataContext = vm;
                    OutputView.Content = ePage;
                    break;
                case ViewType.NotePage:
                    NotesPage nPage = new NotesPage();
                    NotePageViewModel nvm = new NotePageViewModel(this);
                    nPage.DataContext = nvm;
                    //_notepage = nPage;
                    OutputView.Content = nPage;
                    break;
            }
        }
    }
}
