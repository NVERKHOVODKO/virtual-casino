namespace WindowsFormsApp3
{
    partial class FormUser
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnGames = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLiders = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelMain = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.lblBalence = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblBalanceValue = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnAccount);
            this.panelMenu.Controls.Add(this.btnGames);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.btnLiders);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 638);
            this.panelMenu.TabIndex = 0;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.btnAccount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 406);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(200, 60);
            this.btnAccount.TabIndex = 7;
            this.btnAccount.Text = "Account";
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click_1);
            // 
            // btnGames
            // 
            this.btnGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnGames.FlatAppearance.BorderSize = 0;
            this.btnGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGames.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.btnGames.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGames.Location = new System.Drawing.Point(0, 274);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(200, 60);
            this.btnGames.TabIndex = 4;
            this.btnGames.Text = "Games";
            this.btnGames.UseVisualStyleBackColor = false;
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 205);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 60);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLiders
            // 
            this.btnLiders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnLiders.FlatAppearance.BorderSize = 0;
            this.btnLiders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiders.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.btnLiders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLiders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLiders.Location = new System.Drawing.Point(0, 340);
            this.btnLiders.Name = "btnLiders";
            this.btnLiders.Size = new System.Drawing.Size(200, 60);
            this.btnLiders.TabIndex = 5;
            this.btnLiders.Text = "Liders";
            this.btnLiders.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.panelLogo.Controls.Add(this.lblBalanceValue);
            this.panelLogo.Controls.Add(this.lblLogin);
            this.panelLogo.Controls.Add(this.lblBalence);
            this.panelLogo.Location = new System.Drawing.Point(3, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 172);
            this.panelLogo.TabIndex = 4;
            // 
            // labelMain
            // 
            this.labelMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Malgun Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMain.Location = new System.Drawing.Point(548, 18);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(117, 45);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "HOME";
            this.labelMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMain.Click += new System.EventHandler(this.labelMain_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitle.Controls.Add(this.buttonBack);
            this.panelTitle.Controls.Add(this.labelMain);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(200, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1199, 80);
            this.panelTitle.TabIndex = 3;
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.Без_имени_51;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(80, 80);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMain.Controls.Add(this.panelDesktopPanel);
            this.panelMain.Controls.Add(this.panelTitle);
            this.panelMain.Controls.Add(this.panelLogo);
            this.panelMain.Controls.Add(this.panelMenu);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1399, 638);
            this.panelMain.TabIndex = 1;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(200, 80);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1199, 558);
            this.panelDesktopPanel.TabIndex = 4;
            // 
            // lblBalence
            // 
            this.lblBalence.AutoSize = true;
            this.lblBalence.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalence.ForeColor = System.Drawing.Color.White;
            this.lblBalence.Location = new System.Drawing.Point(3, 61);
            this.lblBalence.Name = "lblBalence";
            this.lblBalence.Size = new System.Drawing.Size(129, 41);
            this.lblBalence.TabIndex = 8;
            this.lblBalence.Text = "Balance:";
            this.lblBalence.Click += new System.EventHandler(this.lblBalence_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(3, 9);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(162, 31);
            this.lblLogin.TabIndex = 9;
            this.lblLogin.Text = "nverkhovodko";
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.AutoSize = true;
            this.lblBalanceValue.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceValue.ForeColor = System.Drawing.Color.White;
            this.lblBalanceValue.Location = new System.Drawing.Point(9, 102);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(107, 38);
            this.lblBalanceValue.TabIndex = 10;
            this.lblBalanceValue.Text = "984734";
            this.lblBalanceValue.Click += new System.EventHandler(this.lblBalanceValue_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 638);
            this.Controls.Add(this.panelMain);
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnGames;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLiders;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Label lblBalence;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblBalanceValue;
    }
}