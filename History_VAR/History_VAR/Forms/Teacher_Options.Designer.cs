namespace History_VAR.Forms
{
    partial class Teacher_Options
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
            this.btn_show_all_lessons = new System.Windows.Forms.Button();
            this.btn_create_lesson = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
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
            this.label_title_user_login.TabIndex = 2;
            this.label_title_user_login.Tag = "";
            this.label_title_user_login.Text = "TEACHER OPTIONS";
            this.label_title_user_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_show_all_lessons
            // 
            this.btn_show_all_lessons.Location = new System.Drawing.Point(12, 134);
            this.btn_show_all_lessons.Name = "btn_show_all_lessons";
            this.btn_show_all_lessons.Size = new System.Drawing.Size(375, 46);
            this.btn_show_all_lessons.TabIndex = 4;
            this.btn_show_all_lessons.Text = "Show All Lessons";
            this.btn_show_all_lessons.UseVisualStyleBackColor = true;
            this.btn_show_all_lessons.Click += new System.EventHandler(this.btn_show_all_lessons_Click);
            // 
            // btn_create_lesson
            // 
            this.btn_create_lesson.Location = new System.Drawing.Point(12, 82);
            this.btn_create_lesson.Name = "btn_create_lesson";
            this.btn_create_lesson.Size = new System.Drawing.Size(375, 46);
            this.btn_create_lesson.TabIndex = 5;
            this.btn_create_lesson.Text = "Create Lesson";
            this.btn_create_lesson.UseVisualStyleBackColor = true;
            this.btn_create_lesson.Click += new System.EventHandler(this.btn_create_lesson_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(12, 186);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(375, 46);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Teacher_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 250);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_create_lesson);
            this.Controls.Add(this.btn_show_all_lessons);
            this.Controls.Add(this.label_title_user_login);
            this.Name = "Teacher_Options";
            this.Text = "Teacher_Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_title_user_login;
        private System.Windows.Forms.Button btn_show_all_lessons;
        private System.Windows.Forms.Button btn_create_lesson;
        private System.Windows.Forms.Button btn_logout;
    }
}