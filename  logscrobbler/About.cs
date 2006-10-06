/*
 * Created by SharpDevelop.
 * User: drub
 * Date: 10/3/2006
 * Time: 8:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
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
		public About()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, System.EventArgs e)
		{
			Close();
		}
		
		void LinkLabel2LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			ProcessStartInfo sInfo = new ProcessStartInfo(e.Link.LinkData.ToString());  
       		Process.Start(sInfo);
		}
		
		
		void AboutLoad(object sender, System.EventArgs e)
		{
			linkLabel2.Links.Remove(linkLabel2.Links[0]);
        	linkLabel2.Links.Add(0, linkLabel2.Text.Length, "http://www.watchmefreak.com/");
		}
	}
}
