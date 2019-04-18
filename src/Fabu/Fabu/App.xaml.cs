using Fabu.Services.Base;
using Fabu.ViewModel.Base;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Xamarin.Forms;

namespace Fabu
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DialogService dialogService = new DialogService();
            NavigationService navigationService = new NavigationService();

            SimpleIoc.Default.Unregister<INavigationService>();
            SimpleIoc.Default.Register<INavigationService>(() => navigationService); //Registrando o serviço de navegação no SimpleIOC do MVVM Light

            SimpleIoc.Default.Unregister<IDialogService>();
            SimpleIoc.Default.Register<IDialogService>(() => dialogService); //Registrando o serviço de diálogo no SimpleIOC do MVVM Light

            NavigationPage navigationPage = new NavigationPage(new View.MainTabbedPageView());

            //Inicialização dos serviços
            navigationService.Initialize(navigationPage);
            dialogService.Initialize(navigationPage);

            //Seta a página root da aplicação
            MainPage = navigationPage;
        }

        private static ViewModelLocator _locator;
        public static ViewModelLocator Locator
        {
            get => _locator ?? (_locator = new ViewModelLocator());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
