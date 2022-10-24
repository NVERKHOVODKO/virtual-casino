namespace WindowsFormsApp3.Forms
{
    partial class FormUpdateUser
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
            this.lblEdit = new System.Windows.Forms.Label();
            this.panelCreateAccount = new System.Windows.Forms.Panel();
            this.textBoxAccess = new System.Windows.Forms.TextBox();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.lblAccess = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCreateAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEdit.ForeColor = System.Drawing.Color.White;
            this.lblEdit.Location = new System.Drawing.Point(205, 21);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(82, 44);
            this.lblEdit.TabIndex = 21;
            this.lblEdit.Text = "Edit";
            // 
            // panelCreateAccount
            // 
            this.panelCreateAccount.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelCreateAccount.Controls.Add(this.textBoxAccess);
            this.panelCreateAccount.Controls.Add(this.textBoxBalance);
            this.panelCreateAccount.Controls.Add(this.lblAccess);
            this.panelCreateAccount.Controls.Add(this.lblBalance);
            this.panelCreateAccount.Controls.Add(this.lblEdit);
            this.panelCreateAccount.Controls.Add(this.button2);
            this.panelCreateAccount.Controls.Add(this.btnEdit);
            this.panelCreateAccount.Controls.Add(this.textBoxPassword);
            this.panelCreateAccount.Controls.Add(this.textBoxLogin);
            this.panelCreateAccount.Controls.Add(this.label1);
            this.panelCreateAccount.Controls.Add(this.label2);
            this.panelCreateAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCreateAccount.Location = new System.Drawing.Point(0, 0);
            this.panelCreateAccount.Name = "panelCreateAccount";
            this.panelCreateAccount.Size = new System.Drawing.Size(492, 476);
            this.panelCreateAccount.TabIndex = 8;
            // 
            // textBoxAccess
            // 
            this.textBoxAccess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAccess.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAccess.Location = new System.Drawing.Point(85, 335);
            this.textBoxAccess.Name = "textBoxAccess";
            this.textBoxAccess.Size = new System.Drawing.Size(332, 37);
            this.textBoxAccess.TabIndex = 25;
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBalance.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBalance.Location = new System.Drawing.Point(84, 269);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(332, 37);
            this.textBoxBalance.TabIndex = 24;
            // 
            // lblAccess
            // 
            this.lblAccess.AutoSize = true;
            this.lblAccess.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAccess.Location = new System.Drawing.Point(81, 309);
            this.lblAccess.Name = "lblAccess";
            this.lblAccess.Size = new System.Drawing.Size(85, 23);
            this.lblAccess.TabIndex = 23;
            this.lblAccess.Text = "Access:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBalance.Location = new System.Drawing.Point(81, 243);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(97, 23);
            this.lblBalance.TabIndex = 22;
            this.lblBalance.Text = "Balance:";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.arrow_back1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(19, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(84, 396);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(332, 53);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(84, 197);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(332, 37);
            this.textBoxPassword.TabIndex = 15;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(84, 131);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(332, 37);
            this.textBoxLogin.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(80, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(80, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Login:";
            // 
            // FormUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 476);
            this.Controls.Add(this.panelCreateAccount);
            this.Name = "FormUpdateUser";
            this.Text = "FormUpdateUser";
            this.panelCreateAccount.ResumeLayout(false);
            this.panelCreateAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Panel panelCreateAccount;
        private System.Windows.Forms.TextBox textBoxAccess;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Label lblAccess;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}