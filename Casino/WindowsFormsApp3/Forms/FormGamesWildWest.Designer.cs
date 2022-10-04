namespace WindowsFormsApp3.Forms
{
    partial class FormGamesWildWest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGamesWildWest));
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.TextBox();
            this.bntBet1 = new System.Windows.Forms.Button();
            this.bntBet5 = new System.Windows.Forms.Button();
            this.bntBet20 = new System.Windows.Forms.Button();
            this.bntBet100 = new System.Windows.Forms.Button();
            this.textBoxBet = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Red;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Century", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Image = global::WindowsFormsApp3.Properties.Resources.wood_button;
            this.btnStart.Location = new System.Drawing.Point(329, 382);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(231, 80);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "SPIN";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(285, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(529, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 120);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.wood;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.LblTitle);
            this.panel1.Controls.Add(this.bntBet1);
            this.panel1.Controls.Add(this.bntBet5);
            this.panel1.Controls.Add(this.bntBet20);
            this.panel1.Controls.Add(this.bntBet100);
            this.panel1.Controls.Add(this.textBoxBet);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(233, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 685);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(73, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 226);
            this.panel2.TabIndex = 15;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(688, 596);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 63);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // LblTitle
            // 
            this.LblTitle.BackColor = System.Drawing.Color.Yellow;
            this.LblTitle.Enabled = false;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(115, 20);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(673, 49);
            this.LblTitle.TabIndex = 13;
            this.LblTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LblTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bntBet1
            // 
            this.bntBet1.BackColor = System.Drawing.SystemColors.Highlight;
            this.bntBet1.FlatAppearance.BorderSize = 0;
            this.bntBet1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntBet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bntBet1.Location = new System.Drawing.Point(546, 596);
            this.bntBet1.Name = "bntBet1";
            this.bntBet1.Size = new System.Drawing.Size(120, 63);
            this.bntBet1.TabIndex = 12;
            this.bntBet1.Text = "1";
            this.bntBet1.UseVisualStyleBackColor = false;
            this.bntBet1.Click += new System.EventHandler(this.button4_Click);
            // 
            // bntBet5
            // 
            this.bntBet5.BackColor = System.Drawing.Color.Lime;
            this.bntBet5.FlatAppearance.BorderSize = 0;
            this.bntBet5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntBet5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bntBet5.Location = new System.Drawing.Point(409, 596);
            this.bntBet5.Name = "bntBet5";
            this.bntBet5.Size = new System.Drawing.Size(120, 63);
            this.bntBet5.TabIndex = 11;
            this.bntBet5.Text = "5";
            this.bntBet5.UseVisualStyleBackColor = false;
            this.bntBet5.Click += new System.EventHandler(this.button3_Click);
            // 
            // bntBet20
            // 
            this.bntBet20.BackColor = System.Drawing.Color.Yellow;
            this.bntBet20.FlatAppearance.BorderSize = 0;
            this.bntBet20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntBet20.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bntBet20.Location = new System.Drawing.Point(257, 596);
            this.bntBet20.Name = "bntBet20";
            this.bntBet20.Size = new System.Drawing.Size(120, 63);
            this.bntBet20.TabIndex = 10;
            this.bntBet20.Text = "20";
            this.bntBet20.UseVisualStyleBackColor = false;
            this.bntBet20.Click += new System.EventHandler(this.button2_Click);
            // 
            // bntBet100
            // 
            this.bntBet100.BackColor = System.Drawing.Color.Red;
            this.bntBet100.FlatAppearance.BorderSize = 0;
            this.bntBet100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntBet100.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bntBet100.Location = new System.Drawing.Point(115, 596);
            this.bntBet100.Name = "bntBet100";
            this.bntBet100.Size = new System.Drawing.Size(120, 63);
            this.bntBet100.TabIndex = 9;
            this.bntBet100.Text = "100";
            this.bntBet100.UseVisualStyleBackColor = false;
            this.bntBet100.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxBet
            // 
            this.textBoxBet.BackColor = System.Drawing.Color.Black;
            this.textBoxBet.Enabled = false;
            this.textBoxBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 43.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBet.ForeColor = System.Drawing.Color.White;
            this.textBoxBet.Location = new System.Drawing.Point(115, 483);
            this.textBoxBet.Name = "textBoxBet";
            this.textBoxBet.Size = new System.Drawing.Size(693, 90);
            this.textBoxBet.TabIndex = 4;
            this.textBoxBet.Text = "     ";
            this.textBoxBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBet.TextChanged += new System.EventHandler(this.textBoxBet_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.wild_west;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1356, 740);
            this.panel3.TabIndex = 9;
            // 
            // FormGamesSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1356, 740);
            this.Controls.Add(this.panel3);
            this.HelpButton = true;
            this.Name = "FormGamesSpace";
            this.Text = "FormGamesJew";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntBet1;
        private System.Windows.Forms.Button bntBet5;
        private System.Windows.Forms.Button bntBet20;
        private System.Windows.Forms.Button bntBet100;
        private System.Windows.Forms.TextBox textBoxBet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox LblTitle;
        private System.Windows.Forms.Panel panel3;
    }
}