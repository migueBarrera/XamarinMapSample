using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace MVVMCrossSample.Utils
{
	public class Util
	{
		public static List<BasicGeoposition> GetListGeoposition()
		{
			List<BasicGeoposition> list = new List<BasicGeoposition>();

			list.Add(new BasicGeoposition() { Latitude = 37.3761647, Longitude = -5.9839608 });//Plaza españa
			list.Add(new BasicGeoposition() { Latitude = 37.3755692, Longitude = -6.0039296 });//
			list.Add(new BasicGeoposition() { Latitude = 37.37939938098886, Longitude = -5.965951681137085 });//casa
			//list.Add(new BasicGeoposition() { Latitude = 37.3761647, Longitude = -5.9839608 });

			return list;
		}
	}
}
