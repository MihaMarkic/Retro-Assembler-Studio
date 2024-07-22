﻿using C64AssemblerStudio.Engine.Services.Abstract;
using C64AssemblerStudio.Engine.Services.Implementation;
using C64AssemblerStudio.Engine.ViewModels;
using C64AssemblerStudio.Engine.ViewModels.Dialogs;
using C64AssemblerStudio.Engine.ViewModels.Files;
using C64AssemblerStudio.Engine.ViewModels.Tools;
using Microsoft.Extensions.DependencyInjection;
using Righthand.MessageBus;
using Righthand.RetroDbgDataProvider;
using Righthand.RetroDbgDataProvider.Models;

namespace C64AssemblerStudio.Engine;

public static class IoCRegistrar
{
    public static IServiceCollection AddEngine(this IServiceCollection services, bool messagesHistoryEnabled)
    {
        return services
            .AddSingleton<Globals>()
            .AddSingleton<ISettingsManager, SettingsManager>()
            // ViewModels
            .AddSingleton<MainViewModel>()
            .AddScoped<StartPageViewModel>()
            .AddScoped<ProjectFilesWatcherViewModel>()
            .AddScoped<ProjectExplorerViewModel>()
            .AddScoped<SettingsViewModel>()
            .AddScoped<FilesViewModel>()
            .AddTransient<AssemblerFileViewModel>()
            // Tools
            .AddScoped<ErrorMessagesViewModel>()
            .AddScoped<BuildOutputViewModel>()
            .AddScoped<CompilerErrorsOutputViewModel>()
            // Dialogs
            .AddTransient<AddFileDialogViewModel>()
            .AddTransient<AddDirectoryDialogViewModel>()
            .AddTransient<RenameItemDialogViewModel>()
            .AddTransient<KickAssProjectViewModel>()
            .AddSingleton<EmptyProjectViewModel>()
            // System
            .AddTransient(sp => sp.CreateScope())
            .AddSingleton<IDispatcher>(
            // uses dispatching from within same thread to all subscriptions by default as most subscribers are running on UI thread
                new Dispatcher(new DispatchContext(DispatchThreading.SameThread)))
            .AddDebugDataProvider();
    }
}