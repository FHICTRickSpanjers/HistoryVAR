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
            this.btn_show_all_lessons = new System.Windows.Forms.Button();
            this.btn_create_lesson = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label_login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_show_all_lessons
            // 
            this.btn_show_all_lessons.BackColor = System.Drawing.Color.White;
            this.btn_show_all_lessons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_all_lessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_show_all_lessons.Location = new System.Drawing.Point(87, 273);
            this.btn_show_all_lessons.Margin = new System.Windows.Forms.Padding(10);
            this.btn_show_all_lessons.Name = "btn_show_all_lessons";
            this.btn_show_all_lessons.Size = new System.Drawing.Size(608, 58);
            this.btn_show_all_lessons.TabIndex = 4;
            this.btn_show_all_lessons.Text = "Show All Lessons";
            this.btn_show_all_lessons.UseVisualStyleBackColor = false;
            this.btn_show_all_lessons.Click += new System.EventHandler(this.btn_show_all_lessons_Click);
            // 
            // btn_create_lesson
            // 
            this.btn_create_lesson.BackColor = System.Drawing.Color.White;
            this.btn_create_lesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create_lesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_create_lesson.ForeColor = System.Drawing.Color.Black;
            this.btn_create_lesson.Location = new System.Drawing.Point(87, 195);
            this.btn_create_lesson.Margin = new System.Windows.Forms.Padding(10);
            this.btn_create_lesson.Name = "btn_create_lesson";
            this.btn_create_lesson.Size = new System.Drawing.Size(608, 58);
            this.btn_create_lesson.TabIndex = 5;
            this.btn_create_lesson.Text = "Create Lesson";
            this.btn_create_lesson.UseVisualStyleBackColor = false;
            this.btn_create_lesson.Click += new System.EventHandler(this.btn_create_lesson_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.White;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.Location = new System.Drawing.Point(87, 351);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(10);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(608, 58);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.Transparent;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold);
            this.label_login.ForeColor = System.Drawing.Color.White;
            this.label_login.Location = new System.Drawing.Point(39, 20);
            this.label_login.Name = "label_login";
            this.label_login.Padding = new System.Windows.Forms.Padding(10);
            this.label_login.Size = new System.Drawing.Size(697, 115);
            this.label_login.TabIndex = 11;
            this.label_login.Text = "Teacher Options";
            this.label_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Teacher_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_create_lesson);
            this.Controls.Add(this.btn_show_all_lessons);
            this.Name = "Teacher_Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher_Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_show_all_lessons;
        private System.Windows.Forms.Button btn_create_lesson;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label_login;
    }
}