/*
 * Created by SharpDevelop.
 * User: timg
 * Date: 9/29/2006
 * Time: 10:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Reflection;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Audioscrobbler.NET;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Net;
using System.ComponentModel;
using System.Collections.Generic;

namespace LogScrobbler
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm
	{
		#region Members

		public string swColor;
		public string myDir = Directory.GetCurrentDirectory();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

		// TODO: move this declaration to a config file
		// TODO: move user settings out of a text file and into XML
		public const string mySettingsFile = "LogScrobbler.txt";

		// store the file as a list of Track objects when it is read
		private TrackList trackList = new TrackList(100);

		#endregion

		#region Constructors

		public MainForm()
		{
			InitializeComponent();

			// load the user's settings
			loadSettings();

			//if (chkShowAvatar.Checked == true)
			//{
			//    getMyImage();
			//}

			// set the default visibility of the list view (off)
			toggleTrackListVisibility(false);

			// set version in TitleBar
			Type type = Type.GetType("LogScrobbler.MainForm");
			Assembly assembly = Assembly.GetAssembly(type);
			AssemblyName assemblyName = assembly.GetName();
			Version version = assemblyName.Version;

			string versionInfo = string.Format("{0}.{1}", version.Major, version.Minor);
			this.Text += versionInfo;
		}

		#endregion

		#region Event Handlers

		void MainForm_Load(object sender, System.EventArgs e)
		{
			updateLastFmUrl();

			if (!string.IsNullOrEmpty(txtFilename.Text))
				getList();

			checkReq();
		}

		private void MainForm_HelpButtonClicked(object sender, CancelEventArgs e)
		{
			About aboutForm = new About();
			aboutForm.ShowDialog();
			e.Cancel = true;
		}

		void btnBrowseForFile_Click(object sender, System.EventArgs e)
		{
			openFileDialog1.ShowDialog();
		}

		void OpenFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			txtFilename.Text = openFileDialog1.FileName;
			getList();
			checkReq();
		}

		private void txtFilename_Leave(object sender, EventArgs e)
		{
			if (txtFilename.Modified)
			{
				getList();
				checkReq();
				txtFilename.Modified = false;
			}
		}

		void btnDoUpload_Click(object sender, System.EventArgs e)
		{
			try
			{
				doUpload();
			}
			catch (ArgumentException ae)
			{
				MessageBox.Show(ae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		void lnkLastFmUrl_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			ProcessStartInfo sInfo = new ProcessStartInfo(lnkLastFmUrl.Text);
			Process.Start(sInfo);
		}

		void txtUsername_TextChanged(object sender, System.EventArgs e)
		{
			updateLastFmUrl();
			checkReq();
		}

		void txtUsername_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
		}

		void txtPassword_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
		}

		private void txtPassword_TextChanged(object sender, EventArgs e)
		{
			checkReq();
		}

		void btnShowLastPosts_Click(object sender, System.EventArgs e)
		{
			MyLastTen lastTen = new MyLastTen(txtUsername.Text);
			lastTen.ShowDialog();
			lastTen.Dispose();
		}

		void btnSaveSettings_Click(object sender, System.EventArgs e)
		{
			saveSettings();
		}

		/// <summary>
		/// Toggle the appearance of the list item depending on whether it was checked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void lvTrackList_ItemChecked(object sender, System.Windows.Forms.ItemCheckedEventArgs e)
		{
			if (e.Item.Checked == false)
				e.Item.ForeColor = System.Drawing.Color.Gray;
			else
				e.Item.ForeColor = System.Drawing.Color.DarkGreen;
		}


		private void rdoSelectTracksForScrobble_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoSelectTracksForScrobble.Checked)
			{
				toggleTrackListVisibility(true);
			}
		}

		private void rdoScrobbleAllTracks_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoScrobbleAllTracks.Checked)
			{
				toggleTrackListVisibility(false);

				// re-check all items in the list
				foreach (System.Windows.Forms.ListViewItem itemRow in lvTrackList.Items)
					itemRow.Checked = true;

			}
		}

		void MainForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			if (chkCloseExits.Checked == true)
			{
				saveSettings();
				Application.Exit();
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// Load the user's saved settings from the file.
		/// </summary>
		void loadSettings()
		{
			try
			{
				string path = string.Format(@"{0}\{1}", myDir, mySettingsFile);
				StreamReader sett = new StreamReader(path);
				string setting;
				string[] fields;
				int count = 0;
				while ((setting = sett.ReadLine()) != null)
				{
					fields = setting.Split('=');

					switch (count)
					{
						case 0:
							txtUsername.Text = fields[1];
							break;

						case 1:
							txtPassword.Text = fields[1];
							break;

						case 2:
							txtFilename.Text = fields[1];
							break;

						case 3:
							chkDeleteAfterUpload.Checked = Convert.ToBoolean(fields[1]);
							break;

						case 4:
							chkExitAfterProcessing.Checked = Convert.ToBoolean(fields[1]);
							break;

						case 5:
							swColor = fields[1];
							break;

						case 6:
							chkCloseExits.Checked = Convert.ToBoolean(fields[1]);
							break;

						//case 7:
						//    chkShowAvatar.Checked = Convert.ToBoolean(fields[1]);
						//    break;

						case 8:
							chkStorePassword.Checked = Convert.ToBoolean(fields[1]);
							break;

						//case 9:
						//    chkIgnoreTimestamps.Checked = Convert.ToBoolean(fields[1]);
						//    break;
					}

					count++;
				}

				sett.Close();
				checkReq();

			}
			catch
			{

			}
		}

		/// <summary>
		/// This method has been "disabled" and may make a comeback in the future
		/// </summary>
		void getMyImage()
		{
			//try
			//{
			//    System.Net.WebClient Client = new WebClient();
			//    Stream strm = Client.OpenRead("http://www.last.fm/user/"+ txtUsername.Text +"/");
			//    StreamReader sr = new StreamReader(strm);
			//    string line;
			//    string oktoGo = "";
			//    string oktoStop = "";
			//    string title = "";
			//    do
			//    {
			//        line = sr.ReadLine();
			//        Regex regex1 = new Regex("avatarPanel");
			//        if(regex1.IsMatch(line)) {
			//            oktoGo = "OK";
			//        }
					
			//        Regex regex2= new Regex("static.last.fm/avatar");
			//        if(regex2.IsMatch(line)) {
			//            if (oktoGo == "OK" && oktoStop != "OK"){
			//                string match = ".*<img src=\"";
			//                line = Regex.Replace(line,match,"");
			//                string match2 = "\" alt=\".*";
			//                line = Regex.Replace(line,match2,"");
			//                title = line.Replace("<img src=\"http://static.last.fm/avatar/","");
			//                title = title.Trim();
			//                //pictureBox1.WaitOnLoad = false;
			//                //pictureBox1.LoadAsync(@title);
			//            }
			//        }
					
			//        Regex regexstp = new Regex("</a>");
			//        if(regexstp.IsMatch(line)) {
			//            if (oktoGo == "OK"){
			//                oktoStop = "OK";
			//            }
			//        }
			//    }
			//    while (line !=null);
			//    strm.Close();
				

			//}
			//catch
			//{
				
			//}
			
		}
		
		void checkReq()
		{
			if (txtFilename.Text != "" && File.Exists(txtFilename.Text) &&
				txtUsername.Text != "" && txtPassword.Text != "")
			{
				btnDoUpload.Enabled = true;
			}
			else
				btnDoUpload.Enabled = false;
		}

		/// <summary>
		/// Performs the upload of scrobbled tracks
		/// </summary>
		private void doUpload()
		{
			// ensure there is something to submit
			if (trackList.Count == 0 || lvTrackList.CheckedItems.Count == 0)
			{
				throw new ArgumentException("No tracks selected for submission. Please ensure you have selected at least one track");
			}

			// first, fix the zero timestamps (if necessary)
			if (chkFixTimestamps.Checked)
				resetTimestamps();

			// check to see if first track in our list is after the last played track
			TrackList recentTracks = AudioscrobblerWebServices.GetRecentTracks(txtUsername.Text);
			if (recentTracks != null && recentTracks.Count > 0)
			{
				if (recentTracks[0].CompareTo(trackList[0]) > 0)
				{
					// display warning
					MessageBox.Show("Tracks you are about submit were played BEFORE your most recently scrobbled track. Last.fm may not accept these submissions.", "Track submission", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}

			AudioscrobblerRequest AS = new AudioscrobblerRequest();
			AudioscrobblerException AE = new AudioscrobblerException();
			AS.Username = txtUsername.Text;
			AS.Password = txtPassword.Text;

			try
			{
				// setup progress bar
				// increment in the smallest step possible
				double stepSize = lvTrackList.CheckedItems.Count / (double)100;
				double stepsDone = 0;
				toolStripProgressBar1.Step = 1;
				toolStripProgressBar1.Value = 0;

				foreach (System.Windows.Forms.ListViewItem itemRow in lvTrackList.CheckedItems)
				{
					// get the track for this list item (both lists use the same index for each track)
					Track currentTrack = trackList[itemRow.Index];

					// display a message in the status bar for this track
					toolStripStatusLabel1.Text = String.Format("Submitting '{0} - {1} - {2}' ...", currentTrack.ArtistName, currentTrack.AlbumName, currentTrack.TrackName);
					statusStrip1.Refresh();

					AS.SubmitTrack(currentTrack);

					// if we have done more steps than the stepSize,
					// decrement the step count and perform steps until stepsDone is below the stepSize
					stepsDone++;
					while (stepsDone > stepSize)
					{
						toolStripProgressBar1.PerformStep();
						stepsDone -= stepSize;
					}
				}

				MessageBox.Show("Sync Complete.");

				if (chkDeleteAfterUpload.Checked)
				{
					File.Delete(txtFilename.Text);
					lvTrackList.Items.Clear();
				}
				if (chkExitAfterProcessing.Checked)
				{
					Application.Exit();
				}
			}
			catch (AudioscrobblerException ase)
			{
				MessageBox.Show(string.Format("Nothing to sync, or there was an error connecting to Last.fm:\n\n{0}",ase.Message));
			}
			saveSettings();
			toolStripProgressBar1.Value = 0;
			toolStripStatusLabel1.Text = "Ready";
		}
		
		/// <summary>
		/// Saves the current settings to the settings file
		/// </summary>
		void saveSettings()
		{
			string path = string.Format(@"{0}\{1}", myDir, mySettingsFile);
			StreamWriter sw = new StreamWriter(path);

			sw.WriteLine("Username=" + txtUsername.Text);
			
			if(chkStorePassword.Checked == true)
				sw.WriteLine("Password=" + txtPassword.Text);
			else
				sw.WriteLine("Password=");

			sw.WriteLine("Path=" + txtFilename.Text);
			sw.WriteLine("Delete=" + chkDeleteAfterUpload.Checked);
			sw.WriteLine("Exit=" + chkExitAfterProcessing.Checked);
			sw.WriteLine("Color=" + swColor);
			sw.WriteLine("ExitApp=" + chkCloseExits.Checked);
			//sw.WriteLine("ShowAvatar=" + chkShowAvatar.Checked);
			sw.WriteLine("ShowAvatar=false");
			sw.WriteLine("SavePass=" + chkStorePassword.Checked);
			//sw.WriteLine("IgnoreStamps=" + chkIgnoreTimestamps.Checked);
			sw.WriteLine("IgnoreStamps=false");

			sw.Close();
		}
		
		/// <summary>
		/// Reads the track list from the log file.
		/// This should only be called if the log file has been changed.
		/// </summary>
		void getList()
		{
			lblMessage.Text = "";
			// first check if the file exists
			if (!File.Exists(txtFilename.Text))
			{
				lblMessage.Text = "scrobbler log not found";
				return;
			}

			StreamReader log = null;
			trackList.Clear();
			lvTrackList.Items.Clear();

			try
			{
				string fileLine;
				Track currentTrack = null;

				// open the log file as a stream
				log = new StreamReader(txtFilename.Text);
				int logSize = (int)log.BaseStream.Length;

				// keeps track of how many bytes we've read in the current "step" of the progress bar
				int bytesRead = 0;

				// increment in the smallest step possible
				int stepSize = logSize / 100;
				toolStripProgressBar1.Step = 1;
				toolStripProgressBar1.Value = 0;

				while ((fileLine = log.ReadLine()) != null)
				{
					// this may be an inaccurate measure since lines do not contain cr/lf
					bytesRead += fileLine.Length;

					// parse the track into a Track object
					currentTrack = Track.ParseTrack(fileLine);

					if (currentTrack != null)
					{
						// only report on tracks which have status "logged"
						if (currentTrack.TrackStatus == TrackStatusType.Logged)
						{
							// add the track to our list
							trackList.Add(currentTrack);

							// display a message in the status bar for this track
							toolStripStatusLabel1.Text = String.Format("Loading '{0} - {1} - {2}' ...", currentTrack.ArtistName, currentTrack.AlbumName, currentTrack.TrackName);
							statusStrip1.Refresh();

							// create a new item in the ListView for this track
							ListViewItem item = lvTrackList.Items.Add(currentTrack.ArtistName);
							item.Checked = true;
							item.SubItems.Add(currentTrack.TrackName);
							item.SubItems.Add(currentTrack.AlbumName);
							item.SubItems.Add(currentTrack.TrackLengthAsString);
							item.SubItems.Add(currentTrack.TrackPlayedAsString);

							// set the background colour of the ListViewItem
							if (lvTrackList.Items.Count % 2 == 1)
								item.BackColor = System.Drawing.Color.FromArgb(234, 234, 240);
							else
								item.BackColor = System.Drawing.Color.White;
						}
					}

					// if we have read more bytes than the stepSize,
					// decrement the byte count and perform steps until the bytes read is below the stepSize
					while (bytesRead > stepSize)
					{
						toolStripProgressBar1.PerformStep();
						bytesRead -= stepSize;
					}
				}

			}
			//catch (ArgumentException ae)
			//{
			//    MessageBox.Show(ae.Message);
			//}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			finally
			{
				// close the log file
				if (log != null)
					log.Close();
			}

			// reset the status and progress bars
			toolStripStatusLabel1.Text = "Ready";
			toolStripProgressBar1.Value = 0;
		}
		
		/// <summary>
		/// Shifts the track list's timestamps to start after the last played track.
		/// </summary>
		private void shiftTracksAfterLastPlayed()
		{
			// Shift to after last played track.
			// TODO: convert this to use XML instead of RSS?
			// TODO: put the web client call in a separate service class?

			AudioscrobblerWebServices.GetRecentTracks(txtUsername.Text);

			try
			{
				//http://ws.audioscrobbler.com/1.0/user/kernelsandirs/recenttracks.rss
				System.Net.WebClient Client = new WebClient();
				Stream strm = Client.OpenRead("http://ws.audioscrobbler.com/1.0/user/" + txtUsername.Text + "/recenttracks.rss");
				StreamReader sr = new StreamReader(strm);
				string line;
				string lastEntry = "";
				string firstInlog = "";
				string oktoGo = "";

				do
				{
					line = sr.ReadLine();
					Regex regex1 = new Regex("description");
					if (regex1.IsMatch(line))
					{
						oktoGo = "OK";
					}
					Regex regex = new Regex("pubDate");
					if (lastEntry == "")
					{
						if (regex.IsMatch(line))
						{
							if (oktoGo == "OK")
							{
								lastEntry = line.Replace("<pubDate>", "");
								lastEntry = lastEntry.Replace("</pubDate>", "");
								lastEntry = lastEntry.Replace(lastEntry.Substring(lastEntry.Length - 5, 5), "");
								lastEntry = lastEntry.Trim();
								DateTime start = (DateTime)(TypeDescriptor.GetConverter(new DateTime(1990, 5, 6)).ConvertFrom(lastEntry));
								firstInlog = lvTrackList.CheckedItems[0].SubItems[4].Text;
								DateTime end = (DateTime)(TypeDescriptor.GetConverter(new DateTime(1990, 5, 6)).ConvertFrom(firstInlog));
								long MinutesDiff = start.Ticks - end.Ticks;
								MinutesDiff = (MinutesDiff / 10000000) / 60 + 3;
								if (MinutesDiff > 0)
								{
									foreach (System.Windows.Forms.ListViewItem itemRow in lvTrackList.CheckedItems)
									{
										DateTime listtime = (DateTime)(TypeDescriptor.GetConverter(new DateTime(1990, 5, 6)).ConvertFrom(itemRow.SubItems[4].Text));
										listtime = listtime.AddMinutes(MinutesDiff);
										itemRow.SubItems[4].Text = listtime.Year + "-" + listtime.Month + "-" + listtime.Day + " " + listtime.TimeOfDay;
									}
								}
								else
								{
									MessageBox.Show("Time of last played track is less than the first track in your list, Time-shift not needed");
								}
							}
						}
					}
				} while (line != null);

				strm.Close();
			}
			catch
			{

			}
		}
		
		/// <summary>
		/// Changes the timestamps of all the tracks so that the TimePlayed is set to be some time between
		/// Now and (Now - Total duration of list).
		/// </summary>
		void resetTimestamps()
		{
			// start at the current time
			DateTime timePlayed = DateTime.Now.ToUniversalTime();

			trackList.ShiftTimePlayedFromEnd(timePlayed);

			// update track listing
			foreach (System.Windows.Forms.ListViewItem itemRow in lvTrackList.Items)
			{
				Track currentTrack = trackList[itemRow.Index];
				itemRow.SubItems[4].Text = currentTrack.TrackPlayedAsString;
			}
		}

		/// <summary>
		/// Toggles the visibility of the track list grid (and the sizes of the containing elements
		/// </summary>
		/// <param name="isVisibile"></param>
		private void toggleTrackListVisibility(bool isVisibile)
		{
			if (isVisibile)
			{
				gbTrackSettings.Size = new System.Drawing.Size(gbTrackSettings.Size.Width, gbTrackSettings.Size.Height + lvTrackList.Size.Height);
				this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height + lvTrackList.Size.Height);
				this.Refresh();
				lvTrackList.Visible = true;
			}
			else
			{
				lvTrackList.Visible = false;
				gbTrackSettings.Size = new System.Drawing.Size(gbTrackSettings.Size.Width, gbTrackSettings.Size.Height - lvTrackList.Size.Height);
				this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height - lvTrackList.Size.Height);
				this.Refresh();
			}
		}

		private void updateLastFmUrl()
		{
			string linkText = "http://www.last.fm/user/" + txtUsername.Text;
			lnkLastFmUrl.Text = linkText;
			lnkLastFmUrl.Links.Clear();
			lnkLastFmUrl.Links.Add(0, linkText.Length, linkText);
			lnkLastFmUrl.Refresh();
		}

		#endregion

	}

}
