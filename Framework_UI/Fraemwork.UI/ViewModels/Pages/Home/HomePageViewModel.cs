

namespace Framework.UI.ViewModels.Pages.Home
{
    using GalaSoft.MvvmLight;

    public class HomePageViewModel : ViewModelBase
    {
        #region Fields

        private string testText = "Home Page";

        #endregion

        #region Constructor

        #endregion

        #region Properties

        public string TestText
        {
            get { return testText; }
            set
            {
                testText = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region Methods

        #endregion
    }
}
