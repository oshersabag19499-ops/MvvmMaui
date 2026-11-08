using Microsoft.Extensions.Logging;
using Mvvm.Services;
using Mvvm.ViewModels;
using Mvvm.Views;
namespace Mvvm
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.AddVMPages().AddPages().AddServices(); 
            return builder.Build();
        }

        public static MauiAppBuilder AddVMPages(this MauiAppBuilder builder)
        {
            // Register your services and view models here
            builder.Services.AddTransient<LoginPageVM>();
            builder.Services.AddTransient<AddUserMvvm>();
            builder.Services.AddTransient<UserListvm>();
            builder.Services.AddTransient<UserDatavm>();
            builder.Services.AddTransient<VMbase>();
            // Add other services as needed
            return builder;
        }
        public static MauiAppBuilder AddPages(this MauiAppBuilder builder)
        {
            // Register your views here
            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<Adduser>();
            builder.Services.AddTransient<UserList>();
            builder.Services.AddTransient<UserDataPage>();
            // Add other views as needed
            return builder;
        }
        public static MauiAppBuilder AddServices(this MauiAppBuilder builder)
        {
            // Register your services here
            builder.Services.AddSingleton<IDataService, DBdemo>();
            // Add other services as needed
            return builder;
        }
    }
}