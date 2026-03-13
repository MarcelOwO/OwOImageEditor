using OwOImageEditor.UI.ViewModels;

namespace OwOImageEditor.UI.Interfaces;

public interface IModule
{
    public string Name { get; }

    public int Order { get; }

    public ViewModelBase ViewModel { get; }
}
