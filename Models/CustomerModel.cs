using System;

namespace MVVMExample
{
	public class CustomerModel
	{

		public string[] GetCustomerNames()
		{
			//todo: create SQLite customer table
			return new string[] { "Bob Schultz", "Frank Edison", "Steve Jackson", "Ted Brasky" };
		}

	}
}

