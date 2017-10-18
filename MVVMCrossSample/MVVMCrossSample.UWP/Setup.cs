using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Uwp.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace MVVMCrossSample.UWP
{
	public class Setup : MvxWindowsSetup
	{
		public Setup(Frame rootFrame) : base(rootFrame)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			return new MVVMCrossSample.App();
		}

		protected override IMvxTrace CreateDebugTrace()
		{
			return new DebugTrace();
		}
	}
}
