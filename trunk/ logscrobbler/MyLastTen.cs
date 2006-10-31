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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
		public string myuser;
		public string swColor;
		public MyLastTen()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			GatherUser();
			getMyLastTen();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void GatherUser(){
			try{
				
				StreamReader sett = new StreamReader("LogScrobbler.txt");
				string setting;
				string[] fields;
				int count = 0;
				while ((setting = sett.ReadLine()) != null)
				{
					fields = setting.Split('=');
					if(count == 0) {
						myuser = fields[1];
					}
					if(count == 5) {
						swColor = fields[1];
					}
					count++;
				}
				sett.Close();
			}
			catch
			{
				
			}
			if(swColor == "sw2") {
				listView1.BackgroundImage =
					(System.Drawing.Bitmap)resources.GetObject("$this.bg2");
			} else {
				listView1.BackgroundImage =
					(System.Drawing.Bitmap)resources.GetObject("$this.BackgroundImage");
			}
		}
		
		public void getMyLastTen(){
			try
			{
				//http://ws.audioscrobbler.com/1.0/user/kernelsandirs/recenttracks.rss
				System.Net.WebClient Client = new WebClient();
				//Client.Proxy = new WebProxy();
				Stream strm = Client.OpenRead("http://ws.audioscrobbler.com/1.0/user/" + myuser + "/recenttracks.rss");
				StreamReader sr = new StreamReader(strm);
				string line;
				string lastEntry = "";
				string oktoGo = "";
				string title = "";
				string link = "";
				do
				{
					line = sr.ReadLine();
					Regex regex1 = new Regex("<item>");
					if(regex1.IsMatch(line)) {
						oktoGo = "OK";
					}
					
					Regex regex2= new Regex("<title>");
					if(regex2.IsMatch(line)) {
						if (oktoGo == "OK"){
							title = line.Replace("<title>","");
							title = title.Replace("</title>","");
							title = title.Trim();
						}
					}
					Regex regex3= new Regex("<link>");
					if(regex3.IsMatch(line)) {
						if (oktoGo == "OK"){
							link = line.Replace("<link>","");
							link = link.Replace("</link>","");
							link = link.Trim();
						}
					}
					
					Regex regex = new Regex("<pubDate>");
					if(regex.IsMatch(line)) {
						if (oktoGo == "OK"){
							lastEntry = line.Replace("<pubDate>","");
							lastEntry = lastEntry.Replace("</pubDate>","");
							lastEntry = lastEntry.Replace(lastEntry.Substring(lastEntry.Length-5,5),"");
							lastEntry = lastEntry.Trim();
							ListViewItem item = listView1.Items.Add(title);
							item.SubItems.Add(lastEntry);
							item.Tag = link;
						}
					}
				}
				while (line !=null);
				strm.Close();
			}
			catch
			{
				
			}
		}
		
		void ListView1DoubleClick(object sender, System.EventArgs e)
		{
			ProcessStartInfo sInfo = new ProcessStartInfo(listView1.SelectedItems[0].Tag.ToString());
			Process.Start(sInfo);
		}
		
		void Button1Click(object sender, System.EventArgs e)
		{
			listView1.Items.Clear();
			getMyLastTen();
		}
		
		void Button2Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}
