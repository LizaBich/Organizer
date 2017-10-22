using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        
    }
}
