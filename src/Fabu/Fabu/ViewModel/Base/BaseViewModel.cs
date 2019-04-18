using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Fabu.ViewModel.Base
{
    public class BaseViewModel : ViewModelBase
    {
        protected INavigationService _navigationService;
        protected IDialogService _dialogService;

        public BaseViewModel(IDialogService dialogService, INavigationService navigationService)
        {
            _navigationService = navigationService ?? throw new ArgumentNullException("Serviço de Navegãção não pode ser nulo");
            _dialogService = dialogService ?? throw new ArgumentNullException("Serviço de Diálogo não pode ser nulo");
        }
    }
}
