namespace WindowsFormsApp3.Forms
{
    partial class FormGames
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
            this.panelGames = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGames_2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelGames.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGames
            // 
            this.panelGames.BackColor = System.Drawing.SystemColors.Control;
            this.panelGames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGames.Controls.Add(this.button1);
            this.panelGames.Controls.Add(this.buttonGames_2);
            this.panelGames.Controls.Add(this.button2);
            this.panelGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGames.Location = new System.Drawing.Point(0, 0);
            this.panelGames.Name = "panelGames";
            this.panelGames.Size = new System.Drawing.Size(800, 450);
            this.panelGames.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.wild_west_tag;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(15, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 250);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGames_2
            // 
            this.buttonGames_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGames_2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGames_2.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.dude;
            this.buttonGames_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGames_2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonGames_2.FlatAppearance.BorderSize = 0;
            this.buttonGames_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGames_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGames_2.ForeColor = System.Drawing.Color.Brown;
            this.buttonGames_2.Location = new System.Drawing.Point(527, 29);
            this.buttonGames_2.Name = "buttonGames_2";
            this.buttonGames_2.Size = new System.Drawing.Size(250, 250);
            this.buttonGames_2.TabIndex = 3;
            this.buttonGames_2.UseVisualStyleBackColor = true;
            this.buttonGames_2.Click += new System.EventHandler(this.buttonGames_2_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.Sapper_game_icon1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(271, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 250);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGames);
            this.Name = "FormGames";
            this.Text = "FormGames";
            this.Load += new System.EventHandler(this.FormGames_Load);
            this.panelGames.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGames_2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelGames;
    }
}