using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.ViewModel
{
    class NotePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate {};

        private readonly IMainWindowsCodeBehind _MainCodeBehinder;

        public NotePageViewModel(IMainWindowsCodeBehind codeBehind)
        {
            _MainCodeBehinder = codeBehind ?? throw new ArgumentNullException(nameof(codeBehind));
        }

        private RelayCommand _OpenAddOrEditPage;

        public RelayCommand OpenAddOrEditPage
        {
            get
            {
                return _OpenAddOrEditPage = _OpenAddOrEditPage ??
                                            new RelayCommand(OnOpenAddOrEditPage, CanOpenAddOrEditPage);
            }
            
        }

        private bool CanOpenAddOrEditPage() => true;

        private void OnOpenAddOrEditPage() => _MainCodeBehinder.OpenWindow(WindowType.NoteWindow);
    }
}
