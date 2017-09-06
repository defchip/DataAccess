using System;
using System.Data;

namespace DataAccess
{
	/// <summary>
	/// Basic generic POCO to illustrate data access methods.
	/// </summary>
	public class Item
	{
		private int _itemId;
		private string _itemText;
		
		public int ItemId{get{return _itemId;} set{_itemId = value;}}
		public string ItemText{get{return _itemText;} set{_itemText = value;}}
		
		public Item() {}
		
		public Item(DataRow row)
		{
			this._itemId = Int32.Parse(row[0].ToString());
			this._itemText = row[2].ToString();
		}
		
		public override string ToString()
		{
			return "(" + ItemId + ") " + ItemText;
		}
	}
}
