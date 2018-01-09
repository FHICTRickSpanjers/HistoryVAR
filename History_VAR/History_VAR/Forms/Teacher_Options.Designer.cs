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
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_show_all_lessons
			// 
			this.btn_show_all_lessons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
			this.btn_show_all_lessons.FlatAppearance.BorderSize = 0;
			this.btn_show_all_lessons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_show_all_lessons.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 10.2F);
			this.btn_show_all_lessons.ForeColor = System.Drawing.Color.White;
			this.btn_show_all_lessons.Location = new System.Drawing.Point(137, 379);
			this.btn_show_all_lessons.Margin = new System.Windows.Forms.Padding(10);
			this.btn_show_all_lessons.Name = "btn_show_all_lessons";
			this.btn_show_all_lessons.Size = new System.Drawing.Size(608, 58);
			this.btn_show_all_lessons.TabIndex = 4;
			this.btn_show_all_lessons.Text = "Alle gemaakte lessen";
			this.btn_show_all_lessons.UseVisualStyleBackColor = false;
			this.btn_show_all_lessons.Click += new System.EventHandler(this.btn_show_all_lessons_Click);
			// 
			// btn_create_lesson
			// 
			this.btn_create_lesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
			this.btn_create_lesson.FlatAppearance.BorderSize = 0;
			this.btn_create_lesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_create_lesson.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 10.2F);
			this.btn_create_lesson.ForeColor = System.Drawing.Color.White;
			this.btn_create_lesson.Location = new System.Drawing.Point(137, 301);
			this.btn_create_lesson.Margin = new System.Windows.Forms.Padding(10);
			this.btn_create_lesson.Name = "btn_create_lesson";
			this.btn_create_lesson.Size = new System.Drawing.Size(608, 58);
			this.btn_create_lesson.TabIndex = 5;
			this.btn_create_lesson.Text = "Maak een nieuwe les";
			this.btn_create_lesson.UseVisualStyleBackColor = false;
			this.btn_create_lesson.Click += new System.EventHandler(this.btn_create_lesson_Click);
			// 
			// btn_logout
			// 
			this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
			this.btn_logout.FlatAppearance.BorderSize = 0;
			this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_logout.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 10.2F);
			this.btn_logout.ForeColor = System.Drawing.Color.White;
			this.btn_logout.Location = new System.Drawing.Point(137, 457);
			this.btn_logout.Margin = new System.Windows.Forms.Padding(10);
			this.btn_logout.Name = "btn_logout";
			this.btn_logout.Size = new System.Drawing.Size(608, 58);
			this.btn_logout.TabIndex = 6;
			this.btn_logout.Text = "Uitloggen";
			this.btn_logout.UseVisualStyleBackColor = false;
			this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Poetsen One", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(13)))), ((int)(((byte)(48)))));
			this.label2.Location = new System.Drawing.Point(12, 138);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(10);
			this.label2.Size = new System.Drawing.Size(858, 116);
			this.label2.TabIndex = 7;
			this.label2.Text = "Docent Opties";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Teacher_Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(216)))));
			this.BackgroundImage = global::History_VAR.Properties.Resources.HistoryVAR_BG;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(882, 653);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_logout);
			this.Controls.Add(this.btn_create_lesson);
			this.Controls.Add(this.btn_show_all_lessons);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "Teacher_Options";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Teacher_Options";
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_show_all_lessons;
        private System.Windows.Forms.Button btn_create_lesson;
        private System.Windows.Forms.Button btn_logout;
		private System.Windows.Forms.Label label2;
	}
}