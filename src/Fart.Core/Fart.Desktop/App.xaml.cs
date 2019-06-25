using System;
using System.ComponentModel;
using System.Windows;

namespace Fart.Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static MainWindow app;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // For catching Global uncaught exception
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(UnhandledExceptionOccured);

            LogMachineDetails();
            app = new MainWindow();
            var context = new MainViewModel();
            app.DataContext = context;
            app.Show();
        }

        static void UnhandledExceptionOccured(object sender, UnhandledExceptionEventArgs args)
        {
            // Here change path to the log.txt file
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
                                                    + "\\$username$\\FartDesktopApp\\log.txt";
            Exception e = (Exception)args.ExceptionObject;
        }

        private void LogMachineDetails()
        {
            var computer = new Microsoft.VisualBasic.Devices.ComputerInfo();

            string text = "OS: "
                + computer.OSPlatform
                + " v"
                + computer.OSVersion
                + Environment.NewLine
                + computer.OSPlatform
                + Environment.NewLine
                + "RAM: "
                + computer.TotalPhysicalMemory.ToString()
                + Environment.NewLine
                + "Language: "
                + computer.InstalledUICulture.EnglishName;
        }
    }
}