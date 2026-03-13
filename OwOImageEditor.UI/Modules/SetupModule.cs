using OwOImageEditor.UI.Interfaces;
using OwOImageEditor.UI.ViewModels;

namespace OwOImageEditor.UI.Modules;

public class SetupModule : IModule
{
    public SetupModule(SetupViewModel viewModel)
    {
        ViewModel = viewModel;
    }

    public string Name => "Setup";

    public int Order => 0;

    public ViewModelBase ViewModel { get; }
}
