using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using MvvmCross.Plugins.Messenger;
using MVVMCrossSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMCrossSample
{
	public class App : MvxApplication
	{
		public override void Initialize()
		{
			base.Initialize();

			CreatableTypes()
			.EndingWith("Service")
			.AsInterfaces()
			.RegisterAsLazySingleton();

			//RegisterAppStart<MainViewModel>(); DEPRECATED
			RegisterNavigationServiceAppStart<MainViewModel>();

			Mvx.LazyConstructAndRegisterSingleton<IMvxMessenger, MvxMessengerHub>();
		}
	}
}
