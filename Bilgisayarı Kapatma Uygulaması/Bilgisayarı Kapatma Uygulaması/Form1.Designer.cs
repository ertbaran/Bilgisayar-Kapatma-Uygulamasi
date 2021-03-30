namespace Bilgisayarı_Kapatma_Uygulaması
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_SetTimer = new System.Windows.Forms.Button();
            this.textBoxFromSaniye = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFromDakika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_CancelIt = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelKalanSaniye = new System.Windows.Forms.Label();
            this.labelKalanDakika = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.labelKalanSaat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFromSaat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button_SetToThis = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_SetTimer
            // 
            this.button_SetTimer.BackColor = System.Drawing.Color.Black;
            this.button_SetTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_SetTimer.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.button_SetTimer.ForeColor = System.Drawing.SystemColors.Window;
            this.button_SetTimer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_SetTimer.Location = new System.Drawing.Point(32, 132);
            this.button_SetTimer.Name = "button_SetTimer";
            this.button_SetTimer.Size = new System.Drawing.Size(95, 23);
            this.button_SetTimer.TabIndex = 3;
            this.button_SetTimer.Text = "Set Timer";
            this.button_SetTimer.UseVisualStyleBackColor = false;
            this.button_SetTimer.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFromSaniye
            // 
            this.textBoxFromSaniye.BackColor = System.Drawing.Color.Bisque;
            this.textBoxFromSaniye.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.textBoxFromSaniye.Location = new System.Drawing.Point(103, 83);
            this.textBoxFromSaniye.Name = "textBoxFromSaniye";
            this.textBoxFromSaniye.Size = new System.Drawing.Size(36, 23);
            this.textBoxFromSaniye.TabIndex = 2;
            this.textBoxFromSaniye.Text = "0";
            this.textBoxFromSaniye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFromSaniye.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label1.Location = new System.Drawing.Point(102, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Second";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // textBoxFromDakika
            // 
            this.textBoxFromDakika.BackColor = System.Drawing.Color.Bisque;
            this.textBoxFromDakika.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.textBoxFromDakika.Location = new System.Drawing.Point(61, 83);
            this.textBoxFromDakika.Name = "textBoxFromDakika";
            this.textBoxFromDakika.Size = new System.Drawing.Size(36, 23);
            this.textBoxFromDakika.TabIndex = 1;
            this.textBoxFromDakika.Text = "3";
            this.textBoxFromDakika.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFromDakika.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            this.textBoxFromDakika.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tus_sinirlama);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label2.Location = new System.Drawing.Point(58, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minute";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // btn_CancelIt
            // 
            this.btn_CancelIt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CancelIt.BackColor = System.Drawing.Color.DarkRed;
            this.btn_CancelIt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CancelIt.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.btn_CancelIt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_CancelIt.Location = new System.Drawing.Point(117, 271);
            this.btn_CancelIt.Name = "btn_CancelIt";
            this.btn_CancelIt.Size = new System.Drawing.Size(218, 38);
            this.btn_CancelIt.TabIndex = 6;
            this.btn_CancelIt.Text = "Abort the Tİmer";
            this.btn_CancelIt.UseVisualStyleBackColor = false;
            this.btn_CancelIt.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.linkLabel1.LinkColor = System.Drawing.Color.SeaShell;
            this.linkLabel1.Location = new System.Drawing.Point(406, 295);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(30, 16);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Info";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 203);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(426, 23);
            this.progressBar1.Step = 0;
            this.progressBar1.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Exit.Location = new System.Drawing.Point(415, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(33, 23);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Minimize.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Minimize.Location = new System.Drawing.Point(384, 2);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(29, 23);
            this.btn_Minimize.TabIndex = 8;
            this.btn_Minimize.Text = "__";
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.Btn_Minimize_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "It\'s still running. Turning it off will not stop the timer.";
            this.notifyIcon1.BalloonTipTitle = "The Shutdown Timer";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Timer";
            this.notifyIcon1.Visible = true;
            // 
            // labelKalanSaniye
            // 
            this.labelKalanSaniye.AutoSize = true;
            this.labelKalanSaniye.BackColor = System.Drawing.Color.Transparent;
            this.labelKalanSaniye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelKalanSaniye.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.labelKalanSaniye.Location = new System.Drawing.Point(78, 2);
            this.labelKalanSaniye.Name = "labelKalanSaniye";
            this.labelKalanSaniye.Size = new System.Drawing.Size(15, 16);
            this.labelKalanSaniye.TabIndex = 11;
            this.labelKalanSaniye.Text = "0";
            this.labelKalanSaniye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKalanDakika
            // 
            this.labelKalanDakika.BackColor = System.Drawing.Color.Transparent;
            this.labelKalanDakika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelKalanDakika.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.labelKalanDakika.Location = new System.Drawing.Point(34, 2);
            this.labelKalanDakika.Name = "labelKalanDakika";
            this.labelKalanDakika.Size = new System.Drawing.Size(32, 13);
            this.labelKalanDakika.TabIndex = 12;
            this.labelKalanDakika.Text = "0";
            this.labelKalanDakika.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelKalanDakika.UseMnemonic = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelKalanSaniye);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.labelKalanSaat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelKalanDakika);
            this.panel1.Location = new System.Drawing.Point(169, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 21);
            this.panel1.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.label9.Location = new System.Drawing.Point(25, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = ":";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.UseMnemonic = false;
            // 
            // labelKalanSaat
            // 
            this.labelKalanSaat.BackColor = System.Drawing.Color.Transparent;
            this.labelKalanSaat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelKalanSaat.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.labelKalanSaat.Location = new System.Drawing.Point(-2, 2);
            this.labelKalanSaat.Name = "labelKalanSaat";
            this.labelKalanSaat.Size = new System.Drawing.Size(32, 13);
            this.labelKalanSaat.TabIndex = 14;
            this.labelKalanSaat.Text = "0";
            this.labelKalanSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelKalanSaat.UseMnemonic = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.label6.Location = new System.Drawing.Point(63, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = ":";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label5.Location = new System.Drawing.Point(92, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Remaining:";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label7.Location = new System.Drawing.Point(17, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Hour";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // textBoxFromSaat
            // 
            this.textBoxFromSaat.BackColor = System.Drawing.Color.Bisque;
            this.textBoxFromSaat.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.textBoxFromSaat.Location = new System.Drawing.Point(19, 83);
            this.textBoxFromSaat.Name = "textBoxFromSaat";
            this.textBoxFromSaat.Size = new System.Drawing.Size(36, 23);
            this.textBoxFromSaat.TabIndex = 0;
            this.textBoxFromSaat.Text = "0";
            this.textBoxFromSaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFromSaat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox3_MouseClick);
            this.textBoxFromSaat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tus_sinirlama);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label10.Location = new System.Drawing.Point(163, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Hour";
            this.label10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label11.Location = new System.Drawing.Point(197, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Minute";
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label12.Location = new System.Drawing.Point(239, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Second";
            this.label12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // button_SetToThis
            // 
            this.button_SetToThis.BackColor = System.Drawing.Color.Navy;
            this.button_SetToThis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_SetToThis.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.button_SetToThis.ForeColor = System.Drawing.Color.Linen;
            this.button_SetToThis.Location = new System.Drawing.Point(311, 132);
            this.button_SetToThis.Name = "button_SetToThis";
            this.button_SetToThis.Size = new System.Drawing.Size(96, 23);
            this.button_SetToThis.TabIndex = 5;
            this.button_SetToThis.Text = "Set to This";
            this.button_SetToThis.UseVisualStyleBackColor = false;
            this.button_SetToThis.Click += new System.EventHandler(this.Btn_SetThis_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.MediumBlue;
            this.label16.Location = new System.Drawing.Point(319, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 19);
            this.label16.TabIndex = 31;
            this.label16.Text = "With Time";
            this.label16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label16.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.MediumBlue;
            this.label19.Location = new System.Drawing.Point(16, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(126, 19);
            this.label19.TabIndex = 33;
            this.label19.Text = "With Countdown";
            this.label19.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label19.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(315, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(89, 23);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2021, 3, 28, 18, 36, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(122, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "The Shutdown Timer";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Form1
            // 
            this.AcceptButton = this.button_SetTimer;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button_SetToThis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFromSaat);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Minimize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_CancelIt);
            this.Controls.Add(this.textBoxFromDakika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFromSaniye);
            this.Controls.Add(this.button_SetTimer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Shutdown Timer";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_SetTimer;
        private System.Windows.Forms.TextBox textBoxFromSaniye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFromDakika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_CancelIt;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label labelKalanSaniye;
        private System.Windows.Forms.Label labelKalanDakika;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxFromSaat;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label labelKalanSaat;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button button_SetToThis;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

