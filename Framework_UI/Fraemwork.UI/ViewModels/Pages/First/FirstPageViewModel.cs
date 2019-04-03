namespace Framework.UI.ViewModels.Pages.First
{
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;
    using Models;
    using System.Windows.Input;
    public class FirstPageViewModel : ViewModelBase
    {
        #region Fields

        /// <summary> The sub page that is currently selected. </summary>
        private FirstSubPage selectedSubPage = FirstSubPage.Overview;

        private string overviewSubPageTitle = "Overview";

        private string programsSubPageTitle = "Programs";

        #endregion

        #region Constructor

        #endregion

        #region Properties

        public string OverviewSubPageTitle
        {
            get { return overviewSubPageTitle; }
            set
            {
                overviewSubPageTitle = value;
                RaisePropertyChanged();
            }
        }

        public string ProgramsSubPageTitle
        {
            get { return programsSubPageTitle; }
            set
            {
                programsSubPageTitle = value;
                RaisePropertyChanged();
            }
        }



        /// <summary>
        /// Gets or sets the selected page.
        /// </summary>
        public FirstSubPage SelectedSubPage
        {
            get { return selectedSubPage; }
            set
            {
                selectedSubPage = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(IsOverviewSubPageSelected));
                RaisePropertyChanged(nameof(IsProgramsSubPageSelected));

            }
        }

        public bool IsOverviewSubPageSelected => SelectedSubPage == FirstSubPage.Overview;

        public bool IsProgramsSubPageSelected => SelectedSubPage == FirstSubPage.Programs;

        public ICommand SetSelectedSubPageCommand => new RelayCommand<object>(SetSelectedSubPage);

        #endregion

        #region Methods

        public void SetSelectedSubPage(object param)
        {
            string subPageTitle = param as string;

            if (string.IsNullOrEmpty(subPageTitle))
            {
                // TODO: Log an error.
                return;
            }

            FirstSubPage subPage;
            if (subPageTitle == OverviewSubPageTitle)
            {
                subPage = FirstSubPage.Overview;
            }
            else if (subPageTitle == ProgramsSubPageTitle)
            {
                subPage = FirstSubPage.Programs;
            }
            else
            {
                // TODO: Log an error.
                return;
            }

            SelectedSubPage = subPage;
        }

        #endregion
    }
}
