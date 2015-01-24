using System;
using SQLite.Net.Attributes;

namespace Gevi.Hidegviz.Core
{
	public class Observation
	{
		[PrimaryKey]
		public Guid Id { get; set; }
	}
}

