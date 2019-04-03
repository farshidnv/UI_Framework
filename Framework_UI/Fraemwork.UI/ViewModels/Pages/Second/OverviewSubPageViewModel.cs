namespace Framework.UI.ViewModels.Pages.Second
{
    using GalaSoft.MvvmLight;

    public class OverviewSubPageViewModel : ViewModelBase
    {
        #region Fields

        private string placeholderText = "Overview Page";

        #endregion

        #region Constructor

        #endregion

        #region Properties

        public string PlaceholderText
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region Methods

        #endregion
    }
}
