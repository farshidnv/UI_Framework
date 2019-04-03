namespace Framework.UI.ViewModels.Pages.Second
{
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;
    using Models;
    using System.Windows.Input;
    public class SecondPageViewModel : ViewModelBase
    {
        #region Fields

        /// <summary> The sub page that is currently selected. </summary>
        private SecondSubPage selectedSubPage = SecondSubPage.Phones;

     
        private string overviewSubPageTitle = "Overview";


        private string phonesSubPageTitle = "Phones";
        
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


        public string PhonesSubPageTitle 
        {
            get { return phonesSubPageTitle; }
            set
            {
                phonesSubPageTitle = value;
                RaisePropertyChanged();
            }
        }

    
        public SecondSubPage SelectedSubPage
        {
            get { return selectedSubPage; }
            set
            {
                selectedSubPage = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(IsOverviewSubPageSelected));
                RaisePropertyChanged(nameof(IsPhonesSubPageSelected));
             
            }
        }


        public bool IsOverviewSubPageSelected => SelectedSubPage == SecondSubPage.Overview;


        public bool IsPhonesSubPageSelected => SelectedSubPage == SecondSubPage.Phones;


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

            SecondSubPage subPage;
            if (subPageTitle == OverviewSubPageTitle)
            {
                subPage = SecondSubPage.Overview;
            }
            else if (subPageTitle == PhonesSubPageTitle)
            {
                subPage = SecondSubPage.Phones;
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
