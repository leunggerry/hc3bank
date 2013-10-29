using System;
using Gtk;
using System.IO;

public partial class MainWindow: Gtk.Window
{
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
	protected void OnInsertButtonClicked (object sender, EventArgs e)
	{

		int account = 0;
		int pass = 0;

		StreamReader ac = new StreamReader ("Accounts.txt");
		account = accountNumEnt.Text;
		pass = passEnt.Text;
		if (account == ac.ReadLine() && pass == ac.ReadLine() {
			true;
			print
		} else {
			false;
		}
		pass = ac.ReadToEnd(passEnt.Text);

		sw.Close ();

		throw new NotImplementedException ();
	}
}	
