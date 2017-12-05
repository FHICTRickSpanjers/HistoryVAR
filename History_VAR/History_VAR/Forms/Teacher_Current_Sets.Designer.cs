namespace History_VAR.Forms
{
    partial class Teacher_Current_Sets
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
            this.label_available_lessons = new System.Windows.Forms.Label();
            this.CB_Lessons = new System.Windows.Forms.ComboBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_publish = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_available_lessons
            // 
            this.label_available_lessons.BackColor = System.Drawing.Color.Black;
            this.label_available_lessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label_available_lessons.ForeColor = System.Drawing.Color.White;
            this.label_available_lessons.Location = new System.Drawing.Point(12, 9);
            this.label_available_lessons.Name = "label_available_lessons";
            this.label_available_lessons.Padding = new System.Windows.Forms.Padding(10);
            this.label_available_lessons.Size = new System.Drawing.Size(578, 59);
            this.label_available_lessons.TabIndex = 3;
            this.label_available_lessons.Tag = "";
            this.label_available_lessons.Text = "CURRENT LESSONS";
            this.label_available_lessons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CB_Lessons
            // 
            this.CB_Lessons.FormattingEnabled = true;
            this.CB_Lessons.Location = new System.Drawing.Point(12, 80);
            this.CB_Lessons.Name = "CB_Lessons";
            this.CB_Lessons.Size = new System.Drawing.Size(578, 24);
            this.CB_Lessons.TabIndex = 4;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(12, 110);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(275, 41);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Edit Lesson";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 157);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(275, 41);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_publish
            // 
            this.btn_publish.Location = new System.Drawing.Point(293, 157);
            this.btn_publish.Name = "btn_publish";
            this.btn_publish.Size = new System.Drawing.Size(297, 41);
            this.btn_publish.TabIndex = 11;
            this.btn_publish.Text = "Publish Lesson";
            this.btn_publish.UseVisualStyleBackColor = true;
            this.btn_publish.Click += new System.EventHandler(this.btn_publish_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(293, 110);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(297, 41);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete Lesson";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Teacher_Current_Sets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 219);
            this.Controls.Add(this.btn_publish);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.CB_Lessons);
            this.Controls.Add(this.label_available_lessons);
            this.Name = "Teacher_Current_Sets";
            this.Text = "Teacher_Current_Sets";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_available_lessons;
        private System.Windows.Forms.ComboBox CB_Lessons;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_publish;
        private System.Windows.Forms.Button btn_delete;
    }
}