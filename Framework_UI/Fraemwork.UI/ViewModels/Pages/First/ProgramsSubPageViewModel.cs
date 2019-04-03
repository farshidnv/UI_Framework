
namespace Framework.UI.ViewModels.Pages.First
{
    using GalaSoft.MvvmLight;

    public class ProgramsSubPageViewModel : ViewModelBase
    {
        #region Fields

        private string placeholderText = "Programs Page";

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
