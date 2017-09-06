using System;

using System.Data;

namespace DataAccess

{

public interface IDataAccess

{

#region Method Signatures

bool DatabaseItemExists(string query);

bool HasOpened {get;set;}

DataTable GetDataTable(string query);

object GetDataItem(string query);

string ErrMessage {get;set;}

void ExecuteParameterisedSproc(string sprocName, object[,] fieldAndValue);

void ExecuteSproc(string sprocName);

string ToString();

#endregion

}

}