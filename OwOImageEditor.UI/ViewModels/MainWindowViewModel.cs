using CommunityToolkit.Mvvm.ComponentModel;

namespace OwOImageEditor.UI.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private ViewModelBase _currentContent;

    public MainWindowViewModel(MainLayoutViewModel mainLayout)
    {
        _currentContent = mainLayout;
    }
}
