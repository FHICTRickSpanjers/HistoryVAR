namespace History_VAR.Forms
{
    partial class User_Selection
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_teacher_user = new System.Windows.Forms.Button();
            this.btn_student_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(435, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you a teacher or student?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_teacher_user
            // 
            this.btn_teacher_user.Location = new System.Drawing.Point(12, 82);
            this.btn_teacher_user.Name = "btn_teacher_user";
            this.btn_teacher_user.Size = new System.Drawing.Size(435, 51);
            this.btn_teacher_user.TabIndex = 1;
            this.btn_teacher_user.Text = "Teacher";
            this.btn_teacher_user.UseVisualStyleBackColor = true;
            this.btn_teacher_user.Click += new System.EventHandler(this.btn_teacher_user_Click);
            // 
            // btn_student_user
            // 
            this.btn_student_user.Location = new System.Drawing.Point(12, 139);
            this.btn_student_user.Name = "btn_student_user";
            this.btn_student_user.Size = new System.Drawing.Size(435, 51);
            this.btn_student_user.TabIndex = 2;
            this.btn_student_user.Text = "Student";
            this.btn_student_user.UseVisualStyleBackColor = true;
            this.btn_student_user.Click += new System.EventHandler(this.btn_student_user_Click);
            // 
            // User_Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 206);
            this.Controls.Add(this.btn_student_user);
            this.Controls.Add(this.btn_teacher_user);
            this.Controls.Add(this.label1);
            this.Name = "User_Selection";
            this.Text = "s";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_teacher_user;
        private System.Windows.Forms.Button btn_student_user;
    }
}