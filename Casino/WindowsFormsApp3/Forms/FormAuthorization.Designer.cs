namespace WindowsFormsApp3
{
    partial class FormAuthorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.panelCreateAccount = new System.Windows.Forms.Panel();
            this.textBoxPasswordCreate = new System.Windows.Forms.TextBox();
            this.textBoxLoginCreate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPasswordConfirmCreate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelLogo.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCreateAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.panelLogo.Controls.Add(this.labelLogo);
            this.panelLogo.Location = new System.Drawing.Point(3, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 4;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // labelLogo
            // 
            this.labelLogo.AutoEllipsis = true;
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelLogo.Location = new System.Drawing.Point(39, 26);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(127, 29);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "More Gold";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLogo.Click += new System.EventHandler(this.labelLogo_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMain.Controls.Add(this.panelDesktopPanel);
            this.panelMain.Controls.Add(this.panelLogo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1228, 563);
            this.panelMain.TabIndex = 0;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelDesktopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktopPanel.Controls.Add(this.panel1);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1228, 563);
            this.panelDesktopPanel.TabIndex = 4;
            this.panelDesktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.panelCreateAccount);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxLogin);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.btnCreateAccount);
            this.panel1.Controls.Add(this.btnSignIn);
            this.panel1.Location = new System.Drawing.Point(268, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 429);
            this.panel1.TabIndex = 5;
            this.panel1.Tag = "";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(188, 202);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(263, 37);
            this.textBoxPassword.TabIndex = 11;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(188, 107);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(263, 37);
            this.textBoxLogin.TabIndex = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(184, 176);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(108, 23);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(184, 81);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(65, 23);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Login:";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreateAccount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateAccount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCreateAccount.Location = new System.Drawing.Point(153, 365);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(332, 32);
            this.btnCreateAccount.TabIndex = 3;
            this.btnCreateAccount.Text = "Don\'t have an account?";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSignIn.Location = new System.Drawing.Point(230, 282);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(180, 63);
            this.btnSignIn.TabIndex = 0;
            this.btnSignIn.Text = "Go";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // panelCreateAccount
            // 
            this.panelCreateAccount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelCreateAccount.Controls.Add(this.button2);
            this.panelCreateAccount.Controls.Add(this.button1);
            this.panelCreateAccount.Controls.Add(this.textBoxPasswordConfirmCreate);
            this.panelCreateAccount.Controls.Add(this.label3);
            this.panelCreateAccount.Controls.Add(this.textBoxPasswordCreate);
            this.panelCreateAccount.Controls.Add(this.textBoxLoginCreate);
            this.panelCreateAccount.Controls.Add(this.label1);
            this.panelCreateAccount.Controls.Add(this.label2);
            this.panelCreateAccount.Location = new System.Drawing.Point(0, 0);
            this.panelCreateAccount.Name = "panelCreateAccount";
            this.panelCreateAccount.Size = new System.Drawing.Size(640, 429);
            this.panelCreateAccount.TabIndex = 6;
            // 
            // textBoxPasswordCreate
            // 
            this.textBoxPasswordCreate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPasswordCreate.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPasswordCreate.Location = new System.Drawing.Point(188, 150);
            this.textBoxPasswordCreate.Name = "textBoxPasswordCreate";
            this.textBoxPasswordCreate.Size = new System.Drawing.Size(263, 37);
            this.textBoxPasswordCreate.TabIndex = 15;
            // 
            // textBoxLoginCreate
            // 
            this.textBoxLoginCreate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoginCreate.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLoginCreate.Location = new System.Drawing.Point(188, 64);
            this.textBoxLoginCreate.Name = "textBoxLoginCreate";
            this.textBoxLoginCreate.Size = new System.Drawing.Size(263, 37);
            this.textBoxLoginCreate.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(184, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(184, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Login:";
            // 
            // textBoxPasswordConfirmCreate
            // 
            this.textBoxPasswordConfirmCreate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPasswordConfirmCreate.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPasswordConfirmCreate.Location = new System.Drawing.Point(188, 239);
            this.textBoxPasswordConfirmCreate.Name = "textBoxPasswordConfirmCreate";
            this.textBoxPasswordConfirmCreate.Size = new System.Drawing.Size(263, 37);
            this.textBoxPasswordConfirmCreate.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(184, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Confirm the password:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(230, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 63);
            this.button1.TabIndex = 18;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(24, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 63);
            this.button2.TabIndex = 19;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 563);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAuthorization";
            this.Text = "More Gold";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelDesktopPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCreateAccount.ResumeLayout(false);
            this.panelCreateAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Panel panelCreateAccount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPasswordConfirmCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPasswordCreate;
        private System.Windows.Forms.TextBox textBoxLoginCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

