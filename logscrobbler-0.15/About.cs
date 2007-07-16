/*
 * Created by SharpDevelop.
 * User: drub
 * Date: 10/3/2006
 * Time: 8:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace LogScrobbler
{
	/// <summary>
	/// Description of About.
	/// </summary>
	public partial class About
	{
		#region Constructors

		public About()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			Type type = Type.GetType("LogScrobbler.MainForm");
			Assembly assembly = Assembly.GetAssembly(type);
			AssemblyName assemblyName = assembly.GetName();
			Version version = assemblyName.Version;
			lblVersion.Text = version.ToString();
		}

		#endregion

		#region Event Handlers

		void About_Load(object sender, System.EventArgs e)
		{
			string projectLink = "http://code.google.com/p/logscrobbler/";
			string lastFmLink = "http://www.last.fm/user/kernelsandirs";

			lnkProject.Links.Clear();
			lnkProject.Links.Add(0, projectLink.Length, projectLink);
			lnkLastFm.Links.Clear();
			lnkLastFm.Links.Add(0, lastFmLink.Length, lastFmLink);
		}

		void btnClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}
		
		void lnkProject_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			ProcessStartInfo sInfo = new ProcessStartInfo(e.Link.LinkData.ToString());  
       		Process.Start(sInfo);
		}
				
		void lnkLastFm_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			ProcessStartInfo sInfo = new ProcessStartInfo(e.Link.LinkData.ToString());  
       		Process.Start(sInfo);
		}

		#endregion
	}
}
