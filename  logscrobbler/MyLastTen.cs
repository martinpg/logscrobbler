/*
 * Created by SharpDevelop.
 * User: drub
 * Date: 10/11/2006
 * Time: 11:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace LogScrobbler
{
	/// <summary>
	/// Description of MyLastTen.
	/// </summary>
	public partial class MyLastTen
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
		public string userName;
		public string swColor;
		
		public MyLastTen(string userName)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			this.userName = userName;
			lstLastTenTracks.BackgroundImage = (System.Drawing.Bitmap)resources.GetObject("$this.BackgroundImage");
		}
		
		public void getMyLastTen()
		{
			TrackList lastTenTracks = AudioscrobblerWebServices.GetRecentTracks(userName);

			foreach (Track currentTrack in lastTenTracks)
			{
				string label = string.Format("{0} - {1}", currentTrack.ArtistName, currentTrack.TrackName);
				ListViewItem item = lstLastTenTracks.Items.Add(label);
				item.SubItems.Add(currentTrack.TrackPlayedAsString);
			}
		}
		
		void lstLastTenTracks_DoubleClick(object sender, System.EventArgs e)
		{
			//ProcessStartInfo sInfo = new ProcessStartInfo(listView1.SelectedItems[0].Tag.ToString());
			//Process.Start(sInfo);
		}
		
		void btnReload_Click(object sender, System.EventArgs e)
		{
			lstLastTenTracks.Items.Clear();
			getMyLastTen();
		}
		
		void btnClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void MyLastTen_Load(object sender, EventArgs e)
		{
			lstLastTenTracks.Items.Clear();
			getMyLastTen();
		}
	}
}
