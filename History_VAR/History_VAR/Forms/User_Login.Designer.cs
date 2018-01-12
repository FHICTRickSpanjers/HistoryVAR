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
			this.btn_login = new System.Windows.Forms.Button();
			this.TB_Password = new System.Windows.Forms.TextBox();
			this.TB_Username = new System.Windows.Forms.TextBox();
			this.btn_back = new System.Windows.Forms.Button();
			this.label_login = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_login
			// 
			this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
			this.btn_login.FlatAppearance.BorderSize = 0;
			this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_login.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 10.2F);
			this.btn_login.ForeColor = System.Drawing.Color.White;
			this.btn_login.Location = new System.Drawing.Point(109, 438);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(665, 52);
			this.btn_login.TabIndex = 2;
			this.btn_login.Text = "Inloggen";
			this.btn_login.UseVisualStyleBackColor = false;
			this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
			// 
			// TB_Password
			// 
			this.TB_Password.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 19.8F);
			this.TB_Password.Location = new System.Drawing.Point(109, 350);
			this.TB_Password.Name = "TB_Password";
			this.TB_Password.PasswordChar = '*';
			this.TB_Password.Size = new System.Drawing.Size(665, 47);
			this.TB_Password.TabIndex = 4;
			this.TB_Password.TabStop = false;
			this.TB_Password.Text = "Password";
			this.TB_Password.Click += new System.EventHandler(this.TB_Password_Click);
			// 
			// TB_Username
			// 
			this.TB_Username.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TB_Username.Location = new System.Drawing.Point(109, 280);
			this.TB_Username.Name = "TB_Username";
			this.TB_Username.Size = new System.Drawing.Size(665, 47);
			this.TB_Username.TabIndex = 5;
			this.TB_Username.Text = "Gebruikersnaam";
			this.TB_Username.Click += new System.EventHandler(this.TB_Username_Click);
			// 
			// btn_back
			// 
			this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
			this.btn_back.FlatAppearance.BorderSize = 0;
			this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_back.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 10.2F);
			this.btn_back.ForeColor = System.Drawing.Color.White;
			this.btn_back.Location = new System.Drawing.Point(109, 509);
			this.btn_back.Name = "btn_back";
			this.btn_back.Size = new System.Drawing.Size(665, 52);
			this.btn_back.TabIndex = 8;
			this.btn_back.Text = "Terug";
			this.btn_back.UseVisualStyleBackColor = false;
			this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
			// 
			// label_login
			// 
			this.label_login.BackColor = System.Drawing.Color.Transparent;
			this.label_login.Font = new System.Drawing.Font("Poetsen One", 72F, System.Drawing.FontStyle.Bold);
			this.label_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(13)))), ((int)(((byte)(48)))));
			this.label_login.Location = new System.Drawing.Point(12, 91);
			this.label_login.Name = "label_login";
			this.label_login.Padding = new System.Windows.Forms.Padding(10);
			this.label_login.Size = new System.Drawing.Size(858, 164);
			this.label_login.TabIndex = 10;
			this.label_login.Text = "History VAR";
			this.label_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// User_Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::History_VAR.Properties.Resources.HistoryVAR_BG;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(882, 653);
			this.Controls.Add(this.label_login);
			this.Controls.Add(this.btn_back);
			this.Controls.Add(this.TB_Username);
			this.Controls.Add(this.TB_Password);
			this.Controls.Add(this.btn_login);
			this.DoubleBuffered = true;
			this.Name = "User_Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "User_Login";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label_login;
    }
}