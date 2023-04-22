using HelloWord.Services;
using HelloWord.ViewModels;

namespace HelloWord
{
    public class ServiceLocator
    {
        private IServiceProvider _serviceProvider; 
        public MainPageViewModel MainPageViewModel=>_serviceProvider.GetService<MainPageViewModel>();//依赖注入 IoC
        public ServiceLocator() {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<MainPageViewModel>();
            serviceCollection.AddSingleton<IKeyValueSrorage,KeyValueStorage>();
            _serviceProvider= serviceCollection.BuildServiceProvider();
        }

    }
}
