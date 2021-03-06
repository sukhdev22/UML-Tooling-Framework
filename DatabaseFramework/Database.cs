﻿
using System;
using System.Collections.Generic;

namespace DatabaseFramework
{
	/// <summary>
	/// A database contains tables, stored procedures, users, etc...
	/// </summary>
	public interface Database:DatabaseItem
	{
		string type {get;set;}
		DataBaseFactory databaseFactory {get;set;}
		List<Table> tables {get;set;}
		void addTable(Table table);
		void removeTable(Table table);
		Table getCorrespondingTable(Table externalTable);
    Table getTable(string name);
	}
}
