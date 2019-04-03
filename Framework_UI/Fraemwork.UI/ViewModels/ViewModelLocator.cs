namespace Framework.UI.ViewModels
{
    using GalaSoft.MvvmLight.Ioc;
    using GalaSoft.MvvmLight.Views;
    using Microsoft.Practices.ServiceLocation;

    using Pages.First;
    using Pages.Second;
    using Pages.Home;

    using Services;
    using Services.Implementations;

    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            // Register services.
            SimpleIoc.Default.Register<IMainWindowService, MainWindowService>();

            SimpleIoc.Default.Register<IUINavigationService, UINavigationService>();

            // Register view models.
            SimpleIoc.Default.Register<MainViewModel>();

            SimpleIoc.Default.Register<FirstPageViewModel>();
            SimpleIoc.Default.Register<Pages.First.OverviewSubPageViewModel>();
            SimpleIoc.Default.Register<ProgramsSubPageViewModel>();


            SimpleIoc.Default.Register<HomePageViewModel>();

            SimpleIoc.Default.Register<SecondPageViewModel>();
            SimpleIoc.Default.Register<Pages.Second.OverviewSubPageViewModel>();
            SimpleIoc.Default.Register<PhonesSubPageViewModel>();
        }

        /// <summary>
        /// Gets the main window view model.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();

        #region First

        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public FirstPageViewModel First => ServiceLocator.Current.GetInstance<FirstPageViewModel>();

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public Pages.First.OverviewSubPageViewModel FirstOverview
            => ServiceLocator.Current.GetInstance<Pages.First.OverviewSubPageViewModel>();

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public ProgramsSubPageViewModel ProgramsVM => ServiceLocator.Current.GetInstance<ProgramsSubPageViewModel>();

        #endregion

        #region Home

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public HomePageViewModel HomeMain => ServiceLocator.Current.GetInstance<HomePageViewModel>();

        #endregion

        #region Second
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public SecondPageViewModel Second => ServiceLocator.Current.GetInstance<SecondPageViewModel>();

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public PhonesSubPageViewModel Phones => ServiceLocator.Current.GetInstance<PhonesSubPageViewModel>();

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public Pages.Second.OverviewSubPageViewModel SecondOverview => ServiceLocator.Current.GetInstance<Pages.Second.OverviewSubPageViewModel>();

        #endregion



        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {
        }
    }
}