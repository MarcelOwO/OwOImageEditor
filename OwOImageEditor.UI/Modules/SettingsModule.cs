using OwOImageEditor.UI.Interfaces;
using OwOImageEditor.UI.ViewModels;

namespace OwOImageEditor.UI.Modules;

public class SettingsModule : IModule
{
    public SettingsModule(SettingsViewModel viewModel)
    {
        ViewModel = viewModel;
    }

    public string Name => "Settings";

    public int Order => 5;

    public ViewModelBase ViewModel { get; }
}
