using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace MVVMExample
{
	public class CarsViewModel : INotifyPropertyChanged
	{

		#region events

		public event PropertyChangedEventHandler PropertyChanged;
		public void RaisePropertyChanged(string propName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propName));
			}
		}

		#endregion

		#region properties

		public string Title 
		{
			get { return "Cars"; }
		}

		public string[] Items
		{
			get { return _carModel.GetCarNames (); }
		}

		#endregion

		#region vars

		private CarModel _carModel;

		#endregion

		public CarsViewModel ()
		{
			_carModel = new CarModel ();
			GlobalEvents.OnCarsChanged += handleOnCarsChanged;
		}

		private void handleOnCarsChanged(string[] cars)
		{
			RaisePropertyChanged ("Items");
		}

	}
}


