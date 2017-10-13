using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.ViewModel
{
    class MainWindowViewModel
    {
        public IMainWindowsCodeBehind CodeBehind { get; set; }

        #region ForEvent

        private RelayCommand _LoadEventPage;
        public RelayCommand LoadEventPage
        {
            get
            {
                return _LoadEventPage = _LoadEventPage ??
                                        new RelayCommand(OnLoadEventPage, CanLoadEventPage);
            }
        }

        private bool CanLoadEventPage() => true;

        private void OnLoadEventPage() => CodeBehind.LoadView(ViewType.EventPage);

        #endregion


        #region ForNote

        private RelayCommand _LoadNotePage;

        public RelayCommand LoadNotePage
        {
            get
            {
                return _LoadNotePage = _LoadNotePage ??
                                       new RelayCommand(OnLoadNotePage, CanLoadNotePage);
            }
        }

        private bool CanLoadNotePage() => true;

        private void OnLoadNotePage() => CodeBehind.LoadView(ViewType.NotePage);

        #endregion

    }
}
