using System;
using System.Data;

namespace DataAccess
{
    public class MySampleClass
    {
        QueryProvider queryProvider;
        Item item = new Item();

        //Sample class which illustrates calling business-specific QueryProvider methods.
        public MySampleClass(QueryProvider queryProvider)
        {
            this.queryProvider = queryProvider;
        }
        
        public GetSomeData()
        {
            DataTable dt = queryProvider.ReadAllItems();

			foreach (DataRow row in dt.Rows)
			{
				//display row[0].ToString() as an example.
			}
        }

        //Illustrates calling parameterised stored procedure method in data access layer.
        public void CreateANewItem()
        {
            item.ItemId = 1;
            item.ItemText = "myItem"	
            queryProvider.CreateItem(item);
        }

        //Illustrates calling non-parameterised stored procedure method in data access layer.
        public void ExecuteMyProcedure()
        {
            queryProvider.RunStoredProcedure();
        }
    }
}