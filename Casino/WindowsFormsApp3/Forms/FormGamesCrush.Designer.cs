namespace WindowsFormsApp3.Forms
{
    partial class FormGamesCrush
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGamesCrush));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelBet = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblBet = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWinBet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblYourBet = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelDesktop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelDesktop.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.background_metal;
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDesktop.Controls.Add(this.panel3);
            this.panelDesktop.Controls.Add(this.panel1);
            this.panelDesktop.Controls.Add(this.panel2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1924, 1055);
            this.panelDesktop.TabIndex = 0;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 763);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1517, 292);
            this.panel3.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btnDelBet);
            this.panel4.Controls.Add(this.btnAll);
            this.panel4.Controls.Add(this.btn10);
            this.panel4.Controls.Add(this.btn100);
            this.panel4.Controls.Add(this.btn50);
            this.panel4.Controls.Add(this.btn5);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btnTake);
            this.panel4.Controls.Add(this.btnGo);
            this.panel4.Location = new System.Drawing.Point(170, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1247, 211);
            this.panel4.TabIndex = 17;
            // 
            // btnDelBet
            // 
            this.btnDelBet.BackColor = System.Drawing.Color.DimGray;
            this.btnDelBet.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.metal_button_crush;
            this.btnDelBet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelBet.FlatAppearance.BorderSize = 0;
            this.btnDelBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelBet.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelBet.ForeColor = System.Drawing.Color.Black;
            this.btnDelBet.Location = new System.Drawing.Point(426, 128);
            this.btnDelBet.Name = "btnDelBet";
            this.btnDelBet.Size = new System.Drawing.Size(70, 70);
            this.btnDelBet.TabIndex = 21;
            this.btnDelBet.Text = "Del";
            this.btnDelBet.UseVisualStyleBackColor = false;
            this.btnDelBet.Click += new System.EventHandler(this.btnDelBet_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAll.BackgroundImage")));
            this.btnAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAll.ForeColor = System.Drawing.Color.Black;
            this.btnAll.Location = new System.Drawing.Point(350, 128);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(70, 70);
            this.btnAll.TabIndex = 20;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn10.BackgroundImage")));
            this.btn10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn10.FlatAppearance.BorderSize = 0;
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn10.ForeColor = System.Drawing.Color.Black;
            this.btn10.Location = new System.Drawing.Point(122, 129);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(70, 70);
            this.btn10.TabIndex = 19;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = false;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn100
            // 
            this.btn100.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn100.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn100.BackgroundImage")));
            this.btn100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn100.FlatAppearance.BorderSize = 0;
            this.btn100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn100.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn100.ForeColor = System.Drawing.Color.Black;
            this.btn100.Location = new System.Drawing.Point(274, 129);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(70, 70);
            this.btn100.TabIndex = 18;
            this.btn100.Text = "100";
            this.btn100.UseVisualStyleBackColor = false;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn50
            // 
            this.btn50.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn50.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn50.BackgroundImage")));
            this.btn50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn50.FlatAppearance.BorderSize = 0;
            this.btn50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn50.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn50.ForeColor = System.Drawing.Color.Black;
            this.btn50.Location = new System.Drawing.Point(198, 129);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(70, 70);
            this.btn50.TabIndex = 17;
            this.btn50.Text = "50";
            this.btn50.UseVisualStyleBackColor = false;
            this.btn50.Click += new System.EventHandler(this.btn50_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn5.BackgroundImage")));
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(46, 129);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 70);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.lblBet);
            this.panel5.Controls.Add(this.btnPlus);
            this.panel5.Controls.Add(this.btnMinus);
            this.panel5.Location = new System.Drawing.Point(45, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(451, 93);
            this.panel5.TabIndex = 14;
            // 
            // lblBet
            // 
            this.lblBet.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBet.ForeColor = System.Drawing.Color.White;
            this.lblBet.Location = new System.Drawing.Point(66, 9);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(216, 70);
            this.lblBet.TabIndex = 15;
            this.lblBet.Text = "\r\n0";
            this.lblBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Red;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(381, 26);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(40, 40);
            this.btnPlus.TabIndex = 12;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Red;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(335, 26);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(40, 40);
            this.btnMinus.TabIndex = 13;
            this.btnMinus.Text = "-";
            this.btnMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnTake
            // 
            this.btnTake.AllowDrop = true;
            this.btnTake.AutoSize = true;
            this.btnTake.BackColor = System.Drawing.Color.Gray;
            this.btnTake.FlatAppearance.BorderSize = 0;
            this.btnTake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTake.Font = new System.Drawing.Font("Comic Sans MS", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTake.ForeColor = System.Drawing.Color.Black;
            this.btnTake.Location = new System.Drawing.Point(518, 24);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(271, 161);
            this.btnTake.TabIndex = 10;
            this.btnTake.Text = "TAKE";
            this.btnTake.UseVisualStyleBackColor = false;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click_1);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Gray;
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Comic Sans MS", 52.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGo.ForeColor = System.Drawing.Color.Black;
            this.btnGo.Location = new System.Drawing.Point(518, 24);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(271, 163);
            this.btnGo.TabIndex = 11;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1517, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 1055);
            this.panel1.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.lblWinBet);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.lblYourBet);
            this.panel6.Location = new System.Drawing.Point(16, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(379, 873);
            this.panel6.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 33);
            this.label4.TabIndex = 26;
            this.label4.Text = "Other players";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 87);
            this.label3.TabIndex = 25;
            this.label3.Text = "Your X: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 87);
            this.label1.TabIndex = 24;
            this.label1.Text = "Your bet: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWinBet
            // 
            this.lblWinBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblWinBet.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWinBet.ForeColor = System.Drawing.Color.Black;
            this.lblWinBet.Location = new System.Drawing.Point(137, 85);
            this.lblWinBet.Name = "lblWinBet";
            this.lblWinBet.Size = new System.Drawing.Size(239, 87);
            this.lblWinBet.TabIndex = 23;
            this.lblWinBet.Text = "---";
            this.lblWinBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(16, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(564, 611);
            this.label2.TabIndex = 22;
            // 
            // lblYourBet
            // 
            this.lblYourBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblYourBet.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYourBet.ForeColor = System.Drawing.Color.Black;
            this.lblYourBet.Location = new System.Drawing.Point(137, 0);
            this.lblYourBet.Name = "lblYourBet";
            this.lblYourBet.Size = new System.Drawing.Size(239, 118);
            this.lblYourBet.TabIndex = 20;
            this.lblYourBet.Text = "---";
            this.lblYourBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.dude_jpg;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.labelMult);
            this.panel2.Location = new System.Drawing.Point(396, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 550);
            this.panel2.TabIndex = 3;
            // 
            // labelMult
            // 
            this.labelMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelMult.Font = new System.Drawing.Font("Palatino Linotype", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMult.ForeColor = System.Drawing.Color.Red;
            this.labelMult.Location = new System.Drawing.Point(69, 171);
            this.labelMult.Name = "labelMult";
            this.labelMult.Size = new System.Drawing.Size(425, 188);
            this.labelMult.TabIndex = 7;
            this.labelMult.Text = "X 777";
            this.labelMult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(872, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 67);
            this.label6.TabIndex = 23;
            this.label6.Text = "Get on:";
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1070, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 161);
            this.button1.TabIndex = 24;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(884, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 68);
            this.textBox1.TabIndex = 25;
            // 
            // FormGamesCrush
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panelDesktop);
            this.KeyPreview = true;
            this.Name = "FormGamesCrush";
            this.Text = "FormGamesCrush";
            this.panelDesktop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label labelMult;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblYourBet;
        private System.Windows.Forms.Label lblWinBet;
        private System.Windows.Forms.Button btnDelBet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}