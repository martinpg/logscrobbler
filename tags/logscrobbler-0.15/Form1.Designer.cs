/*
 * Created by SharpDevelop.
 * User: timg
 * Date: 9/29/2006
 * Time: 10:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LogScrobbler
{
	partial class MainForm : System.Windows.Forms.Form
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnDoUpload = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFilename = new System.Windows.Forms.TextBox();
			this.btnBrowseForFile = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lnkLastFmUrl = new System.Windows.Forms.LinkLabel();
			this.chkDeleteAfterUpload = new System.Windows.Forms.CheckBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.lblMessage = new System.Windows.Forms.Label();
			this.lvTrackList = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.chkExitAfterProcessing = new System.Windows.Forms.CheckBox();
			this.btnShowLastPosts = new System.Windows.Forms.Button();
			this.btnSaveSettings = new System.Windows.Forms.Button();
			this.chkCloseExits = new System.Windows.Forms.CheckBox();
			this.chkStorePassword = new System.Windows.Forms.CheckBox();
			this.cbTimeZone = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.chkFixTimestamps = new System.Windows.Forms.CheckBox();
			this.gbTrackSettings = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.rdoSelectTracksForScrobble = new System.Windows.Forms.RadioButton();
			this.rdoScrobbleAllTracks = new System.Windows.Forms.RadioButton();
			this.gbScrobblerSettings = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.gbUserSettings = new System.Windows.Forms.GroupBox();
			this.gbTrackSettings.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.gbScrobblerSettings.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.gbUserSettings.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnDoUpload
			// 
			this.btnDoUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDoUpload.Enabled = false;
			this.btnDoUpload.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDoUpload.Location = new System.Drawing.Point(601, 523);
			this.btnDoUpload.Name = "btnDoUpload";
			this.btnDoUpload.Size = new System.Drawing.Size(90, 21);
			this.btnDoUpload.TabIndex = 0;
			this.btnDoUpload.Text = "Upload!";
			this.btnDoUpload.UseVisualStyleBackColor = true;
			this.btnDoUpload.Click += new System.EventHandler(this.btnDoUpload_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(3, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 28);
			this.label1.TabIndex = 1;
			this.label1.Text = "File:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtFilename
			// 
			this.txtFilename.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFilename.Location = new System.Drawing.Point(71, 57);
			this.txtFilename.Name = "txtFilename";
			this.txtFilename.Size = new System.Drawing.Size(127, 21);
			this.txtFilename.TabIndex = 2;
			this.txtFilename.Leave += new System.EventHandler(this.txtFilename_Leave);
			// 
			// btnBrowseForFile
			// 
			this.btnBrowseForFile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBrowseForFile.ForeColor = System.Drawing.Color.Black;
			this.btnBrowseForFile.Location = new System.Drawing.Point(205, 57);
			this.btnBrowseForFile.Name = "btnBrowseForFile";
			this.btnBrowseForFile.Size = new System.Drawing.Size(54, 21);
			this.btnBrowseForFile.TabIndex = 3;
			this.btnBrowseForFile.Text = "Browse";
			this.btnBrowseForFile.UseVisualStyleBackColor = true;
			this.btnBrowseForFile.Click += new System.EventHandler(this.btnBrowseForFile_Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Username:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(3, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 27);
			this.label3.TabIndex = 5;
			this.label3.Text = "Password:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(71, 3);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(127, 21);
			this.txtUsername.TabIndex = 6;
			this.txtUsername.Text = "kernelsandirs";
			this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(71, 30);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(127, 21);
			this.txtPassword.TabIndex = 7;
			this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
			// 
			// lnkLastFmUrl
			// 
			this.lnkLastFmUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lnkLastFmUrl.BackColor = System.Drawing.Color.Transparent;
			this.lnkLastFmUrl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnkLastFmUrl.LinkColor = System.Drawing.Color.AliceBlue;
			this.lnkLastFmUrl.Location = new System.Drawing.Point(5, 525);
			this.lnkLastFmUrl.Name = "lnkLastFmUrl";
			this.lnkLastFmUrl.Size = new System.Drawing.Size(394, 21);
			this.lnkLastFmUrl.TabIndex = 8;
			this.lnkLastFmUrl.TabStop = true;
			this.lnkLastFmUrl.Text = "http://www.last.fm/user/kernelsandirs";
			this.lnkLastFmUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLastFmUrl_LinkClicked);
			// 
			// chkDeleteAfterUpload
			// 
			this.chkDeleteAfterUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.chkDeleteAfterUpload.BackColor = System.Drawing.Color.Transparent;
			this.chkDeleteAfterUpload.Checked = true;
			this.chkDeleteAfterUpload.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkDeleteAfterUpload.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkDeleteAfterUpload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.chkDeleteAfterUpload.Location = new System.Drawing.Point(289, 3);
			this.chkDeleteAfterUpload.Name = "chkDeleteAfterUpload";
			this.chkDeleteAfterUpload.Size = new System.Drawing.Size(381, 21);
			this.chkDeleteAfterUpload.TabIndex = 9;
			this.chkDeleteAfterUpload.Text = "Delete log after upload.";
			this.chkDeleteAfterUpload.UseVisualStyleBackColor = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "Scrobbler Log (.scrobbler.log)|.scrobbler*.*log";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1FileOk);
			// 
			// lblMessage
			// 
			this.lblMessage.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanel2.SetColumnSpan(this.lblMessage, 3);
			this.lblMessage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMessage.ForeColor = System.Drawing.Color.Yellow;
			this.lblMessage.Location = new System.Drawing.Point(3, 82);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(260, 26);
			this.lblMessage.TabIndex = 10;
			this.lblMessage.Text = "scrobbler log not found";
			this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lvTrackList
			// 
			this.lvTrackList.CheckBoxes = true;
			this.lvTrackList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.lvTrackList.FullRowSelect = true;
			this.lvTrackList.Location = new System.Drawing.Point(3, 72);
			this.lvTrackList.MinimumSize = new System.Drawing.Size(200, 200);
			this.lvTrackList.Name = "lvTrackList";
			this.lvTrackList.Size = new System.Drawing.Size(676, 248);
			this.lvTrackList.TabIndex = 14;
			this.lvTrackList.UseCompatibleStateImageBehavior = false;
			this.lvTrackList.View = System.Windows.Forms.View.Details;
			this.lvTrackList.Visible = false;
			this.lvTrackList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvTrackList_ItemChecked);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Artist";
			this.columnHeader1.Width = 150;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Track";
			this.columnHeader2.Width = 150;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Album";
			this.columnHeader3.Width = 140;
			// 
			// columnHeader4
			// 
			this.columnHeader4.DisplayIndex = 4;
			this.columnHeader4.Text = "Length";
			// 
			// columnHeader5
			// 
			this.columnHeader5.DisplayIndex = 3;
			this.columnHeader5.Text = "Played At";
			this.columnHeader5.Width = 130;
			// 
			// chkExitAfterProcessing
			// 
			this.chkExitAfterProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.chkExitAfterProcessing.BackColor = System.Drawing.Color.Transparent;
			this.chkExitAfterProcessing.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkExitAfterProcessing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.chkExitAfterProcessing.Location = new System.Drawing.Point(289, 30);
			this.chkExitAfterProcessing.Name = "chkExitAfterProcessing";
			this.chkExitAfterProcessing.Size = new System.Drawing.Size(381, 21);
			this.chkExitAfterProcessing.TabIndex = 15;
			this.chkExitAfterProcessing.Text = "Exit after processing";
			this.chkExitAfterProcessing.UseVisualStyleBackColor = false;
			// 
			// btnShowLastPosts
			// 
			this.btnShowLastPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnShowLastPosts.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShowLastPosts.Location = new System.Drawing.Point(405, 523);
			this.btnShowLastPosts.Name = "btnShowLastPosts";
			this.btnShowLastPosts.Size = new System.Drawing.Size(190, 21);
			this.btnShowLastPosts.TabIndex = 18;
			this.btnShowLastPosts.Text = "Show My Last Posts To Last.Fm";
			this.btnShowLastPosts.UseVisualStyleBackColor = true;
			this.btnShowLastPosts.Click += new System.EventHandler(this.btnShowLastPosts_Click);
			// 
			// btnSaveSettings
			// 
			this.btnSaveSettings.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveSettings.ForeColor = System.Drawing.Color.Black;
			this.btnSaveSettings.Location = new System.Drawing.Point(289, 85);
			this.btnSaveSettings.Name = "btnSaveSettings";
			this.btnSaveSettings.Size = new System.Drawing.Size(126, 21);
			this.btnSaveSettings.TabIndex = 19;
			this.btnSaveSettings.Text = "Save Settings";
			this.btnSaveSettings.UseVisualStyleBackColor = true;
			this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
			// 
			// chkCloseExits
			// 
			this.chkCloseExits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.chkCloseExits.BackColor = System.Drawing.Color.Transparent;
			this.chkCloseExits.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkCloseExits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.chkCloseExits.Location = new System.Drawing.Point(289, 57);
			this.chkCloseExits.Name = "chkCloseExits";
			this.chkCloseExits.Size = new System.Drawing.Size(381, 22);
			this.chkCloseExits.TabIndex = 21;
			this.chkCloseExits.Text = "Clicking \"Close\" exits LogScrobbler";
			this.chkCloseExits.UseVisualStyleBackColor = false;
			// 
			// chkStorePassword
			// 
			this.chkStorePassword.BackColor = System.Drawing.Color.Transparent;
			this.chkStorePassword.Checked = true;
			this.chkStorePassword.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkStorePassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkStorePassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.chkStorePassword.Location = new System.Drawing.Point(205, 30);
			this.chkStorePassword.Name = "chkStorePassword";
			this.chkStorePassword.Size = new System.Drawing.Size(58, 21);
			this.chkStorePassword.TabIndex = 24;
			this.chkStorePassword.Text = "Save";
			this.chkStorePassword.UseVisualStyleBackColor = false;
			// 
			// cbTimeZone
			// 
			this.cbTimeZone.Enabled = false;
			this.cbTimeZone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbTimeZone.FormattingEnabled = true;
			this.cbTimeZone.Items.AddRange(new object[] {
            " 0 England, Ireland, Portugal",
            "+1 Europe: France, Spain, Germany, Poland, etc.",
            "+2 Central Europe: Turkey, Greece, Finland, etc.",
            "+3 Moscow, Saudi Arabia",
            "+4 Oman",
            "+5 Pakistan",
            "+6 India",
            "+7 Indonesia",
            "+8 China, Phillipines, Malaysia, West Australia",
            "+9 Japan",
            "+10 East Australia",
            "+11 Solomon islands, Micronesia",
            "+12 Marshall Islands, Fiji",
            "-11 Samoa, Midway",
            "-10 Hawaii, French Polynesia, Cook island",
            "-9 Alaska",
            "-8 US Pacific",
            "-7 US Mountain",
            "-6 US Central",
            "-5 US Eastern",
            "-4 New Foundland, Venezuela, Chile",
            "-3 Brazil, Argentina, Greenland",
            "-2 Mid-Atlantic",
            "-1 Azores, Cape Verda Is."});
			this.cbTimeZone.Location = new System.Drawing.Point(71, 113);
			this.cbTimeZone.Name = "cbTimeZone";
			this.cbTimeZone.Size = new System.Drawing.Size(127, 21);
			this.cbTimeZone.TabIndex = 25;
			this.cbTimeZone.Text = "-8 US Pacific";
			this.cbTimeZone.Visible = false;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label5.Location = new System.Drawing.Point(3, 110);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 27);
			this.label5.TabIndex = 26;
			this.label5.Text = "Timezone:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label5.Visible = false;
			// 
			// chkFixTimestamps
			// 
			this.chkFixTimestamps.AutoSize = true;
			this.chkFixTimestamps.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkFixTimestamps.ForeColor = System.Drawing.Color.White;
			this.chkFixTimestamps.Location = new System.Drawing.Point(3, 3);
			this.chkFixTimestamps.Name = "chkFixTimestamps";
			this.chkFixTimestamps.Size = new System.Drawing.Size(99, 17);
			this.chkFixTimestamps.TabIndex = 29;
			this.chkFixTimestamps.Text = "Fix Timestamps";
			this.toolTip1.SetToolTip(this.chkFixTimestamps, resources.GetString("chkFixTimestamps.ToolTip"));
			this.chkFixTimestamps.UseVisualStyleBackColor = true;
			// 
			// gbTrackSettings
			// 
			this.gbTrackSettings.BackColor = System.Drawing.Color.Transparent;
			this.gbTrackSettings.Controls.Add(this.tableLayoutPanel1);
			this.gbTrackSettings.Controls.Add(this.lvTrackList);
			this.gbTrackSettings.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbTrackSettings.ForeColor = System.Drawing.Color.White;
			this.gbTrackSettings.Location = new System.Drawing.Point(9, 196);
			this.gbTrackSettings.Name = "gbTrackSettings";
			this.gbTrackSettings.Size = new System.Drawing.Size(682, 322);
			this.gbTrackSettings.TabIndex = 29;
			this.gbTrackSettings.TabStop = false;
			this.gbTrackSettings.Text = "Track Settings";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.rdoSelectTracksForScrobble, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.rdoScrobbleAllTracks, 0, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 48);
			this.tableLayoutPanel1.TabIndex = 32;
			// 
			// rdoSelectTracksForScrobble
			// 
			this.rdoSelectTracksForScrobble.AutoSize = true;
			this.rdoSelectTracksForScrobble.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdoSelectTracksForScrobble.ForeColor = System.Drawing.Color.White;
			this.rdoSelectTracksForScrobble.Location = new System.Drawing.Point(3, 26);
			this.rdoSelectTracksForScrobble.Name = "rdoSelectTracksForScrobble";
			this.rdoSelectTracksForScrobble.Size = new System.Drawing.Size(147, 17);
			this.rdoSelectTracksForScrobble.TabIndex = 31;
			this.rdoSelectTracksForScrobble.Text = "Select Tracks To Scrobble";
			this.rdoSelectTracksForScrobble.UseVisualStyleBackColor = true;
			this.rdoSelectTracksForScrobble.CheckedChanged += new System.EventHandler(this.rdoSelectTracksForScrobble_CheckedChanged);
			// 
			// rdoScrobbleAllTracks
			// 
			this.rdoScrobbleAllTracks.AutoSize = true;
			this.rdoScrobbleAllTracks.Checked = true;
			this.rdoScrobbleAllTracks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdoScrobbleAllTracks.ForeColor = System.Drawing.Color.White;
			this.rdoScrobbleAllTracks.Location = new System.Drawing.Point(3, 3);
			this.rdoScrobbleAllTracks.Name = "rdoScrobbleAllTracks";
			this.rdoScrobbleAllTracks.Size = new System.Drawing.Size(146, 17);
			this.rdoScrobbleAllTracks.TabIndex = 30;
			this.rdoScrobbleAllTracks.TabStop = true;
			this.rdoScrobbleAllTracks.Text = "Scrobble All Tracks, or ...";
			this.rdoScrobbleAllTracks.UseVisualStyleBackColor = true;
			this.rdoScrobbleAllTracks.CheckedChanged += new System.EventHandler(this.rdoScrobbleAllTracks_CheckedChanged);
			// 
			// gbScrobblerSettings
			// 
			this.gbScrobblerSettings.BackColor = System.Drawing.Color.Transparent;
			this.gbScrobblerSettings.Controls.Add(this.tableLayoutPanel3);
			this.gbScrobblerSettings.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbScrobblerSettings.ForeColor = System.Drawing.Color.White;
			this.gbScrobblerSettings.Location = new System.Drawing.Point(9, 142);
			this.gbScrobblerSettings.Name = "gbScrobblerSettings";
			this.gbScrobblerSettings.Size = new System.Drawing.Size(682, 48);
			this.gbScrobblerSettings.TabIndex = 30;
			this.gbScrobblerSettings.TabStop = false;
			this.gbScrobblerSettings.Text = "Scrobbler Settings";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.chkFixTimestamps, 0, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 19);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(670, 24);
			this.tableLayoutPanel3.TabIndex = 30;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 550);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(703, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 31;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(486, 17);
			this.toolStripStatusLabel1.Spring = true;
			this.toolStripStatusLabel1.Text = "Ready";
			this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanel2.ColumnCount = 5;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 387F));
			this.tableLayoutPanel2.Controls.Add(this.txtUsername, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.chkDeleteAfterUpload, 4, 0);
			this.tableLayoutPanel2.Controls.Add(this.chkExitAfterProcessing, 4, 1);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.txtFilename, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.chkStorePassword, 2, 1);
			this.tableLayoutPanel2.Controls.Add(this.chkCloseExits, 4, 2);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.txtPassword, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.btnBrowseForFile, 2, 2);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnSaveSettings, 4, 3);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.cbTimeZone, 1, 4);
			this.tableLayoutPanel2.Controls.Add(this.lblMessage, 0, 3);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 5;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(673, 140);
			this.tableLayoutPanel2.TabIndex = 32;
			// 
			// gbUserSettings
			// 
			this.gbUserSettings.BackColor = System.Drawing.Color.Transparent;
			this.gbUserSettings.Controls.Add(this.tableLayoutPanel2);
			this.gbUserSettings.ForeColor = System.Drawing.Color.White;
			this.gbUserSettings.Location = new System.Drawing.Point(9, 2);
			this.gbUserSettings.Name = "gbUserSettings";
			this.gbUserSettings.Size = new System.Drawing.Size(682, 134);
			this.gbUserSettings.TabIndex = 33;
			this.gbUserSettings.TabStop = false;
			this.gbUserSettings.Text = "User Settings";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.BackgroundImage = global::LogScrobbler.Properties.Resources.bg;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(703, 572);
			this.Controls.Add(this.btnShowLastPosts);
			this.Controls.Add(this.lnkLastFmUrl);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.gbScrobblerSettings);
			this.Controls.Add(this.btnDoUpload);
			this.Controls.Add(this.gbTrackSettings);
			this.Controls.Add(this.gbUserSettings);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "LogScrobbler ";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainForm_HelpButtonClicked);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.gbTrackSettings.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.gbScrobblerSettings.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.gbUserSettings.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbTimeZone;
		private System.Windows.Forms.CheckBox chkStorePassword;
		private System.Windows.Forms.CheckBox chkCloseExits;
		private System.Windows.Forms.Button btnSaveSettings;
		private System.Windows.Forms.Button btnShowLastPosts;
		private System.Windows.Forms.CheckBox chkExitAfterProcessing;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lvTrackList;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.CheckBox chkDeleteAfterUpload;
		private System.Windows.Forms.LinkLabel lnkLastFmUrl;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBrowseForFile;
		private System.Windows.Forms.TextBox txtFilename;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDoUpload;
		private System.Windows.Forms.GroupBox gbTrackSettings;
		private System.Windows.Forms.CheckBox chkFixTimestamps;
		private System.Windows.Forms.RadioButton rdoSelectTracksForScrobble;
		private System.Windows.Forms.RadioButton rdoScrobbleAllTracks;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox gbScrobblerSettings;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.GroupBox gbUserSettings;
	}
}
