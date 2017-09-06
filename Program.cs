using System;
using System.Configuration;
using System.Windows.Forms;

namespace DataAccess
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

            //Initialise DataAccess object
			DataAccess dataAccess = new DataAccess(conn);
			if (!dataAccess.HasOpened)
			{
				MessageBox.Show("Fail!");
				return;
			}
            
            //Initialise QueryProvider object using dataAccess as DAL
			QueryProvider queryProvider = new QueryProvider(dataAccess);
			Application.Run(new UIMain(queryProvider));
		}
	}
}