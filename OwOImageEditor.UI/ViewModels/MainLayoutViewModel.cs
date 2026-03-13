using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OwOImageEditor.UI.Interfaces;

namespace OwOImageEditor.UI.ViewModels;

public partial class MainLayoutViewModel : ViewModelBase
{
    public ObservableCollection<IModule> Modules { get; }

    [ObservableProperty]
    private IModule? _activeModule;

    public MainLayoutViewModel(IEnumerable<IModule> modules)
    {
        var sorted = modules.ToList();
        sorted.Sort(
            (IModule a, IModule b) =>
            {
                if (a.Order < b.Order)
                {
                    return -1;
                }
                if (a.Order > b.Order)
                {
                    return 1;
                }

                return 0;
            }
        );

        Modules = new ObservableCollection<IModule>(sorted);

        _activeModule = modules.Where(x => x.Name == "Setup").FirstOrDefault();
    }

    [RelayCommand]
    private void SelectModule(IModule module) => ActiveModule = module;
}
