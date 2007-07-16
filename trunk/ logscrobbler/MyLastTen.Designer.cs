/*
 * Created by SharpDevelop.
 * User: drub
 * Date: 10/11/2006
 * Time: 11:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LogScrobbler
{
	partial class MyLastTen : System.Windows.Forms.Form
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyLastTen));
			this.lstLastTenTracks = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.btnReload = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstLastTenTracks
			// 
			this.lstLastTenTracks.BackgroundImage = global::LogScrobbler.Properties.Resources.bg;
			this.lstLastTenTracks.BackgroundImageTiled = true;
			this.lstLastTenTracks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.lstLastTenTracks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstLastTenTracks.ForeColor = System.Drawing.SystemColors.Menu;
			this.lstLastTenTracks.Location = new System.Drawing.Point(0, 0);
			this.lstLastTenTracks.Name = "lstLastTenTracks";
			this.lstLastTenTracks.Size = new System.Drawing.Size(431, 207);
			this.lstLastTenTracks.TabIndex = 0;
			this.lstLastTenTracks.UseCompatibleStateImageBehavior = false;
			this.lstLastTenTracks.View = System.Windows.Forms.View.Details;
			this.lstLastTenTracks.DoubleClick += new System.EventHandler(this.lstLastTenTracks_DoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Artist - Track";
			this.columnHeader1.Width = 276;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Played At";
			this.columnHeader2.Width = 144;
			// 
			// btnReload
			// 
			this.btnReload.BackColor = System.Drawing.SystemColors.Window;
			this.btnReload.Location = new System.Drawing.Point(104, 174);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(108, 21);
			this.btnReload.TabIndex = 1;
			this.btnReload.Text = "Reload";
			this.btnReload.UseVisualStyleBackColor = true;
			this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.SystemColors.Window;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(218, 174);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(108, 21);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// MyLastTen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::LogScrobbler.Properties.Resources.bg;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(431, 207);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnReload);
			this.Controls.Add(this.lstLastTenTracks);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MyLastTen";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Last Ten Posts";
			this.Load += new System.EventHandler(this.MyLastTen_Load);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnReload;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lstLastTenTracks;
	}
}
