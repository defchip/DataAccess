using System;
using System.Configuration;
using System.Windows.Forms;

//To avoid baking-in dependencies inject the data access classes.
//In this case, due to infrastructure limitations I 'injected' the data access layer object
//and business-specific query object in program.cs.
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