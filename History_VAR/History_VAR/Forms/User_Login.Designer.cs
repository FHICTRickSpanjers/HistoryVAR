namespace History_VAR.Forms
{
    partial class User_Login
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
            this.label_title_user_login = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title_user_login
            // 
            this.label_title_user_login.BackColor = System.Drawing.Color.Black;
            this.label_title_user_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label_title_user_login.ForeColor = System.Drawing.Color.White;
            this.label_title_user_login.Location = new System.Drawing.Point(12, 9);
            this.label_title_user_login.Name = "label_title_user_login";
            this.label_title_user_login.Padding = new System.Windows.Forms.Padding(10);
            this.label_title_user_login.Size = new System.Drawing.Size(375, 59);
            this.label_title_user_login.TabIndex = 1;
            this.label_title_user_login.Tag = "";
            this.label_title_user_login.Text = "USER LOGIN";
            this.label_title_user_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(202, 232);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(187, 52);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(14, 173);
            this.TB_Password.Multiline = true;
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(375, 43);
            this.TB_Password.TabIndex = 4;
            // 
            // TB_Username
            // 
            this.TB_Username.Location = new System.Drawing.Point(12, 98);
            this.TB_Username.Multiline = true;
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(375, 43);
            this.TB_Username.TabIndex = 5;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(11, 78);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(81, 17);
            this.label_username.TabIndex = 6;
            this.label_username.Text = "Username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(11, 153);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(77, 17);
            this.label_password.TabIndex = 7;
            this.label_password.Text = "Password";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 232);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(185, 52);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // User_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 309);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.TB_Username);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label_title_user_login);
            this.Name = "User_Login";
            this.Text = "User_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title_user_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button btn_back;
    }
}