/*
 * Created by SharpDevelop.
 * User: timg
 * Date: 9/29/2006
 * Time: 9:52 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Audioscrobbler;

namespace LogScrobbler
{
	public sealed class SysTrayIcon
	{
		Form1 form = new Form1();
		About aboutform = new About();
		private System.Windows.Forms.NotifyIcon trayIcon;
		private System.Windows.Forms.ContextMenu sysTrayMenu;

		#region Initialize icon and menu
		public SysTrayIcon()
		{
			trayIcon = new NotifyIcon();
			sysTrayMenu = new ContextMenu(InitializeMenu());
			trayIcon.DoubleClick += TrayIconDoubleClick;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysTrayIcon));
			trayIcon.Icon = (Icon)resources.GetObject("ls");
			trayIcon.ContextMenu = sysTrayMenu;
			
			try
			{
				form.ShowDialog();
			}
			catch
			{
				
			}
		}
	
		private MenuItem[] InitializeMenu()
		{
			MenuItem[] menu = new MenuItem[] {
				new MenuItem("Open", menuOpenClick),
				new MenuItem("About", menuAboutClick),
					new MenuItem("Exit", menuExitClick)
			};
			return menu;
		}
		#endregion
		
		#region Main - Program entry point
		/// <summary>Program entry point.</summary>
		/// <param name="args">Command Line Arguments</param>
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			bool isFirstInstance;
			// Please use a unique name for the mutex to prevent conflicts with other programs
			using (Mutex mtx = new Mutex(true, "LogScrobbler", out isFirstInstance)) {
				if (isFirstInstance) {
					SysTrayIcon sysTrayIcon = new SysTrayIcon();
					sysTrayIcon.trayIcon.Visible = true;
					Application.Run();
					sysTrayIcon.trayIcon.Dispose();
				} else {
					// The application is already running
					
				}
			} // releases the Mutex
		}
		#endregion
		
		#region Event Handlers
		private void menuAboutClick(object sender, EventArgs e)
		{
			aboutform.ShowDialog();
		}
		
		private void menuExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		private void menuOpenClick(object sender, EventArgs e)
		{
			try
			{
				form.ShowDialog();
			}
			catch
			{
				
			}
		}
		private void TrayIconDoubleClick(object sender, EventArgs e)
		{
			try
			{
				form.ShowDialog();
			}
			catch
			{
				
			}
		}


		#endregion
	}
}
