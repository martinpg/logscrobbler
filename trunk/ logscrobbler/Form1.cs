/*
 * Created by SharpDevelop.
 * User: timg
 * Date: 9/29/2006
 * Time: 10:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Audioscrobbler.NET;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace LogScrobbler
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1
	{
		public Form1()
		{

			InitializeComponent();
			try{

				StreamReader sett = new StreamReader("c:\\LogScrobbler.txt");
				string setting;
				string[] fields;
				int count = 0;
				while ((setting = sett.ReadLine()) != null)
				{
					fields = setting.Split('=');
					if(count == 0) {
						textBox2.Text = fields[1];
					}
					if(count == 1) {
						textBox3.Text = fields[1];
					}
					if(count == 2) {
						textBox1.Text = fields[1];
					}
					if(count == 3) {
						checkBox1.Checked = Convert.ToBoolean(fields[1]);
					}
					if(count == 4) {
						checkBox2.Checked = Convert.ToBoolean(fields[1]);
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

		void Button2Click(object sender, System.EventArgs e)
		{
			openFileDialog1.ShowDialog();
		}
		
		void OpenFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			textBox1.Text = openFileDialog1.FileName;
			checkReq();
			checkForFile();
			listView1.Items.Clear();
			getList();
		}
		
		void checkReq(){
			if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "") {
				button1.Enabled = true;
				button3.Enabled = true;
			} else {
				button1.Enabled = false;
				button3.Enabled = false;
			}
		}

		
		void Button1Click(object sender, System.EventArgs e)
		{

			Track track = new Track();
			AudioscrobblerRequest AS = new AudioscrobblerRequest();
			AudioscrobblerException AE = new AudioscrobblerException();
			AS.Username = textBox2.Text.ToString();
			AS.Password = textBox3.Text.ToString();
			int countChecked =0;
			try
			{
			foreach (System.Windows.Forms.ListViewItem itemRow in listView1.CheckedItems)
			{
				countChecked++;
			}

			double stepSize = 0;
			stepSize = 100 / countChecked;
			progressBar1.Step = Convert.ToInt32(stepSize);
			
			foreach (System.Windows.Forms.ListViewItem itemRow in listView1.CheckedItems)
			{
				for( int counter = 0; counter < itemRow.SubItems.Count; counter++ )
				{
					track.ArtistName = itemRow.SubItems[0].Text;
					track.TrackName = itemRow.SubItems[1].Text;
					track.AlbumName = itemRow.SubItems[2].Text;
					track.TrackLength = Convert.ToInt32(itemRow.SubItems[3].Text);
					track.TimePlayed = itemRow.SubItems[4].Text;
					
				}
				//MessageBox.Show(track.ArtistName + " " +track.TrackName + " " +track.AlbumName + " " +track.TrackLength + " " + track.TimePlayed);
				progressBar1.Value = progressBar1.Value + Convert.ToInt32(stepSize);
				AS.SubmitTrack(track);
			}

			MessageBox.Show("Sync Complete.");
			if(checkBox1.Checked) {
				File.Delete(textBox1.Text.ToString());
				listView1.Items.Clear();
			}
			if(checkBox2.Checked) {
				Application.Exit();
			}
			}
			catch
			{
				MessageBox.Show("Nothing to sync");
			}
			saveSettings();
			checkForFile();
			progressBar1.Value = 0;
		}
		

		void saveSettings(){

			StreamWriter sw = new StreamWriter("c:\\LogScrobbler.txt");
			sw.Write("Username=" + textBox2.Text.ToString());
			sw.Write("\r\n");
			sw.Write("Password=" + textBox3.Text.ToString());
			sw.Write("\r\n");
			sw.Write("Path=" + textBox1.Text.ToString());
			sw.Write("\r\n");
			sw.Write("Delete=" + checkBox1.Checked.ToString());
			sw.Write("\r\n");
			sw.Write("Exit=" + checkBox2.Checked.ToString());
			sw.Close();
		}
		
		void LinkLabel1LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			ProcessStartInfo sInfo = new ProcessStartInfo(linkLabel1.Text.ToString());
			Process.Start(sInfo);
		}
		
		void TextBox2TextChanged(object sender, System.EventArgs e)
		{
			linkLabel1.Text = "http://www.last.fm/user/"+textBox2.Text.ToString();
		}
		
		void TextBox3KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			checkReq();
		}
		
		void TextBox2KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			checkReq();
		}
		
		void Form1Load(object sender, System.EventArgs e)
		{
			linkLabel1.Links.Remove(linkLabel1.Links[0]);
			linkLabel1.Links.Add(0, linkLabel1.Text.Length, "http://www.last.fm/user/"+textBox2.Text.ToString());
			checkForFile();
		}
		
		
		void checkForFile(){
			if(File.Exists(textBox1.Text.ToString()))
			{
				button1.Enabled = true;
				button3.Enabled = true;
				label4.Text = "";
				listView1.Items.Clear();
				getList();
			} else {
				button1.Enabled = false;
				button3.Enabled = false;
				label4.Text = "scrobbler log not found";
			}
			
		}
		
		void getList()
		{
			string FILELINE;
			string[] fields;
			string trackStatus = "";
			StreamReader log = new StreamReader(textBox1.Text.ToString());
			while ((FILELINE = log.ReadLine()) != null)
			{
				fields = FILELINE.Split('\t');
				Regex regex = new Regex("#");
				if(!regex.IsMatch(fields[0])) {
					trackStatus = fields[5];
					if(trackStatus == "L") {
						ListViewItem item = listView1.Items.Add(fields[0]);
						item.Checked = true;
						item.SubItems.Add(fields[2]);
						item.SubItems.Add(fields[1]);
						item.SubItems.Add(fields[4]);
						item.SubItems.Add((new DateTime(1970,1,1,0,0,0)).AddSeconds(Convert.ToDouble(fields[6])).ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"));
					}
				}
			}
			log.Close();
		}
		
		void Button3Click(object sender, System.EventArgs e)
		{
			this.Size = new System.Drawing.Size(650, 600);
			listView1.Items.Clear();
			listView1.Visible = true;
			getList();
		}
		
		void Button4Click(object sender, System.EventArgs e)
		{
			this.Size = new System.Drawing.Size(365, 265);
			listView1.Visible = false;
		}

	}
	
	public class Track : IAudioscrobblerTrack
	{
		string a_text = "";
		string t_text = "";
		string al_text = "";
		string m_text = "";
		string tp_text = "";
		int tl_int;
		public Track()
		{}
		public string ArtistName
		{
			get
			{
				return a_text;
			}

			set
			{
				a_text = value;
			}
		}
		public string TrackName
		{
			get
			{
				return t_text;
			}

			set
			{
				t_text = value;
			}
		}
		public string AlbumName
		{
			get
			{
				return al_text;
			}

			set
			{
				al_text = value;
			}
		}
		public string MusicBrainzID
		{
			get
			{
				return m_text;
			}

			set
			{
				m_text = value;
			}
		}
		public string TimePlayed
		{
			get
			{
				return tp_text;
			}

			set
			{
				tp_text = value;
			}
		}
		public int TrackLength
		{
			get
			{
				return tl_int;
			}

			set
			{
				tl_int = value;
			}
		}
	}
}
