using Microsoft.Extensions.DependencyInjection;
using OwOImageEditor.UI.Interfaces;
using OwOImageEditor.UI.Modules;
using OwOImageEditor.UI.ViewModels;

namespace OwOImageEditor.UI.Extensions;

public static class ServiceExtensions
{
    public static ServiceCollection SetupServices(this ServiceCollection services)
    {
        services.AddSingleton<IModule, SettingsModule>();
        services.AddSingleton<IModule, EditModule>();
        services.AddSingleton<IModule, SetupModule>();

        services.AddTransient<MainWindowViewModel>();
        services.AddTransient<MainLayoutViewModel>();
        services.AddTransient<SettingsViewModel>();
        services.AddTransient<SetupViewModel>();
        services.AddTransient<EditViewModel>();

        return services;
    }
}
