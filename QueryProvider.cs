using System;

namespace DataAccess
{
    public class QueryProvider
    {
        IDataAccess dataAccess;

        /// <summary>
        /// QueryProvider class implements methods which call data access methods
        /// on database and return data to Class/UI.
        /// </summary>
        public QueryProvider(IDataAccess dataAccess;)
        {
            this.dataAccess = dataAccess;
        }
        
        //Sample method returning DataTable from data access layer
		public DataTable ReadAllItems()
		{
			string sql = "SELECT * FROM ITEMS;";
			return dataAccess.GetDataTable(sql);
		}

        //Sample method returning single object from data access layer
		public object ReadItem(int itemID)
		{
			string sql = "SELECT * FROM ITEMS WERE ITEM_ID = " + itemID + ";";
			return dataAccess.GetDataItem(sql);
		}

        //Sample method illustrating use of generic parameterised stored procedure method
        //in data access layer
		public void CreateItem(Item item)
		{
            dataAccess.ExecuteParameterisedSproc("USP_INS_ITEM",
                new object[,]{
                {"ITEM_ID",item.ItemId},
                {"ITEM_TEXT",item.ItemText}});
		}

        //Sample method executing stored procedure method in data access layer
        public void RunStoredProcedure()
        {
            dataAccess.ExecuteSproc("yourSprocName");
        }
    }
}
