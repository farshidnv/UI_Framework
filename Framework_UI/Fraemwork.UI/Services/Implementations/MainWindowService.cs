namespace Framework.UI.Services.Implementations
{
    using System.Windows;

    /// <summary>
    /// Provides utility methods related to managing the main application window.
    /// </summary>
    public class MainWindowService : IMainWindowService
    {
        /// <summary>
        /// <see cref="IMainWindowService.Close"/>
        /// </summary>
        public void Close()
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// <see cref="IMainWindowService.Minimize"/>
        /// </summary>
        public void Minimize()
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}
