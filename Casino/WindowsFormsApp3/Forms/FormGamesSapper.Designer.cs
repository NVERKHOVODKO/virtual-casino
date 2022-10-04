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
            this.labelBet = new System.Windows.Forms.Label();
            this.buttonTake = new System.Windows.Forms.Button();
            this.panelWin = new System.Windows.Forms.Panel();
            this.buttonTryAgain = new System.Windows.Forms.Button();
            this.labelWin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxBet = new System.Windows.Forms.TextBox();
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
            this.panel2.SuspendLayout();
            this.panelWin.SuspendLayout();
            this.panelBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBomb1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.sea;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.labelBet);
            this.panel2.Controls.Add(this.buttonTake);
            this.panel2.Controls.Add(this.panelWin);
            this.panel2.Controls.Add(this.buttonStart);
            this.panel2.Controls.Add(this.textBoxBet);
            this.panel2.Controls.Add(this.panelBoxes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labelBet
            // 
            this.labelBet.AutoSize = true;
            this.labelBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBet.ForeColor = System.Drawing.Color.Red;
            this.labelBet.Location = new System.Drawing.Point(555, 73);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(120, 69);
            this.labelBet.TabIndex = 10;
            this.labelBet.Text = "Bet";
            this.labelBet.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // buttonTake
            // 
            this.buttonTake.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.wood_button;
            this.buttonTake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonTake.Location = new System.Drawing.Point(527, 359);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(219, 68);
            this.buttonTake.TabIndex = 9;
            this.buttonTake.Text = "Take!";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // panelWin
            // 
            this.panelWin.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.map_with_pirat;
            this.panelWin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelWin.Controls.Add(this.buttonTryAgain);
            this.panelWin.Controls.Add(this.labelWin);
            this.panelWin.Controls.Add(this.label1);
            this.panelWin.Location = new System.Drawing.Point(436, 23);
            this.panelWin.Name = "panelWin";
            this.panelWin.Size = new System.Drawing.Size(370, 410);
            this.panelWin.TabIndex = 8;
            this.panelWin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWin_Paint);
            // 
            // buttonTryAgain
            // 
            this.buttonTryAgain.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.wood_button;
            this.buttonTryAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTryAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTryAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTryAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonTryAgain.Location = new System.Drawing.Point(70, 281);
            this.buttonTryAgain.Name = "buttonTryAgain";
            this.buttonTryAgain.Size = new System.Drawing.Size(219, 68);
            this.buttonTryAgain.TabIndex = 10;
            this.buttonTryAgain.Text = "Try Again";
            this.buttonTryAgain.UseVisualStyleBackColor = true;
            this.buttonTryAgain.Click += new System.EventHandler(this.buttonTryAgain_Click);
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.Font = new System.Drawing.Font("Leelawadee UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWin.Location = new System.Drawing.Point(97, 139);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(143, 45);
            this.labelWin.TabIndex = 1;
            this.labelWin.Text = "You win:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Congratulations!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.wood_button;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonStart.Location = new System.Drawing.Point(527, 359);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(219, 68);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Go!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxBet
            // 
            this.textBoxBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBet.Location = new System.Drawing.Point(527, 267);
            this.textBoxBet.Name = "textBoxBet";
            this.textBoxBet.Size = new System.Drawing.Size(219, 75);
            this.textBoxBet.TabIndex = 0;
            this.textBoxBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBet.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.panelBoxes.Location = new System.Drawing.Point(42, 21);
            this.panelBoxes.Name = "panelBoxes";
            this.panelBoxes.Size = new System.Drawing.Size(370, 410);
            this.panelBoxes.TabIndex = 3;
            this.panelBoxes.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBomb1
            // 
            this.pictureBomb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBomb1.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.bomb5;
            this.pictureBomb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBomb1.Location = new System.Drawing.Point(249, 321);
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
            this.btn5_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            this.btn5_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            this.btn1_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn1_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1_3.Image = ((System.Drawing.Image)(resources.GetObject("btn1_3.Image")));
            this.btn1_3.Location = new System.Drawing.Point(173, 321);
            this.btn1_3.Name = "btn1_3";
            this.btn1_3.Size = new System.Drawing.Size(70, 70);
            this.btn1_3.TabIndex = 20;
            this.btn1_3.UseVisualStyleBackColor = false;
            this.btn1_3.Click += new System.EventHandler(this.btn1_3_Click);
            // 
            // btn2_3
            // 
            this.btn2_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn2_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn2_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2_3.Image = ((System.Drawing.Image)(resources.GetObject("btn2_3.Image")));
            this.btn2_3.Location = new System.Drawing.Point(173, 246);
            this.btn2_3.Name = "btn2_3";
            this.btn2_3.Size = new System.Drawing.Size(70, 70);
            this.btn2_3.TabIndex = 17;
            this.btn2_3.UseVisualStyleBackColor = false;
            this.btn2_3.Click += new System.EventHandler(this.btn2_3_Click);
            // 
            // btn1_2
            // 
            this.btn1_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn1_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn1_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1_2.Image = ((System.Drawing.Image)(resources.GetObject("btn1_2.Image")));
            this.btn1_2.Location = new System.Drawing.Point(97, 321);
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
            this.btn5_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            this.btn1_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn1_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1_1.Image = ((System.Drawing.Image)(resources.GetObject("btn1_1.Image")));
            this.btn1_1.Location = new System.Drawing.Point(21, 321);
            this.btn1_1.Name = "btn1_1";
            this.btn1_1.Size = new System.Drawing.Size(70, 70);
            this.btn1_1.TabIndex = 18;
            this.btn1_1.UseVisualStyleBackColor = false;
            this.btn1_1.Click += new System.EventHandler(this.button15_Click);
            // 
            // btn2_2
            // 
            this.btn2_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn2_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn2_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2_2.Image = ((System.Drawing.Image)(resources.GetObject("btn2_2.Image")));
            this.btn2_2.Location = new System.Drawing.Point(97, 246);
            this.btn2_2.Name = "btn2_2";
            this.btn2_2.Size = new System.Drawing.Size(70, 70);
            this.btn2_2.TabIndex = 16;
            this.btn2_2.UseVisualStyleBackColor = false;
            this.btn2_2.Click += new System.EventHandler(this.btn2_2_Click);
            // 
            // btn3_1
            // 
            this.btn3_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn3_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn3_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3_1.Image = ((System.Drawing.Image)(resources.GetObject("btn3_1.Image")));
            this.btn3_1.Location = new System.Drawing.Point(21, 170);
            this.btn3_1.Name = "btn3_1";
            this.btn3_1.Size = new System.Drawing.Size(70, 70);
            this.btn3_1.TabIndex = 12;
            this.btn3_1.UseVisualStyleBackColor = false;
            this.btn3_1.Click += new System.EventHandler(this.btn3_1_Click);
            // 
            // btn4_1
            // 
            this.btn4_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn4_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn4_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4_1.Image = ((System.Drawing.Image)(resources.GetObject("btn4_1.Image")));
            this.btn4_1.Location = new System.Drawing.Point(21, 94);
            this.btn4_1.Name = "btn4_1";
            this.btn4_1.Size = new System.Drawing.Size(70, 70);
            this.btn4_1.TabIndex = 9;
            this.btn4_1.UseVisualStyleBackColor = false;
            this.btn4_1.Click += new System.EventHandler(this.btn4_1_Click);
            // 
            // btn3_2
            // 
            this.btn3_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn3_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn3_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3_2.Image = ((System.Drawing.Image)(resources.GetObject("btn3_2.Image")));
            this.btn3_2.Location = new System.Drawing.Point(97, 170);
            this.btn3_2.Name = "btn3_2";
            this.btn3_2.Size = new System.Drawing.Size(70, 70);
            this.btn3_2.TabIndex = 13;
            this.btn3_2.UseVisualStyleBackColor = false;
            this.btn3_2.Click += new System.EventHandler(this.btn3_2_Click);
            // 
            // btn2_1
            // 
            this.btn2_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn2_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn2_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2_1.Image = ((System.Drawing.Image)(resources.GetObject("btn2_1.Image")));
            this.btn2_1.Location = new System.Drawing.Point(21, 246);
            this.btn2_1.Name = "btn2_1";
            this.btn2_1.Size = new System.Drawing.Size(70, 70);
            this.btn2_1.TabIndex = 15;
            this.btn2_1.UseVisualStyleBackColor = false;
            this.btn2_1.Click += new System.EventHandler(this.btn2_1_Click);
            // 
            // btn4_3
            // 
            this.btn4_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn4_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn4_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4_3.Image = ((System.Drawing.Image)(resources.GetObject("btn4_3.Image")));
            this.btn4_3.Location = new System.Drawing.Point(173, 94);
            this.btn4_3.Name = "btn4_3";
            this.btn4_3.Size = new System.Drawing.Size(70, 70);
            this.btn4_3.TabIndex = 11;
            this.btn4_3.UseVisualStyleBackColor = false;
            this.btn4_3.Click += new System.EventHandler(this.btn4_3_Click);
            // 
            // btn4_2
            // 
            this.btn4_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn4_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn4_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4_2.Image = ((System.Drawing.Image)(resources.GetObject("btn4_2.Image")));
            this.btn4_2.Location = new System.Drawing.Point(97, 94);
            this.btn4_2.Name = "btn4_2";
            this.btn4_2.Size = new System.Drawing.Size(70, 70);
            this.btn4_2.TabIndex = 10;
            this.btn4_2.UseVisualStyleBackColor = false;
            this.btn4_2.Click += new System.EventHandler(this.btn4_2_Click);
            // 
            // btn3_3
            // 
            this.btn3_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn3_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn3_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3_3.Image = ((System.Drawing.Image)(resources.GetObject("btn3_3.Image")));
            this.btn3_3.Location = new System.Drawing.Point(173, 170);
            this.btn3_3.Name = "btn3_3";
            this.btn3_3.Size = new System.Drawing.Size(70, 70);
            this.btn3_3.TabIndex = 14;
            this.btn3_3.UseVisualStyleBackColor = false;
            this.btn3_3.Click += new System.EventHandler(this.btn3_3_Click);
            // 
            // FormGamesSapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "FormGamesSapper";
            this.Text = "FormGamesSapper";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelWin.ResumeLayout(false);
            this.panelWin.PerformLayout();
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
        private System.Windows.Forms.Panel panelWin;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.Button buttonTryAgain;
        private System.Windows.Forms.Label labelBet;
    }
}