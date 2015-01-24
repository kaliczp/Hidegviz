using System;
using SQLite.Net;

namespace Gevi.Hidegviz.Core
{
	public class Repository
	{
		private SQLiteConnection _connection;

		public Repository(SQLiteConnection connection)
		{
			_connection = connection;
			_connection.CreateTable<Observation>();
		}
	}
}

