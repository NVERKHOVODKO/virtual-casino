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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMult = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.textBoxBet = new System.Windows.Forms.TextBox();
            this.btnTake = new System.Windows.Forms.Button();
            this.lblYourBet = new System.Windows.Forms.Label();
            this.panelDesktop.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelDesktop.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.background_postal;
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktop.Controls.Add(this.panel1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1447, 802);
            this.panelDesktop.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(234)))));
            this.panel1.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.steel;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblYourBet);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.textBoxBet);
            this.panel1.Controls.Add(this.btnTake);
            this.panel1.Location = new System.Drawing.Point(179, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 687);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(99, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 103);
            this.label2.TabIndex = 5;
            this.label2.Text = "Balance:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(99, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 108);
            this.label1.TabIndex = 4;
            this.label1.Text = "48484";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.dude_jpg;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.labelMult);
            this.panel2.Location = new System.Drawing.Point(588, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 550);
            this.panel2.TabIndex = 3;
            // 
            // labelMult
            // 
            this.labelMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelMult.Font = new System.Drawing.Font("Palatino Linotype", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMult.ForeColor = System.Drawing.Color.Red;
            this.labelMult.Location = new System.Drawing.Point(52, 186);
            this.labelMult.Name = "labelMult";
            this.labelMult.Size = new System.Drawing.Size(428, 188);
            this.labelMult.TabIndex = 7;
            this.labelMult.Text = "X 1.43";
            this.labelMult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Gray;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGo.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGo.ForeColor = System.Drawing.Color.Black;
            this.btnGo.Location = new System.Drawing.Point(285, 545);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(183, 72);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxBet
            // 
            this.textBoxBet.BackColor = System.Drawing.Color.Gray;
            this.textBoxBet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBet.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBet.Location = new System.Drawing.Point(115, 419);
            this.textBoxBet.Name = "textBoxBet";
            this.textBoxBet.Size = new System.Drawing.Size(308, 91);
            this.textBoxBet.TabIndex = 1;
            this.textBoxBet.TextChanged += new System.EventHandler(this.textBoxBet_TextChanged);
            this.textBoxBet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBet_KeyPress);
            // 
            // btnTake
            // 
            this.btnTake.BackColor = System.Drawing.Color.Gray;
            this.btnTake.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTake.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTake.ForeColor = System.Drawing.Color.Black;
            this.btnTake.Location = new System.Drawing.Point(39, 545);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(183, 72);
            this.btnTake.TabIndex = 0;
            this.btnTake.Text = "TAKE";
            this.btnTake.UseVisualStyleBackColor = false;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // lblYourBet
            // 
            this.lblYourBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblYourBet.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYourBet.ForeColor = System.Drawing.Color.Black;
            this.lblYourBet.Location = new System.Drawing.Point(106, 306);
            this.lblYourBet.Name = "lblYourBet";
            this.lblYourBet.Size = new System.Drawing.Size(317, 87);
            this.lblYourBet.TabIndex = 8;
            this.lblYourBet.Text = "Your X: 1.43";
            this.lblYourBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormGamesCrush
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 802);
            this.Controls.Add(this.panelDesktop);
            this.Name = "FormGamesCrush";
            this.Text = "FormGamesCrush";
            this.panelDesktop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox textBoxBet;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label labelMult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblYourBet;
    }
}