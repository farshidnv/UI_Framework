namespace Framework.UI
{
    using System.Windows;
    using GalaSoft.MvvmLight.Threading;

    public partial class App : Application
    {
        static App()
        {
            DispatcherHelper.Initialize();
        }
    }
}
