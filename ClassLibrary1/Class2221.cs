using System;
using System.Data;

namespace ClassLibrary1
{
    public class Class1
    {
		public void SurpressJit()
		{
			int nouse = 0;
			for (int i = 0; i < 10; i++)
			{
				DataTable dataTableNoUse = new DataTable();
			}
		}

	}
}
