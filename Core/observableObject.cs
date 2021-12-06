using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Paneltest_WPF.Core
{
    internal class observableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}