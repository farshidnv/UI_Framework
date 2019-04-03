using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.UI.ViewModels;

namespace Framework.UI.Services.Implementations
{
    public class UINavigationService : IUINavigationService
    {
        private readonly Dictionary<string, string> _pagesByKey;
        private readonly Stack<string> _historicStack;
        ViewModelLocator _locator;

        public UINavigationService()
        {
             _locator = new ViewModelLocator();
            _pagesByKey = new Dictionary<string, string>();
            _historicStack = new Stack<string>();

        }
        public string CurrentPageKey
        {
            get;
            private set;
        }

        string poped = "";
        public void GoBack()
        {
            if (_historicStack.Count > 0)
            {
                poped = _historicStack.Pop();
                _locator.Main.SetSelectedPageAndNotify(poped);
            }
            
        }

        public void NavigateTo(string pageKey)
        {
            NavigateTo(pageKey, null);
        }

        public void NavigateTo(string pageKey, object parameter)
        {
            lock (_pagesByKey)
            {
                    _historicStack.Push(pageKey);
              
                CurrentPageKey = pageKey;
            }
        }
    }
}
