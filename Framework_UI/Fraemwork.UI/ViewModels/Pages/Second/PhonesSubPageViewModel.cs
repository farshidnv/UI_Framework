namespace Framework.UI.ViewModels.Pages.Second
{
    using GalaSoft.MvvmLight;

    public class PhonesSubPageViewModel : ViewModelBase
    {
        #region Fields

        private string placeholderText = "Phones";

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
