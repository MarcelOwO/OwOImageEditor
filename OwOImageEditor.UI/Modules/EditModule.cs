using OwOImageEditor.UI.Interfaces;
using OwOImageEditor.UI.ViewModels;

namespace OwOImageEditor.UI.Modules;

public class EditModule : IModule
{
    public string Name => "Edit";

    public int Order => 2;

    public ViewModelBase ViewModel { get; }

    public EditModule(EditViewModel viewModel)
    {
        ViewModel = viewModel;
    }
}
