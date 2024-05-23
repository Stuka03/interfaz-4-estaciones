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
            this.labelMaster2 = new System.Windows.Forms.Label();
            this.labelMaster1 = new System.Windows.Forms.Label();
            this.labelMaster1Clamp = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxClamp1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMove1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAncla2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMove2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAncla1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxUnclamp1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonLSTest = new System.Windows.Forms.Button();
            this.radioButtonLSAactive = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxEnableLubrication = new System.Windows.Forms.CheckBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxLubricationActive = new System.Windows.Forms.DomainUpDown();
            this.comboBoxLubricationInterval = new System.Windows.Forms.DomainUpDown();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.TIEMPOS = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Etiqueta1Funcionamiento = new System.Windows.Forms.Label();
            this.LFuncionamiento = new System.Windows.Forms.Label();
            this.EtiquetaMovimiento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EtiquetaCorte = new System.Windows.Forms.Label();
            this.tiempoCorte = new System.Windows.Forms.Label();
            this.EtiquetaLubricacion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClamp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMove1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAncla2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMove2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAncla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnclamp1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.TIEMPOS.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMaster2
            // 
            this.labelMaster2.AutoSize = true;
            this.labelMaster2.Location = new System.Drawing.Point(234, 102);
            this.labelMaster2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaster2.Name = "labelMaster2";
            this.labelMaster2.Size = new System.Drawing.Size(28, 13);
            this.labelMaster2.TabIndex = 47;
            this.labelMaster2.Text = "Free";
            // 
            // labelMaster1
            // 
            this.labelMaster1.AutoSize = true;
            this.labelMaster1.Location = new System.Drawing.Point(144, 102);
            this.labelMaster1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaster1.Name = "labelMaster1";
            this.labelMaster1.Size = new System.Drawing.Size(28, 13);
            this.labelMaster1.TabIndex = 46;
            this.labelMaster1.Text = "Free";
            // 
            // labelMaster1Clamp
            // 
            this.labelMaster1Clamp.AutoSize = true;
            this.labelMaster1Clamp.Location = new System.Drawing.Point(36, 102);
            this.labelMaster1Clamp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaster1Clamp.Name = "labelMaster1Clamp";
            this.labelMaster1Clamp.Size = new System.Drawing.Size(48, 13);
            this.labelMaster1Clamp.TabIndex = 40;
            this.labelMaster1Clamp.Text = "Clamped";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.TIEMPOS);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(325, 140);
            this.tabControl1.TabIndex = 15;
            this.tabControl1.Enter += new System.EventHandler(this.buttonEnter_Click_1);
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
            this.groupBox1.Controls.Add(this.pictureBoxClamp1);
            this.groupBox1.Controls.Add(this.labelMaster2);
            this.groupBox1.Controls.Add(this.pictureBoxMove1);
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
            // pictureBoxClamp1
            // 
            this.pictureBoxClamp1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBoxClamp1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClamp1.Image")));
            this.pictureBoxClamp1.Location = new System.Drawing.Point(39, 33);
            this.pictureBoxClamp1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxClamp1.Name = "pictureBoxClamp1";
            this.pictureBoxClamp1.Size = new System.Drawing.Size(49, 67);
            this.pictureBoxClamp1.TabIndex = 39;
            this.pictureBoxClamp1.TabStop = false;
            this.pictureBoxClamp1.Click += new System.EventHandler(this.pictureBoxClamp1_Click);
            // 
            // pictureBoxMove1
            // 
            this.pictureBoxMove1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMove1.Image")));
            this.pictureBoxMove1.Location = new System.Drawing.Point(136, 33);
            this.pictureBoxMove1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMove1.Name = "pictureBoxMove1";
            this.pictureBoxMove1.Size = new System.Drawing.Size(49, 67);
            this.pictureBoxMove1.TabIndex = 43;
            this.pictureBoxMove1.TabStop = false;
            this.pictureBoxMove1.Click += new System.EventHandler(this.pictureBoxMove_Click);
            // 
            // pictureBoxAncla2
            // 
            this.pictureBoxAncla2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAncla2.Image")));
            this.pictureBoxAncla2.Location = new System.Drawing.Point(227, 33);
            this.pictureBoxAncla2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxAncla2.Name = "pictureBoxAncla2";
            this.pictureBoxAncla2.Size = new System.Drawing.Size(49, 67);
            this.pictureBoxAncla2.TabIndex = 45;
            this.pictureBoxAncla2.TabStop = false;
            this.pictureBoxAncla2.Visible = false;
            this.pictureBoxAncla2.Click += new System.EventHandler(this.pictureBoxAncla2_Click);
            // 
            // pictureBoxMove2
            // 
            this.pictureBoxMove2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMove2.Image")));
            this.pictureBoxMove2.Location = new System.Drawing.Point(227, 33);
            this.pictureBoxMove2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMove2.Name = "pictureBoxMove2";
            this.pictureBoxMove2.Size = new System.Drawing.Size(49, 67);
            this.pictureBoxMove2.TabIndex = 44;
            this.pictureBoxMove2.TabStop = false;
            this.pictureBoxMove2.Click += new System.EventHandler(this.pictureBoxMove2_Click);
            // 
            // pictureBoxAncla1
            // 
            this.pictureBoxAncla1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAncla1.Image")));
            this.pictureBoxAncla1.Location = new System.Drawing.Point(136, 33);
            this.pictureBoxAncla1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxAncla1.Name = "pictureBoxAncla1";
            this.pictureBoxAncla1.Size = new System.Drawing.Size(49, 67);
            this.pictureBoxAncla1.TabIndex = 42;
            this.pictureBoxAncla1.TabStop = false;
            this.pictureBoxAncla1.Visible = false;
            this.pictureBoxAncla1.Click += new System.EventHandler(this.pictureBoxAncla_Click);
            // 
            // pictureBoxUnclamp1
            // 
            this.pictureBoxUnclamp1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBoxUnclamp1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUnclamp1.Image")));
            this.pictureBoxUnclamp1.Location = new System.Drawing.Point(39, 33);
            this.pictureBoxUnclamp1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxUnclamp1.Name = "pictureBoxUnclamp1";
            this.pictureBoxUnclamp1.Size = new System.Drawing.Size(49, 67);
            this.pictureBoxUnclamp1.TabIndex = 47;
            this.pictureBoxUnclamp1.TabStop = false;
            this.pictureBoxUnclamp1.Visible = false;
            this.pictureBoxUnclamp1.Click += new System.EventHandler(this.pictureBoxUnclamp1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabPage3.Controls.Add(this.buttonLSTest);
            this.tabPage3.Controls.Add(this.radioButtonLSAactive);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.checkBoxEnableLubrication);
            this.tabPage3.Controls.Add(this.labelTime);
            this.tabPage3.Controls.Add(this.buttonSave);
            this.tabPage3.Controls.Add(this.comboBoxLubricationActive);
            this.tabPage3.Controls.Add(this.comboBoxLubricationInterval);
            this.tabPage3.Controls.Add(this.buttonEnter);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.textBoxPassword);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(317, 114);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CONFIGURACION";
            this.tabPage3.Enter += new System.EventHandler(this.buttonEnter_Click_1);
            // 
            // buttonLSTest
            // 
            this.buttonLSTest.Enabled = false;
            this.buttonLSTest.Location = new System.Drawing.Point(226, 80);
            this.buttonLSTest.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLSTest.Name = "buttonLSTest";
            this.buttonLSTest.Size = new System.Drawing.Size(63, 19);
            this.buttonLSTest.TabIndex = 17;
            this.buttonLSTest.Text = "Test Mode";
            this.buttonLSTest.UseVisualStyleBackColor = true;
            this.buttonLSTest.Click += new System.EventHandler(this.buttonLSTest_Click);
            // 
            // radioButtonLSAactive
            // 
            this.radioButtonLSAactive.AutoSize = true;
            this.radioButtonLSAactive.Enabled = false;
            this.radioButtonLSAactive.Location = new System.Drawing.Point(226, 50);
            this.radioButtonLSAactive.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonLSAactive.Name = "radioButtonLSAactive";
            this.radioButtonLSAactive.Size = new System.Drawing.Size(71, 17);
            this.radioButtonLSAactive.TabIndex = 14;
            this.radioButtonLSAactive.TabStop = true;
            this.radioButtonLSAactive.Text = "LS Active";
            this.radioButtonLSAactive.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pumping Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Interval Time:";
            // 
            // checkBoxEnableLubrication
            // 
            this.checkBoxEnableLubrication.AutoSize = true;
            this.checkBoxEnableLubrication.Enabled = false;
            this.checkBoxEnableLubrication.Location = new System.Drawing.Point(4, 28);
            this.checkBoxEnableLubrication.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableLubrication.Name = "checkBoxEnableLubrication";
            this.checkBoxEnableLubrication.Size = new System.Drawing.Size(114, 17);
            this.checkBoxEnableLubrication.TabIndex = 9;
            this.checkBoxEnableLubrication.Text = "Enable Lubrication";
            this.checkBoxEnableLubrication.UseVisualStyleBackColor = true;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(238, 31);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(30, 13);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "Time";
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(261, 4);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(49, 19);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // comboBoxLubricationActive
            // 
            this.comboBoxLubricationActive.Enabled = false;
            this.comboBoxLubricationActive.Items.Add("5 s");
            this.comboBoxLubricationActive.Items.Add("10 s");
            this.comboBoxLubricationActive.Items.Add("15 s");
            this.comboBoxLubricationActive.Items.Add("20 s");
            this.comboBoxLubricationActive.Items.Add("25 s");
            this.comboBoxLubricationActive.Items.Add("30 s");
            this.comboBoxLubricationActive.Location = new System.Drawing.Point(82, 69);
            this.comboBoxLubricationActive.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLubricationActive.Name = "comboBoxLubricationActive";
            this.comboBoxLubricationActive.Size = new System.Drawing.Size(119, 20);
            this.comboBoxLubricationActive.TabIndex = 4;
            this.comboBoxLubricationActive.Text = "Time active";
            // 
            // comboBoxLubricationInterval
            // 
            this.comboBoxLubricationInterval.Enabled = false;
            this.comboBoxLubricationInterval.Items.Add("1 hr");
            this.comboBoxLubricationInterval.Items.Add("2 hr");
            this.comboBoxLubricationInterval.Items.Add("3 hr");
            this.comboBoxLubricationInterval.Items.Add("4 hr");
            this.comboBoxLubricationInterval.Items.Add("5 hr");
            this.comboBoxLubricationInterval.Items.Add("6 hr");
            this.comboBoxLubricationInterval.Items.Add("7 hr");
            this.comboBoxLubricationInterval.Items.Add("8 hr");
            this.comboBoxLubricationInterval.Items.Add("9 hr");
            this.comboBoxLubricationInterval.Items.Add("10 hr");
            this.comboBoxLubricationInterval.Items.Add("11 hr");
            this.comboBoxLubricationInterval.Items.Add("12 hr");
            this.comboBoxLubricationInterval.Location = new System.Drawing.Point(82, 46);
            this.comboBoxLubricationInterval.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLubricationInterval.Name = "comboBoxLubricationInterval";
            this.comboBoxLubricationInterval.Size = new System.Drawing.Size(119, 20);
            this.comboBoxLubricationInterval.TabIndex = 3;
            this.comboBoxLubricationInterval.Text = "Lubrication interval";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(208, 4);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(49, 19);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "ENTER";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PASSWORD:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(82, 4);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(120, 20);
            this.textBoxPassword.TabIndex = 0;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
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
            "SoftOpCon 3 Stations & Lubrication system\tRev.0.8.4-3sp1L",
            "",
            "CONFIGURACION DE SENALES:",
            "1.- LUBRICATION SYSTEM - AUXILIAR FUNCTION 1",
            "2.- CLAMP 1 - AUXILIAR FUNCTION 2",
            "3.- LOCK TRANSVERSE 1 - AUXILIAR FUNCTION 6",
            "4.- LOCK TRANSVERSE 2 - AUXILIAR FUNCTION 7",
            "5.- PRESSURE SENSOR - AUXILIAR FUNCTION 8",
            "6.- ERROR RELEASE - FAST STOP",
            "7.- PROGRAM RUNNING - AUXILIAR FUNCTION 9",
            "8.- MOTION INDICAITOR"});
            this.listBox1.Location = new System.Drawing.Point(5, 10);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 94);
            this.listBox1.TabIndex = 40;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            // 
            // TIEMPOS
            // 
            this.TIEMPOS.Controls.Add(this.groupBox2);
            this.TIEMPOS.Location = new System.Drawing.Point(4, 22);
            this.TIEMPOS.Name = "TIEMPOS";
            this.TIEMPOS.Size = new System.Drawing.Size(317, 114);
            this.TIEMPOS.TabIndex = 3;
            this.TIEMPOS.Text = "TIEMPO";
            this.TIEMPOS.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EtiquetaLubricacion);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.EtiquetaCorte);
            this.groupBox2.Controls.Add(this.tiempoCorte);
            this.groupBox2.Controls.Add(this.EtiquetaMovimiento);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Etiqueta1Funcionamiento);
            this.groupBox2.Controls.Add(this.LFuncionamiento);
            this.groupBox2.Location = new System.Drawing.Point(-4, -13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 127);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Etiqueta1Funcionamiento
            // 
            this.Etiqueta1Funcionamiento.AutoSize = true;
            this.Etiqueta1Funcionamiento.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta1Funcionamiento.Location = new System.Drawing.Point(230, 16);
            this.Etiqueta1Funcionamiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Etiqueta1Funcionamiento.Name = "Etiqueta1Funcionamiento";
            this.Etiqueta1Funcionamiento.Size = new System.Drawing.Size(88, 23);
            this.Etiqueta1Funcionamiento.TabIndex = 12;
            this.Etiqueta1Funcionamiento.Text = "00:00:00";
            // 
            // LFuncionamiento
            // 
            this.LFuncionamiento.AutoSize = true;
            this.LFuncionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFuncionamiento.Location = new System.Drawing.Point(6, 16);
            this.LFuncionamiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFuncionamiento.Name = "LFuncionamiento";
            this.LFuncionamiento.Size = new System.Drawing.Size(225, 20);
            this.LFuncionamiento.TabIndex = 11;
            this.LFuncionamiento.Text = "Tiempo de funcionamiento:";
            // 
            // EtiquetaMovimiento
            // 
            this.EtiquetaMovimiento.AutoSize = true;
            this.EtiquetaMovimiento.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaMovimiento.Location = new System.Drawing.Point(230, 47);
            this.EtiquetaMovimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EtiquetaMovimiento.Name = "EtiquetaMovimiento";
            this.EtiquetaMovimiento.Size = new System.Drawing.Size(88, 23);
            this.EtiquetaMovimiento.TabIndex = 14;
            this.EtiquetaMovimiento.Text = "00:00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tiempo de movimiento:";
            // 
            // EtiquetaCorte
            // 
            this.EtiquetaCorte.AutoSize = true;
            this.EtiquetaCorte.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaCorte.Location = new System.Drawing.Point(230, 76);
            this.EtiquetaCorte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EtiquetaCorte.Name = "EtiquetaCorte";
            this.EtiquetaCorte.Size = new System.Drawing.Size(88, 23);
            this.EtiquetaCorte.TabIndex = 16;
            this.EtiquetaCorte.Text = "00:00:00";
            // 
            // tiempoCorte
            // 
            this.tiempoCorte.AutoSize = true;
            this.tiempoCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempoCorte.Location = new System.Drawing.Point(6, 76);
            this.tiempoCorte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tiempoCorte.Name = "tiempoCorte";
            this.tiempoCorte.Size = new System.Drawing.Size(146, 20);
            this.tiempoCorte.TabIndex = 15;
            this.tiempoCorte.Text = "Tiempo de Corte:";
            // 
            // EtiquetaLubricacion
            // 
            this.EtiquetaLubricacion.AutoSize = true;
            this.EtiquetaLubricacion.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaLubricacion.Location = new System.Drawing.Point(229, 104);
            this.EtiquetaLubricacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EtiquetaLubricacion.Name = "EtiquetaLubricacion";
            this.EtiquetaLubricacion.Size = new System.Drawing.Size(88, 23);
            this.EtiquetaLubricacion.TabIndex = 18;
            this.EtiquetaLubricacion.Text = "00:00:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tiempo de lubricacion:";
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClamp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMove1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAncla2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMove2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAncla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnclamp1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.TIEMPOS.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}


        private void MainForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxClamp1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DomainUpDown comboBoxLubricationActive;
        private System.Windows.Forms.DomainUpDown comboBoxLubricationInterval;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelMaster1Clamp;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBoxAncla1;
        private System.Windows.Forms.PictureBox pictureBoxMove1;
        private System.Windows.Forms.PictureBox pictureBoxMove2;
        private System.Windows.Forms.PictureBox pictureBoxAncla2;
        private System.Windows.Forms.Label labelMaster1;
        private System.Windows.Forms.Label labelMaster2;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.CheckBox checkBoxEnableLubrication;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxUnclamp1;
        private System.Windows.Forms.RadioButton radioButtonLSAactive;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLSTest;
        private System.Windows.Forms.TabPage TIEMPOS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label EtiquetaLubricacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label EtiquetaCorte;
        private System.Windows.Forms.Label tiempoCorte;
        private System.Windows.Forms.Label EtiquetaMovimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Etiqueta1Funcionamiento;
        private System.Windows.Forms.Label LFuncionamiento;
        private System.Windows.Forms.Timer timer4;
    }
}
