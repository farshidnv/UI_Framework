
namespace Framework.UI.Services
{
    /// <summary>
    /// Provides methods related to managing the main application window.
    /// </summary>
    public interface IMainWindowService
    {
        /// <summary>
        /// Closes the application.
        /// </summary>
        void Close();

        /// <summary>
        /// Minimizes the application.
        /// </summary>
        void Minimize();
    }
}
