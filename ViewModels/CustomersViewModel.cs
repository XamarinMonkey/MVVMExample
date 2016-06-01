using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace MVVMExample
{
	public class CustomersViewModel : INotifyPropertyChanged
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
			get { return "Customers"; }
		}

		public string[] Items
		{
			get { return _customerModel.GetCustomerNames (); }
		}

		#endregion

		#region vars

		private CustomerModel _customerModel;

		#endregion

		public CustomersViewModel ()
		{
			_customerModel = new CustomerModel ();
			GlobalEvents.OnCustomersChanged += handleOnCustomersChanged;
		}

		private void handleOnCustomersChanged(string[] customers)
		{
			RaisePropertyChanged ("Items");
		}

	}
}


