using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.UI.Xaml.Controls.Maps;

namespace MVVMCrossSample.ViewModels
{
	public class MainViewModel : MvxViewModel
	{

		public MainViewModel()
		{
			
		}

		public override void Start()
		{
			base.Start();

			var listBasicGeoposition = Utils.Util.GetListGeoposition();
			addPOIToMaps(listBasicGeoposition);
		}

		private void addPOIToMaps(List<BasicGeoposition> listBasicGeoposition)
		{
			var listMapIcon = new List<MapIcon>();

			foreach (BasicGeoposition item in listBasicGeoposition)
			{
				Geopoint gp = new Geopoint(item);
				// Create a MapIcon.
				var mapIcon1 = new MapIcon
				{
					Location = gp,
					NormalizedAnchorPoint = new Point(0.5, 1.0),
					Title = "MapIcon item",
					ZIndex = 0,
				};

				listMapIcon.Add(mapIcon1);
			}

			//HOW SET TO VIEW ¿???????????

		}
	}
}
