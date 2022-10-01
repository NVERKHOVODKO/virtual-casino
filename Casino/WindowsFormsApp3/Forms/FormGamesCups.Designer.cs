namespace WindowsFormsApp3.Forms
{
    partial class FormGamesCups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGamesCups));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelBet = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.panelEnterBet = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelCup2 = new System.Windows.Forms.Panel();
            this.panelCup3 = new System.Windows.Forms.Panel();
            this.panelCup1 = new System.Windows.Forms.Panel();
            this.panelEnterBet.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(18, 65);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 53);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelBet
            // 
            this.labelBet.AutoSize = true;
            this.labelBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBet.Location = new System.Drawing.Point(5, 17);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(202, 36);
            this.labelBet.TabIndex = 5;
            this.labelBet.Text = "place your bet";
            this.labelBet.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBalance.Location = new System.Drawing.Point(607, 9);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(181, 32);
            this.labelBalance.TabIndex = 6;
            this.labelBalance.Text = "Balance: 342";
            this.labelBalance.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panelEnterBet
            // 
            this.panelEnterBet.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelEnterBet.Controls.Add(this.btnStart);
            this.panelEnterBet.Controls.Add(this.textBox1);
            this.panelEnterBet.Controls.Add(this.labelBet);
            this.panelEnterBet.Location = new System.Drawing.Point(300, 9);
            this.panelEnterBet.Name = "panelEnterBet";
            this.panelEnterBet.Size = new System.Drawing.Size(210, 199);
            this.panelEnterBet.TabIndex = 7;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Red;
            this.btnStart.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.Jew_icon1;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(18, 124);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(178, 56);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Go!";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panelCup2
            // 
            this.panelCup2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCup2.BackgroundImage")));
            this.panelCup2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCup2.Location = new System.Drawing.Point(350, 245);
            this.panelCup2.Name = "panelCup2";
            this.panelCup2.Size = new System.Drawing.Size(150, 150);
            this.panelCup2.TabIndex = 2;
            // 
            // panelCup3
            // 
            this.panelCup3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCup3.BackgroundImage")));
            this.panelCup3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCup3.Location = new System.Drawing.Point(130, 245);
            this.panelCup3.Name = "panelCup3";
            this.panelCup3.Size = new System.Drawing.Size(150, 150);
            this.panelCup3.TabIndex = 2;
            // 
            // panelCup1
            // 
            this.panelCup1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCup1.BackgroundImage")));
            this.panelCup1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCup1.Location = new System.Drawing.Point(570, 245);
            this.panelCup1.Name = "panelCup1";
            this.panelCup1.Size = new System.Drawing.Size(150, 150);
            this.panelCup1.TabIndex = 1;
            // 
            // FormGamesCups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(898, 577);
            this.Controls.Add(this.panelEnterBet);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.panelCup2);
            this.Controls.Add(this.panelCup3);
            this.Controls.Add(this.panelCup1);
            this.Name = "FormGamesCups";
            this.Text = "FormGamesCups";
            this.panelEnterBet.ResumeLayout(false);
            this.panelEnterBet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelCup1;
        private System.Windows.Forms.Panel panelCup2;
        private System.Windows.Forms.Panel panelCup3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelBet;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Panel panelEnterBet;
    }
}