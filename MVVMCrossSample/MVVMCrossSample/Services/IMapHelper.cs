using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls.Maps;

namespace MVVMCrossSample.Services
{
	public interface IMapHelper
	{
		void sendMapICons(List<MapIcon> list);
	}
}
