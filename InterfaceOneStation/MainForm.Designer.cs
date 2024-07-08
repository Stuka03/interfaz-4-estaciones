/*
 * Created by SharpDevelop.
 * User: Efrain
 * Date: 02/03/2017
 * Time: 09:30 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace InterfaceOneStation
{
	partial class MainForm
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
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBoxUnclamp1 = new System.Windows.Forms.PictureBox();
			this.pictureBoxAncla1 = new System.Windows.Forms.PictureBox();
			this.pictureBoxMove2 = new System.Windows.Forms.PictureBox();
			this.labelMaster1 = new System.Windows.Forms.Label();
			this.pictureBoxAncla2 = new System.Windows.Forms.PictureBox();
			this.labelMaster2Clamp = new System.Windows.Forms.Label();
			this.pictureBoxClamp2 = new System.Windows.Forms.PictureBox();
			this.pictureBoxMove1 = new System.Windows.Forms.PictureBox();
			this.labelMaster2 = new System.Windows.Forms.Label();
			this.pictureBoxClamp1 = new System.Windows.Forms.PictureBox();
			this.pictureBoxUnclamp2 = new System.Windows.Forms.PictureBox();
			this.labelMaster1Clamp = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnclamp1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAncla1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMove2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAncla2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClamp2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMove1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClamp1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnclamp2)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer3
			// 
			this.timer3.Enabled = true;
			this.timer3.Interval = 1000;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.tabPage2.Controls.Add(this.listBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage2.Size = new System.Drawing.Size(317, 114);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "INFO";
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 9;
			this.listBox1.Items.AddRange(new object[] {
            "SoftOpCon 4 Stations \trev.1.0.0 4S",
            "",
            "CONFIGURACION DE SENALES:",
            "1.- CLAMP 1 - AUXILIAR FUNCTION 2",
            "2.- CLAMP 2 - AUXILIAR FUNCTION 3",
            "3.- LOCK TRANSVERSE 1 - AUXILIAR FUNCTION 6",
            "4.- LOCK TRANSVERSE 2 - AUXILIAR FUNCTION 7",
            "5.- PRESSURE SENSOR - AUXILIAR FUNCTION 8",
            "6.- ERROR RELEASE - FAST STOP",
            "7.- PROGRAM RUNNING - AUXILIAR FUNCTION 9"});
			this.listBox1.Location = new System.Drawing.Point(5, 10);
			this.listBox1.Margin = new System.Windows.Forms.Padding(2);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(310, 94);
			this.listBox1.TabIndex = 40;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage1.Size = new System.Drawing.Size(317, 114);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "TRANSVERSAL";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelMaster1Clamp);
			this.groupBox1.Controls.Add(this.pictureBoxUnclamp2);
			this.groupBox1.Controls.Add(this.pictureBoxClamp1);
			this.groupBox1.Controls.Add(this.labelMaster2);
			this.groupBox1.Controls.Add(this.pictureBoxMove1);
			this.groupBox1.Controls.Add(this.pictureBoxClamp2);
			this.groupBox1.Controls.Add(this.labelMaster2Clamp);
			this.groupBox1.Controls.Add(this.pictureBoxAncla2);
			this.groupBox1.Controls.Add(this.labelMaster1);
			this.groupBox1.Controls.Add(this.pictureBoxMove2);
			this.groupBox1.Controls.Add(this.pictureBoxAncla1);
			this.groupBox1.Controls.Add(this.pictureBoxUnclamp1);
			this.groupBox1.Location = new System.Drawing.Point(4, -13);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(310, 129);
			this.groupBox1.TabIndex = 49;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// pictureBoxUnclamp1
			// 
			this.pictureBoxUnclamp1.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.pictureBoxUnclamp1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUnclamp1.Image")));
			this.pictureBoxUnclamp1.Location = new System.Drawing.Point(18, 33);
			this.pictureBoxUnclamp1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBoxUnclamp1.Name = "pictureBoxUnclamp1";
			this.pictureBoxUnclamp1.Size = new System.Drawing.Size(49, 67);
			this.pictureBoxUnclamp1.TabIndex = 47;
			this.pictureBoxUnclamp1.TabStop = false;
			this.pictureBoxUnclamp1.Visible = false;
			this.pictureBoxUnclamp1.Click += new System.EventHandler(this.pictureBoxUnclamp1_Click);
			// 
			// pictureBoxAncla1
			// 
			this.pictureBoxAncla1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAncla1.Image")));
			this.pictureBoxAncla1.Location = new System.Drawing.Point(93, 33);
			this.pictureBoxAncla1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBoxAncla1.Name = "pictureBoxAncla1";
			this.pictureBoxAncla1.Size = new System.Drawing.Size(49, 67);
			this.pictureBoxAncla1.TabIndex = 42;
			this.pictureBoxAncla1.TabStop = false;
			this.pictureBoxAncla1.Visible = false;
			this.pictureBoxAncla1.Click += new System.EventHandler(this.pictureBoxAncla_Click);
			// 
			// pictureBoxMove2
			// 
			this.pictureBoxMove2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMove2.Image")));
			this.pictureBoxMove2.Location = new System.Drawing.Point(168, 33);
			this.pictureBoxMove2.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBoxMove2.Name = "pictureBoxMove2";
			this.pictureBoxMove2.Size = new System.Drawing.Size(49, 67);
			this.pictureBoxMove2.TabIndex = 44;
			this.pictureBoxMove2.TabStop = false;
			this.pictureBoxMove2.Click += new System.EventHandler(this.pictureBoxMove2_Click);
			// 
			// labelMaster1
			// 
			this.labelMaster1.AutoSize = true;
			this.labelMaster1.Location = new System.Drawing.Point(101, 102);
			this.labelMaster1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelMaster1.Name = "labelMaster1";
			this.labelMaster1.Size = new System.Drawing.Size(28, 13);
			this.labelMaster1.TabIndex = 46;
			this.labelMaster1.Text = "Free";
			// 
			// pictureBoxAncla2
			// 
			this.pictureBoxAncla2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAncla2.Image")));
			this.pictureBoxAncla2.Location = new System.Drawing.Point(168, 33);
			this.pictureBoxAncla2.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBoxAncla2.Name = "pictureBoxAncla2";
			this.pictureBoxAncla2.Size = new System.Drawing.Size(49, 67);
			this.pictureBoxAncla2.TabIndex = 45;
			this.pictureBoxAncla2.TabStop = false;
			this.pictureBoxAncla2.Visible = false;
			this.pictureBoxAncla2.Click += new System.EventHandler(this.pictureBoxAncla2_Click);
			// 
			// labelMaster2Clamp
			// 
			this.labelMaster2Clamp.AutoSize = true;
			this.labelMaster2Clamp.Location = new System.Drawing.Point(241, 102);
			this.labelMaster2Clamp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelMaster2Clamp.Name = "labelMaster2Clamp";
			this.labelMaster2Clamp.Size = new System.Drawing.Size(48, 13);
			this.labelMaster2Clamp.TabIndex = 41;
			this.labelMaster2Clamp.Text = "Clamped";
			// 
			// pictureBoxClamp2
			// 
			this.pictureBoxClamp2.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.pictureBoxClamp2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClamp2.Image")));
			this.pictureBoxClamp2.Location = new System.Drawing.Point(243, 33);
			this.pictureBoxClamp2.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBoxClamp2.Name = "pictureBoxClamp2";
			this.pictureBoxClamp2.Size = new System.Drawing.Size(49, 67);
			this.pictureBoxClamp2.TabIndex = 38;
			this.pictureBoxClamp2.TabStop = false;
			this.pictureBoxClamp2.Click += new System.EventHandler(this.pictureBoxClamp2_Click);
			// 
			// pictureBoxMove1
			// 
			this.pictureBoxMove1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMove1.Image")));
			this.pictureBoxMove1.Location = new System.Drawing.Point(93, 33);
			this.pictureBoxMove1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBoxMove1.Name = "pictureBoxMove1";
			this.pictureBoxMove1.Size = new System.Drawing.Size(49, 67);
			this.pictureBoxMove1.TabIndex = 43;
			this.pictureBoxMove1.TabStop = false;
			this.pictureBoxMove1.Click += new System.EventHandler(this.pictureBoxMove_Click);
			// 
			// labelMaster2
			// 
			this.labelMaster2.AutoSize = true;
			this.labelMaster2.Location = new System.Drawing.Point(175, 102);
			this.labelMaster2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelMaster2.Name = "labelMaster2";
			this.labelMaster2.Size = new System.Drawing.Size(28, 13);
			this.labelMaster2.TabIndex = 47;
			this.labelMaster2.Text = "Free";
			// 
			// pictureBoxClamp1
			// 
			this.pictureBoxClamp1.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.pictureBoxClamp1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClamp1.Image")));
			this.pictureBoxClamp1.Location = new System.Drawing.Point(18, 33);
			this.pictureBoxClamp1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBoxClamp1.Name = "pictureBoxClamp1";
			this.pictureBoxClamp1.Size = new System.Drawing.Size(49, 67);
			this.pictureBoxClamp1.TabIndex = 39;
			this.pictureBoxClamp1.TabStop = false;
			this.pictureBoxClamp1.Click += new System.EventHandler(this.pictureBoxClamp1_Click);
			// 
			// pictureBoxUnclamp2
			// 
			this.pictureBoxUnclamp2.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.pictureBoxUnclamp2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUnclamp2.Image")));
			this.pictureBoxUnclamp2.Location = new System.Drawing.Point(243, 33);
			this.pictureBoxUnclamp2.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBoxUnclamp2.Name = "pictureBoxUnclamp2";
			this.pictureBoxUnclamp2.Size = new System.Drawing.Size(49, 67);
			this.pictureBoxUnclamp2.TabIndex = 48;
			this.pictureBoxUnclamp2.TabStop = false;
			this.pictureBoxUnclamp2.Visible = false;
			this.pictureBoxUnclamp2.Click += new System.EventHandler(this.pictureBoxUnclamp2_Click);
			// 
			// labelMaster1Clamp
			// 
			this.labelMaster1Clamp.AutoSize = true;
			this.labelMaster1Clamp.Location = new System.Drawing.Point(16, 102);
			this.labelMaster1Clamp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelMaster1Clamp.Name = "labelMaster1Clamp";
			this.labelMaster1Clamp.Size = new System.Drawing.Size(48, 13);
			this.labelMaster1Clamp.TabIndex = 40;
			this.labelMaster1Clamp.Text = "Clamped";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(8, 3);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(325, 140);
			this.tabControl1.TabIndex = 15;
			// 
			// MainForm
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.ClientSize = new System.Drawing.Size(342, 146);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(1025, 410);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "INTERFACE VIRTUAL";
			this.TopMost = true;
			this.tabPage2.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnclamp1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAncla1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMove2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAncla2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClamp2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMove1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClamp1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnclamp2)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}


        private void MainForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label labelMaster1Clamp;
		private System.Windows.Forms.PictureBox pictureBoxUnclamp2;
		private System.Windows.Forms.PictureBox pictureBoxClamp1;
		private System.Windows.Forms.Label labelMaster2;
		private System.Windows.Forms.PictureBox pictureBoxMove1;
		private System.Windows.Forms.PictureBox pictureBoxClamp2;
		private System.Windows.Forms.Label labelMaster2Clamp;
		private System.Windows.Forms.PictureBox pictureBoxAncla2;
		private System.Windows.Forms.Label labelMaster1;
		private System.Windows.Forms.PictureBox pictureBoxMove2;
		private System.Windows.Forms.PictureBox pictureBoxAncla1;
		private System.Windows.Forms.PictureBox pictureBoxUnclamp1;
		private System.Windows.Forms.TabControl tabControl1;
	}
}
