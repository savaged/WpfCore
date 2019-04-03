using GalaSoft.MvvmLight;

namespace WpfCore.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _greeting;

        public MainWindowViewModel()
        {
            _greeting = "Hello .NET Core from VM!";
        }

        public string Greeting
        {
            get => _greeting;
            set => Set(ref _greeting, value);
        }
    }
}