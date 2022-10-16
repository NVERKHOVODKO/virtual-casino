namespace WindowsFormsApp3.Forms
{
    partial class FormGamesSapper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGamesSapper));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelFlag = new System.Windows.Forms.Panel();
            this.labelBalance = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBoxes = new System.Windows.Forms.Panel();
            this.pictureBomb1 = new System.Windows.Forms.PictureBox();
            this.btn5_2 = new System.Windows.Forms.Button();
            this.btn5_1 = new System.Windows.Forms.Button();
            this.btn1_3 = new System.Windows.Forms.Button();
            this.btn2_3 = new System.Windows.Forms.Button();
            this.btn1_2 = new System.Windows.Forms.Button();
            this.btn5_3 = new System.Windows.Forms.Button();
            this.btn1_1 = new System.Windows.Forms.Button();
            this.btn2_2 = new System.Windows.Forms.Button();
            this.btn3_1 = new System.Windows.Forms.Button();
            this.btn4_1 = new System.Windows.Forms.Button();
            this.btn3_2 = new System.Windows.Forms.Button();
            this.btn2_1 = new System.Windows.Forms.Button();
            this.btn4_3 = new System.Windows.Forms.Button();
            this.btn4_2 = new System.Windows.Forms.Button();
            this.btn3_3 = new System.Windows.Forms.Button();
            this.buttonTryAgain = new System.Windows.Forms.Button();
            this.buttonTake = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxBet = new System.Windows.Forms.TextBox();
            this.panelLogInfo = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panelFlag.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBomb1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.sea;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panelFlag);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panelLogInfo);
            this.panel2.Controls.Add(this.panelInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1493, 813);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelFlag
            // 
            this.panelFlag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panelFlag.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.flag;
            this.panelFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFlag.Controls.Add(this.labelBalance);
            this.panelFlag.Location = new System.Drawing.Point(1340, 3);
            this.panelFlag.Name = "panelFlag";
            this.panelFlag.Size = new System.Drawing.Size(223, 155);
            this.panelFlag.TabIndex = 17;
            // 
            // labelBalance
            // 
            this.labelBalance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBalance.AutoSize = true;
            this.labelBalance.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelBalance.Enabled = false;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBalance.ForeColor = System.Drawing.Color.White;
            this.labelBalance.Location = new System.Drawing.Point(71, 55);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(138, 51);
            this.labelBalance.TabIndex = 0;
            this.labelBalance.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.wooden_board;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panelBoxes);
            this.panel3.Controls.Add(this.buttonTryAgain);
            this.panel3.Controls.Add(this.buttonTake);
            this.panel3.Controls.Add(this.buttonStart);
            this.panel3.Controls.Add(this.textBoxBet);
            this.panel3.Location = new System.Drawing.Point(356, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(869, 569);
            this.panel3.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.scale_coins_1;
            this.pictureBox1.Location = new System.Drawing.Point(529, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 267);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panelBoxes
            // 
            this.panelBoxes.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.map10;
            this.panelBoxes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBoxes.Controls.Add(this.pictureBomb1);
            this.panelBoxes.Controls.Add(this.btn5_2);
            this.panelBoxes.Controls.Add(this.btn5_1);
            this.panelBoxes.Controls.Add(this.btn1_3);
            this.panelBoxes.Controls.Add(this.btn2_3);
            this.panelBoxes.Controls.Add(this.btn1_2);
            this.panelBoxes.Controls.Add(this.btn5_3);
            this.panelBoxes.Controls.Add(this.btn1_1);
            this.panelBoxes.Controls.Add(this.btn2_2);
            this.panelBoxes.Controls.Add(this.btn3_1);
            this.panelBoxes.Controls.Add(this.btn4_1);
            this.panelBoxes.Controls.Add(this.btn3_2);
            this.panelBoxes.Controls.Add(this.btn2_1);
            this.panelBoxes.Controls.Add(this.btn4_3);
            this.panelBoxes.Controls.Add(this.btn4_2);
            this.panelBoxes.Controls.Add(this.btn3_3);
            this.panelBoxes.Location = new System.Drawing.Point(53, 66);
            this.panelBoxes.Name = "panelBoxes";
            this.panelBoxes.Size = new System.Drawing.Size(391, 438);
            this.panelBoxes.TabIndex = 3;
            this.panelBoxes.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBomb1
            // 
            this.pictureBomb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBomb1.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.bomb5;
            this.pictureBomb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBomb1.Location = new System.Drawing.Point(309, 352);
            this.pictureBomb1.Name = "pictureBomb1";
            this.pictureBomb1.Size = new System.Drawing.Size(70, 70);
            this.pictureBomb1.TabIndex = 21;
            this.pictureBomb1.TabStop = false;
            this.pictureBomb1.Click += new System.EventHandler(this.pictureBomb1_Click);
            // 
            // btn5_2
            // 
            this.btn5_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn5_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn5_2.BackgroundImage")));
            this.btn5_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn5_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5_2.Image = ((System.Drawing.Image)(resources.GetObject("btn5_2.Image")));
            this.btn5_2.Location = new System.Drawing.Point(97, 18);
            this.btn5_2.Name = "btn5_2";
            this.btn5_2.Size = new System.Drawing.Size(70, 70);
            this.btn5_2.TabIndex = 7;
            this.btn5_2.UseVisualStyleBackColor = false;
            this.btn5_2.Click += new System.EventHandler(this.btn5_2_Click);
            // 
            // btn5_1
            // 
            this.btn5_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn5_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn5_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5_1.Image = ((System.Drawing.Image)(resources.GetObject("btn5_1.Image")));
            this.btn5_1.Location = new System.Drawing.Point(21, 18);
            this.btn5_1.Name = "btn5_1";
            this.btn5_1.Size = new System.Drawing.Size(70, 70);
            this.btn5_1.TabIndex = 6;
            this.btn5_1.UseVisualStyleBackColor = false;
            this.btn5_1.Click += new System.EventHandler(this.btn5_1_Click);
            // 
            // btn1_3
            // 
            this.btn1_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn1_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1_3.Image = ((System.Drawing.Image)(resources.GetObject("btn1_3.Image")));
            this.btn1_3.Location = new System.Drawing.Point(173, 352);
            this.btn1_3.Name = "btn1_3";
            this.btn1_3.Size = new System.Drawing.Size(70, 70);
            this.btn1_3.TabIndex = 20;
            this.btn1_3.UseVisualStyleBackColor = false;
            this.btn1_3.Click += new System.EventHandler(this.btn1_3_Click);
            // 
            // btn2_3
            // 
            this.btn2_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn2_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2_3.Image = ((System.Drawing.Image)(resources.GetObject("btn2_3.Image")));
            this.btn2_3.Location = new System.Drawing.Point(172, 268);
            this.btn2_3.Name = "btn2_3";
            this.btn2_3.Size = new System.Drawing.Size(70, 70);
            this.btn2_3.TabIndex = 17;
            this.btn2_3.UseVisualStyleBackColor = false;
            this.btn2_3.Click += new System.EventHandler(this.btn2_3_Click);
            // 
            // btn1_2
            // 
            this.btn1_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn1_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1_2.Image = ((System.Drawing.Image)(resources.GetObject("btn1_2.Image")));
            this.btn1_2.Location = new System.Drawing.Point(97, 352);
            this.btn1_2.Name = "btn1_2";
            this.btn1_2.Size = new System.Drawing.Size(70, 70);
            this.btn1_2.TabIndex = 19;
            this.btn1_2.UseVisualStyleBackColor = false;
            this.btn1_2.Click += new System.EventHandler(this.btn1_2_Click);
            // 
            // btn5_3
            // 
            this.btn5_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn5_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn5_3.BackgroundImage")));
            this.btn5_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn5_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5_3.Image = ((System.Drawing.Image)(resources.GetObject("btn5_3.Image")));
            this.btn5_3.Location = new System.Drawing.Point(173, 18);
            this.btn5_3.Name = "btn5_3";
            this.btn5_3.Size = new System.Drawing.Size(70, 70);
            this.btn5_3.TabIndex = 8;
            this.btn5_3.UseVisualStyleBackColor = false;
            this.btn5_3.Click += new System.EventHandler(this.btn5_3_Click);
            // 
            // btn1_1
            // 
            this.btn1_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn1_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1_1.Image = ((System.Drawing.Image)(resources.GetObject("btn1_1.Image")));
            this.btn1_1.Location = new System.Drawing.Point(21, 352);
            this.btn1_1.Name = "btn1_1";
            this.btn1_1.Size = new System.Drawing.Size(70, 70);
            this.btn1_1.TabIndex = 18;
            this.btn1_1.UseVisualStyleBackColor = false;
            this.btn1_1.Click += new System.EventHandler(this.button15_Click);
            // 
            // btn2_2
            // 
            this.btn2_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn2_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2_2.Image = ((System.Drawing.Image)(resources.GetObject("btn2_2.Image")));
            this.btn2_2.Location = new System.Drawing.Point(96, 268);
            this.btn2_2.Name = "btn2_2";
            this.btn2_2.Size = new System.Drawing.Size(70, 70);
            this.btn2_2.TabIndex = 16;
            this.btn2_2.UseVisualStyleBackColor = false;
            this.btn2_2.Click += new System.EventHandler(this.btn2_2_Click);
            // 
            // btn3_1
            // 
            this.btn3_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn3_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3_1.Image = ((System.Drawing.Image)(resources.GetObject("btn3_1.Image")));
            this.btn3_1.Location = new System.Drawing.Point(20, 184);
            this.btn3_1.Name = "btn3_1";
            this.btn3_1.Size = new System.Drawing.Size(70, 70);
            this.btn3_1.TabIndex = 12;
            this.btn3_1.UseVisualStyleBackColor = false;
            this.btn3_1.Click += new System.EventHandler(this.btn3_1_Click);
            // 
            // btn4_1
            // 
            this.btn4_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn4_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn4_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4_1.Image = ((System.Drawing.Image)(resources.GetObject("btn4_1.Image")));
            this.btn4_1.Location = new System.Drawing.Point(20, 100);
            this.btn4_1.Name = "btn4_1";
            this.btn4_1.Size = new System.Drawing.Size(70, 70);
            this.btn4_1.TabIndex = 9;
            this.btn4_1.UseVisualStyleBackColor = false;
            this.btn4_1.Click += new System.EventHandler(this.btn4_1_Click);
            // 
            // btn3_2
            // 
            this.btn3_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn3_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3_2.Image = ((System.Drawing.Image)(resources.GetObject("btn3_2.Image")));
            this.btn3_2.Location = new System.Drawing.Point(96, 184);
            this.btn3_2.Name = "btn3_2";
            this.btn3_2.Size = new System.Drawing.Size(70, 70);
            this.btn3_2.TabIndex = 13;
            this.btn3_2.UseVisualStyleBackColor = false;
            this.btn3_2.Click += new System.EventHandler(this.btn3_2_Click);
            // 
            // btn2_1
            // 
            this.btn2_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn2_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2_1.Image = ((System.Drawing.Image)(resources.GetObject("btn2_1.Image")));
            this.btn2_1.Location = new System.Drawing.Point(21, 268);
            this.btn2_1.Name = "btn2_1";
            this.btn2_1.Size = new System.Drawing.Size(70, 70);
            this.btn2_1.TabIndex = 15;
            this.btn2_1.UseVisualStyleBackColor = false;
            this.btn2_1.Click += new System.EventHandler(this.btn2_1_Click);
            // 
            // btn4_3
            // 
            this.btn4_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn4_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn4_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4_3.Image = ((System.Drawing.Image)(resources.GetObject("btn4_3.Image")));
            this.btn4_3.Location = new System.Drawing.Point(173, 100);
            this.btn4_3.Name = "btn4_3";
            this.btn4_3.Size = new System.Drawing.Size(70, 70);
            this.btn4_3.TabIndex = 11;
            this.btn4_3.UseVisualStyleBackColor = false;
            this.btn4_3.Click += new System.EventHandler(this.btn4_3_Click);
            // 
            // btn4_2
            // 
            this.btn4_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn4_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn4_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4_2.Image = ((System.Drawing.Image)(resources.GetObject("btn4_2.Image")));
            this.btn4_2.Location = new System.Drawing.Point(96, 100);
            this.btn4_2.Name = "btn4_2";
            this.btn4_2.Size = new System.Drawing.Size(70, 70);
            this.btn4_2.TabIndex = 10;
            this.btn4_2.UseVisualStyleBackColor = false;
            this.btn4_2.Click += new System.EventHandler(this.btn4_2_Click);
            // 
            // btn3_3
            // 
            this.btn3_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn3_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3_3.Image = ((System.Drawing.Image)(resources.GetObject("btn3_3.Image")));
            this.btn3_3.Location = new System.Drawing.Point(173, 184);
            this.btn3_3.Name = "btn3_3";
            this.btn3_3.Size = new System.Drawing.Size(70, 70);
            this.btn3_3.TabIndex = 14;
            this.btn3_3.UseVisualStyleBackColor = false;
            this.btn3_3.Click += new System.EventHandler(this.btn3_3_Click);
            // 
            // buttonTryAgain
            // 
            this.buttonTryAgain.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.wood_button;
            this.buttonTryAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTryAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTryAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTryAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonTryAgain.Location = new System.Drawing.Point(529, 436);
            this.buttonTryAgain.Name = "buttonTryAgain";
            this.buttonTryAgain.Size = new System.Drawing.Size(284, 68);
            this.buttonTryAgain.TabIndex = 10;
            this.buttonTryAgain.Text = "Try Again";
            this.buttonTryAgain.UseVisualStyleBackColor = true;
            this.buttonTryAgain.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTake
            // 
            this.buttonTake.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.wood_button;
            this.buttonTake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonTake.Location = new System.Drawing.Point(529, 436);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(284, 68);
            this.buttonTake.TabIndex = 9;
            this.buttonTake.Text = "Take!";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.wood_button;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonStart.Location = new System.Drawing.Point(529, 436);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(284, 68);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Go!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxBet
            // 
            this.textBoxBet.BackColor = System.Drawing.Color.Gold;
            this.textBoxBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxBet.Location = new System.Drawing.Point(530, 346);
            this.textBoxBet.Name = "textBoxBet";
            this.textBoxBet.Size = new System.Drawing.Size(284, 75);
            this.textBoxBet.TabIndex = 0;
            this.textBoxBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBet.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panelLogInfo
            // 
            this.panelLogInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panelLogInfo.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.infIcon;
            this.panelLogInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogInfo.Location = new System.Drawing.Point(1393, 713);
            this.panelLogInfo.Name = "panelLogInfo";
            this.panelLogInfo.Size = new System.Drawing.Size(100, 100);
            this.panelLogInfo.TabIndex = 14;
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panelInfo.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.sapperInfo1;
            this.panelInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelInfo.Location = new System.Drawing.Point(1305, 549);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(422, 239);
            this.panelInfo.TabIndex = 13;
            // 
            // FormGamesSapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1493, 813);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "FormGamesSapper";
            this.Text = "FormGamesSapper";
            this.panel2.ResumeLayout(false);
            this.panelFlag.ResumeLayout(false);
            this.panelFlag.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBoxes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBomb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBoxes;
        private System.Windows.Forms.Button btn1_3;
        private System.Windows.Forms.Button btn1_2;
        private System.Windows.Forms.Button btn1_1;
        private System.Windows.Forms.Button btn3_1;
        private System.Windows.Forms.Button btn3_2;
        private System.Windows.Forms.Button btn4_3;
        private System.Windows.Forms.Button btn3_3;
        private System.Windows.Forms.Button btn4_2;
        private System.Windows.Forms.Button btn2_1;
        private System.Windows.Forms.Button btn4_1;
        private System.Windows.Forms.Button btn2_2;
        private System.Windows.Forms.Button btn5_3;
        private System.Windows.Forms.Button btn2_3;
        private System.Windows.Forms.Button btn5_1;
        private System.Windows.Forms.Button btn5_2;
        private System.Windows.Forms.PictureBox pictureBomb1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelBet;
        private System.Windows.Forms.TextBox textBoxBet;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.Button buttonTryAgain;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelLogInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelFlag;
        private System.Windows.Forms.Label labelBalance;
    }
}