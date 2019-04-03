namespace Framework.UI.ViewModels
{
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;
    using GalaSoft.MvvmLight.Views;
    using Models;
    using Services;
    using System.Windows.Input;


    /// <summary>
    /// The view model for the main window.
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        #region Fields

        /// <summary> The title text to display in the window header. </summary>
        private string titleText = "Farshid UI Prototype";

        /// <summary> The service used to manage the main window. </summary>
        private IMainWindowService mainWindowService;

        private INavigationService navigationService;

    
        private string firstPageTitle = "First Page";

        private string secondPageTitle = "Second Page";

        private string homePageTitle = "Home Page";

        private UiPage selectedPage = UiPage.Main;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        /// <param name="mainWindowService">The main window service.</param>
        public MainViewModel(IMainWindowService mainWindowService, IUINavigationService navigationService)
        {
            this.mainWindowService = mainWindowService;
            this.navigationService = navigationService;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the text that should be displayed as the title in the window header.
        /// </summary>
        public string TitleText 
        {
            get { return titleText; }
            set
            {
                titleText = value;
                RaisePropertyChanged();
            }
        }

        public string FirstPageTitle 
        {
            get { return firstPageTitle; }
            set
            {
                firstPageTitle = value;
                RaisePropertyChanged();
            }
        }

        public string SecondPageTitle 
        {
            get { return secondPageTitle; }
            set
            {
                secondPageTitle = value;
                RaisePropertyChanged();
            }
        }

        public string HomePageTitle 
        {
            get { return homePageTitle; }
            set
            {
                homePageTitle = value;
                RaisePropertyChanged();
            }
        }

     
        /// <summary>
        /// Gets or sets the selected page.
        /// </summary>
        public UiPage SelectedPage
        {
            get { return selectedPage; }
            set
            {
                selectedPage = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(IsSecondPageSelected));
                RaisePropertyChanged(nameof(IsFirstPageSelected));
                RaisePropertyChanged(nameof(IsHomePageSelected));
                RaisePropertyChanged(nameof(IsSubNavigationActive));
            }
        }

        public bool IsSecondPageSelected => SelectedPage == UiPage.Second;

        public bool IsFirstPageSelected => SelectedPage == UiPage.First;

        public bool IsHomePageSelected => SelectedPage == UiPage.Main;

        public bool IsSubNavigationActive => SelectedPage != UiPage.Main;

        /// <summary>
        /// Gets the command that handles minimizing the window.
        /// </summary>
        public ICommand MinimizeCommand => new RelayCommand(mainWindowService.Minimize);

        /// <summary>
        /// Gets the command that handles closing the application.
        /// </summary>
        public ICommand CloseCommand => new RelayCommand(mainWindowService.Close);

        /// <summary>
        /// Gets the command that handles setting the page that is currently selected.
        /// </summary>
        public ICommand SetSelectedPageCommand => new RelayCommand<object>(SetSelectedPage);


        public ICommand GoBackCommand => new RelayCommand(GoBackPage);

        #endregion

        #region Methods


        public void GoBackPage()
        {
            navigationService.GoBack();
        }

     
        public void SetSelectedPageAndNotify(object param)
        {
            string pageTitle = param as string;

            if (string.IsNullOrEmpty(pageTitle))
            {
                // TODO: Log an error.
                return;
            }

            UiPage page;
            if (pageTitle == FirstPageTitle)
            {
                page = UiPage.First;
            }
            else if (pageTitle == SecondPageTitle)
            {
                page = UiPage.Second;
            }
            else if (pageTitle == homePageTitle)
            {
                page = UiPage.Main;
            }
            else
            {
                // TODO: Log an error.
                return;
            }
            SelectedPage = page;
          
        }



        /// <summary>
        /// Sets the currently selected page.
        /// </summary>
        /// <param name="param">
        /// The command parameter. This should be the title text property corresponding to the page being selected.
        /// </param>
        public void SetSelectedPage(object param)
        {
            string pageTitle = param as string;

            if (string.IsNullOrEmpty(pageTitle))
            {
                // TODO: Log an error.
                return;
            }

            SetSelectedPageAndNotify(param);
            navigationService.NavigateTo(pageTitle);
        }

        #endregion
    }
}