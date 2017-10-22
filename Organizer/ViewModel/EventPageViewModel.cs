using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.ViewModel
{
    class EventPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private readonly IMainWindowsCodeBehind _MainCodeBehinder;

        public EventPageViewModel(IMainWindowsCodeBehind codeBehinder)
        {
            _MainCodeBehinder = codeBehinder ?? throw new ArgumentNullException(nameof(codeBehinder));
        }

        //private RelayCommand _OpenAddOrEditEventPage;

        //public RelayCommand OpenAddOrEditEventPage
        //{
        //    get
        //    {
        //        return _OpenAddOrEditEventPage = _OpenAddOrEditEventPage ??
        //                                    new RelayCommand(OnOpenAddOrEditEventPage, CanOpenAddOrEditEventPage);
        //    }
        //}

        //private bool CanOpenAddOrEditEventPage() => true;

        //private void OnOpenAddOrEditEventPage() => _MainCodeBehinder.OpenWindow(WindowType.EventWindow);
    }
}
