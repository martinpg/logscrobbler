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
	partial class Form1 : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.label4 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(290, 183);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(55, 21);
			this.button1.TabIndex = 0;
			this.button1.Text = "Go!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(5, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "File:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(61, 66);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(152, 21);
			this.textBox1.TabIndex = 2;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(219, 67);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(54, 21);
			this.button2.TabIndex = 3;
			this.button2.Text = "Browse";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(5, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Username:";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(5, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Password:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(61, 12);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(212, 21);
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "kernelsandirs";
			this.textBox2.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox2KeyDown);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(61, 39);
			this.textBox3.Name = "textBox3";
			this.textBox3.PasswordChar = '*';
			this.textBox3.Size = new System.Drawing.Size(152, 21);
			this.textBox3.TabIndex = 7;
			this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox3KeyDown);
			// 
			// linkLabel1
			// 
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.LinkColor = System.Drawing.Color.Gainsboro;
			this.linkLabel1.Location = new System.Drawing.Point(12, 162);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(333, 21);
			this.linkLabel1.TabIndex = 8;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "http://www.last.fm/user/kernelsandirs";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// checkBox1
			// 
			this.checkBox1.BackColor = System.Drawing.Color.Transparent;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.checkBox1.Location = new System.Drawing.Point(61, 88);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(209, 24);
			this.checkBox1.TabIndex = 9;
			this.checkBox1.Text = "Delete log after upload.";
			this.checkBox1.UseVisualStyleBackColor = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "Scrobbler Log (.scrobbler.log)|.scrobbler*.*log";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1FileOk);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.ForeColor = System.Drawing.Color.Yellow;
			this.label4.Location = new System.Drawing.Point(47, 187);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(119, 20);
			this.label4.TabIndex = 10;
			this.label4.Text = "scrobbler log not found";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(172, 183);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(112, 21);
			this.button3.TabIndex = 11;
			this.button3.Text = "Select Tracks";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.AliceBlue;
			this.button4.Location = new System.Drawing.Point(614, 239);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(18, 20);
			this.button4.TabIndex = 13;
			this.button4.Text = "x";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// listView1
			// 
			this.listView1.CheckBoxes = true;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.listView1.FullRowSelect = true;
			this.listView1.Location = new System.Drawing.Point(0, -35);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(359, 303);
			this.listView1.TabIndex = 14;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.Visible = false;
			this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListView1ItemChecked);
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
			// checkBox2
			// 
			this.checkBox2.BackColor = System.Drawing.Color.Transparent;
			this.checkBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.checkBox2.Location = new System.Drawing.Point(61, 105);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(209, 24);
			this.checkBox2.TabIndex = 15;
			this.checkBox2.Text = "Exit after processing";
			this.checkBox2.UseVisualStyleBackColor = false;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(10, 210);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(335, 23);
			this.progressBar1.TabIndex = 16;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(202, 239);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(143, 23);
			this.button5.TabIndex = 17;
			this.button5.Text = "Shift After Last Played";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(10, 239);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(186, 23);
			this.button6.TabIndex = 18;
			this.button6.Text = "Show My Last Posts To Last.Fm";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(219, 94);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(126, 23);
			this.button7.TabIndex = 19;
			this.button7.Text = "Save Settings";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button8
			// 
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.ForeColor = System.Drawing.Color.Gray;
			this.button8.Location = new System.Drawing.Point(334, 12);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(21, 32);
			this.button8.TabIndex = 20;
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// checkBox3
			// 
			this.checkBox3.BackColor = System.Drawing.Color.Transparent;
			this.checkBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.checkBox3.Location = new System.Drawing.Point(61, 123);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(209, 24);
			this.checkBox3.TabIndex = 21;
			this.checkBox3.Text = "Clicking \"Close\" exits LogScrobbler";
			this.checkBox3.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Location = new System.Drawing.Point(279, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(49, 70);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 22;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// checkBox4
			// 
			this.checkBox4.BackColor = System.Drawing.Color.Transparent;
			this.checkBox4.Checked = true;
			this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.checkBox4.Location = new System.Drawing.Point(61, 140);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(186, 24);
			this.checkBox4.TabIndex = 23;
			this.checkBox4.Text = "Show my last.fm avatar";
			this.checkBox4.UseVisualStyleBackColor = false;
			// 
			// checkBox5
			// 
			this.checkBox5.BackColor = System.Drawing.Color.Transparent;
			this.checkBox5.Checked = true;
			this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.checkBox5.Location = new System.Drawing.Point(219, 37);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(54, 24);
			this.checkBox5.TabIndex = 24;
			this.checkBox5.Text = "Save";
			this.checkBox5.UseVisualStyleBackColor = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(359, 268);
			this.Controls.Add(this.checkBox5);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.checkBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "LogScrobbler 0.12b";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1FormClosed);
			this.Load += new System.EventHandler(this.Form1Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}
