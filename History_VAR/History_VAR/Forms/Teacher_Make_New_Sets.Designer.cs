namespace History_VAR.Forms
{
    partial class Teacher_Make_New_Sets
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
            this.label_new_lesson = new System.Windows.Forms.Label();
            this.TB_Desc = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_save_lesson = new System.Windows.Forms.Button();
            this.GB_ListOfObjects = new System.Windows.Forms.GroupBox();
            this.LB_Object_Items = new System.Windows.Forms.ListBox();
            this.label_lesson_title = new System.Windows.Forms.Label();
            this.TB_Title = new System.Windows.Forms.TextBox();
            this.label_published = new System.Windows.Forms.Label();
            this.CB_Lesson_Status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_objects = new System.Windows.Forms.Button();
            this.label_Made_By = new System.Windows.Forms.Label();
            this.TB_Made_By = new System.Windows.Forms.TextBox();
            this.TB_Subject = new System.Windows.Forms.TextBox();
            this.label_subject = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Classes = new System.Windows.Forms.ComboBox();
            this.GB_ListOfObjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_new_lesson
            // 
            this.label_new_lesson.BackColor = System.Drawing.Color.Black;
            this.label_new_lesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label_new_lesson.ForeColor = System.Drawing.Color.White;
            this.label_new_lesson.Location = new System.Drawing.Point(12, 9);
            this.label_new_lesson.Name = "label_new_lesson";
            this.label_new_lesson.Padding = new System.Windows.Forms.Padding(10);
            this.label_new_lesson.Size = new System.Drawing.Size(705, 59);
            this.label_new_lesson.TabIndex = 4;
            this.label_new_lesson.Tag = "";
            this.label_new_lesson.Text = "CREATE NEW LESSON";
            this.label_new_lesson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Desc
            // 
            this.TB_Desc.Location = new System.Drawing.Point(12, 283);
            this.TB_Desc.Multiline = true;
            this.TB_Desc.Name = "TB_Desc";
            this.TB_Desc.Size = new System.Drawing.Size(705, 195);
            this.TB_Desc.TabIndex = 5;
            this.TB_Desc.Text = "Enter your information here...";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 484);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 35);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_save_lesson
            // 
            this.btn_save_lesson.Location = new System.Drawing.Point(642, 484);
            this.btn_save_lesson.Name = "btn_save_lesson";
            this.btn_save_lesson.Size = new System.Drawing.Size(75, 35);
            this.btn_save_lesson.TabIndex = 7;
            this.btn_save_lesson.Text = "Save";
            this.btn_save_lesson.UseVisualStyleBackColor = true;
            this.btn_save_lesson.Click += new System.EventHandler(this.btn_save_lesson_Click);
            // 
            // GB_ListOfObjects
            // 
            this.GB_ListOfObjects.Controls.Add(this.LB_Object_Items);
            this.GB_ListOfObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_ListOfObjects.Location = new System.Drawing.Point(369, 85);
            this.GB_ListOfObjects.Name = "GB_ListOfObjects";
            this.GB_ListOfObjects.Size = new System.Drawing.Size(348, 168);
            this.GB_ListOfObjects.TabIndex = 8;
            this.GB_ListOfObjects.TabStop = false;
            this.GB_ListOfObjects.Text = "List of Objects";
            // 
            // LB_Object_Items
            // 
            this.LB_Object_Items.BackColor = System.Drawing.SystemColors.Control;
            this.LB_Object_Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LB_Object_Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Object_Items.FormattingEnabled = true;
            this.LB_Object_Items.ItemHeight = 16;
            this.LB_Object_Items.Location = new System.Drawing.Point(6, 21);
            this.LB_Object_Items.Name = "LB_Object_Items";
            this.LB_Object_Items.Size = new System.Drawing.Size(336, 144);
            this.LB_Object_Items.TabIndex = 0;
            // 
            // label_lesson_title
            // 
            this.label_lesson_title.AutoSize = true;
            this.label_lesson_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lesson_title.Location = new System.Drawing.Point(12, 88);
            this.label_lesson_title.Name = "label_lesson_title";
            this.label_lesson_title.Size = new System.Drawing.Size(40, 17);
            this.label_lesson_title.TabIndex = 9;
            this.label_lesson_title.Text = "Title";
            // 
            // TB_Title
            // 
            this.TB_Title.Location = new System.Drawing.Point(136, 85);
            this.TB_Title.Name = "TB_Title";
            this.TB_Title.Size = new System.Drawing.Size(217, 22);
            this.TB_Title.TabIndex = 10;
            // 
            // label_published
            // 
            this.label_published.AutoSize = true;
            this.label_published.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_published.Location = new System.Drawing.Point(14, 116);
            this.label_published.Name = "label_published";
            this.label_published.Size = new System.Drawing.Size(79, 17);
            this.label_published.TabIndex = 11;
            this.label_published.Text = "Published";
            // 
            // CB_Lesson_Status
            // 
            this.CB_Lesson_Status.FormattingEnabled = true;
            this.CB_Lesson_Status.Items.AddRange(new object[] {
            "Published",
            "Draft"});
            this.CB_Lesson_Status.Location = new System.Drawing.Point(136, 113);
            this.CB_Lesson_Status.Name = "CB_Lesson_Status";
            this.CB_Lesson_Status.Size = new System.Drawing.Size(217, 24);
            this.CB_Lesson_Status.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Objects";
            // 
            // btn_add_objects
            // 
            this.btn_add_objects.Location = new System.Drawing.Point(136, 234);
            this.btn_add_objects.Name = "btn_add_objects";
            this.btn_add_objects.Size = new System.Drawing.Size(217, 34);
            this.btn_add_objects.TabIndex = 16;
            this.btn_add_objects.Text = "Add Objects";
            this.btn_add_objects.UseVisualStyleBackColor = true;
            this.btn_add_objects.Click += new System.EventHandler(this.btn_add_objects_Click);
            // 
            // label_Made_By
            // 
            this.label_Made_By.AutoSize = true;
            this.label_Made_By.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Made_By.Location = new System.Drawing.Point(14, 146);
            this.label_Made_By.Name = "label_Made_By";
            this.label_Made_By.Size = new System.Drawing.Size(70, 17);
            this.label_Made_By.TabIndex = 17;
            this.label_Made_By.Text = "Made By";
            // 
            // TB_Made_By
            // 
            this.TB_Made_By.Location = new System.Drawing.Point(136, 143);
            this.TB_Made_By.Name = "TB_Made_By";
            this.TB_Made_By.Size = new System.Drawing.Size(217, 22);
            this.TB_Made_By.TabIndex = 18;
            // 
            // TB_Subject
            // 
            this.TB_Subject.Location = new System.Drawing.Point(136, 171);
            this.TB_Subject.Name = "TB_Subject";
            this.TB_Subject.Size = new System.Drawing.Size(217, 22);
            this.TB_Subject.TabIndex = 20;
            // 
            // label_subject
            // 
            this.label_subject.AutoSize = true;
            this.label_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subject.Location = new System.Drawing.Point(14, 174);
            this.label_subject.Name = "label_subject";
            this.label_subject.Size = new System.Drawing.Size(62, 17);
            this.label_subject.TabIndex = 19;
            this.label_subject.Text = "Subject";
            // 
            // btn_update
            // 
            this.btn_update.Enabled = false;
            this.btn_update.Location = new System.Drawing.Point(561, 484);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 35);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Classes";
            // 
            // CB_Classes
            // 
            this.CB_Classes.FormattingEnabled = true;
            this.CB_Classes.Items.AddRange(new object[] {
            "All"});
            this.CB_Classes.Location = new System.Drawing.Point(136, 199);
            this.CB_Classes.Name = "CB_Classes";
            this.CB_Classes.Size = new System.Drawing.Size(217, 24);
            this.CB_Classes.TabIndex = 23;
            // 
            // Teacher_Make_New_Sets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 531);
            this.Controls.Add(this.CB_Classes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.TB_Subject);
            this.Controls.Add(this.label_subject);
            this.Controls.Add(this.TB_Made_By);
            this.Controls.Add(this.label_Made_By);
            this.Controls.Add(this.btn_add_objects);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_Lesson_Status);
            this.Controls.Add(this.label_published);
            this.Controls.Add(this.TB_Title);
            this.Controls.Add(this.label_lesson_title);
            this.Controls.Add(this.GB_ListOfObjects);
            this.Controls.Add(this.btn_save_lesson);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.TB_Desc);
            this.Controls.Add(this.label_new_lesson);
            this.Name = "Teacher_Make_New_Sets";
            this.Text = "Teacher_Make_New_Sets";
            this.GB_ListOfObjects.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_new_lesson;
        private System.Windows.Forms.TextBox TB_Desc;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_save_lesson;
        private System.Windows.Forms.GroupBox GB_ListOfObjects;
        private System.Windows.Forms.Label label_lesson_title;
        private System.Windows.Forms.TextBox TB_Title;
        private System.Windows.Forms.Label label_published;
        private System.Windows.Forms.ComboBox CB_Lesson_Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add_objects;
        private System.Windows.Forms.Label label_Made_By;
        private System.Windows.Forms.TextBox TB_Made_By;
        private System.Windows.Forms.ListBox LB_Object_Items;
        private System.Windows.Forms.TextBox TB_Subject;
        private System.Windows.Forms.Label label_subject;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Classes;
    }
}