using System;
using Gtk;
using SQLite.Net;
using SQLite.Net.Platform.Generic;
using Gevi.Hidegviz.Core;

public partial class MainWindow: Gtk.Window
{
	private SQLiteConnection _connection;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();

		_connection = new SQLiteConnection (new SQLitePlatformGeneric (), "test.db");
		var repository = new Repository(_connection);
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
