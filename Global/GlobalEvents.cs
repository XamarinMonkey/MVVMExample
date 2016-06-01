using System;

namespace MVVMExample
{
	
	public class GlobalEvents
	{

		//events

		public static event StringArrayHandler OnCarsChanged;
		public static void RaiseOnCarsChanged(string[] cars)
		{
			OnCarsChanged?.Invoke (cars);
		}

		public static event StringArrayHandler OnCustomersChanged;
		public static void RaiseOnCustomersChanged(string[] customers)
		{
			OnCustomersChanged?.Invoke (customers);
		}

		//delegates

		public delegate void StringArrayHandler(string[] data);

	}

}

