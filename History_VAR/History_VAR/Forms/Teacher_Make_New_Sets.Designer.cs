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
			this.TB_Desc = new System.Windows.Forms.TextBox();
			this.btn_back = new System.Windows.Forms.Button();
			this.btn_save_lesson = new System.Windows.Forms.Button();
			this.GB_ListOfObjects = new System.Windows.Forms.GroupBox();
			this.LB_Art_Items = new System.Windows.Forms.ListBox();
			this.label_lesson_title = new System.Windows.Forms.Label();
			this.TB_Title = new System.Windows.Forms.TextBox();
			this.label_published = new System.Windows.Forms.Label();
			this.CB_Lesson_Status = new System.Windows.Forms.ComboBox();
			this.btn_add_objects = new System.Windows.Forms.Button();
			this.label_Made_By = new System.Windows.Forms.Label();
			this.TB_Made_By = new System.Windows.Forms.TextBox();
			this.TB_Subject = new System.Windows.Forms.TextBox();
			this.label_subject = new System.Windows.Forms.Label();
			this.btn_update = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.CB_Classes = new System.Windows.Forms.ComboBox();
			this.btn_add_images = new System.Windows.Forms.Button();
			this.btn_Add_Image_to_system = new System.Windows.Forms.Button();
			this.LB_Images = new System.Windows.Forms.ListBox();
			this.GB_Images = new System.Windows.Forms.GroupBox();
			this.CB_Art = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.LBL_Title_New_Set = new System.Windows.Forms.Label();
			this.GB_ListOfObjects.SuspendLayout();
			this.GB_Images.SuspendLayout();
			this.SuspendLayout();
			// 
			// TB_Desc
			// 
			this.TB_Desc.BackColor = System.Drawing.Color.White;
			this.TB_Desc.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 10F);
			this.TB_Desc.ForeColor = System.Drawing.Color.Black;
			this.TB_Desc.Location = new System.Drawing.Point(16, 443);
			this.TB_Desc.Multiline = true;
			this.TB_Desc.Name = "TB_Desc";
			this.TB_Desc.Size = new System.Drawing.Size(1213, 195);
			this.TB_Desc.TabIndex = 5;
			this.TB_Desc.Text = "Voeg je informatie toe...";
			// 
			// btn_back
			// 
			this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
			this.btn_back.FlatAppearance.BorderSize = 0;
			this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_back.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 10.2F);
			this.btn_back.ForeColor = System.Drawing.Color.White;
			this.btn_back.Location = new System.Drawing.Point(16, 659);
			this.btn_back.Name = "btn_back";
			this.btn_back.Size = new System.Drawing.Size(175, 46);
			this.btn_back.TabIndex = 6;
			this.btn_back.Text = "Terug";
			this.btn_back.UseVisualStyleBackColor = false;
			this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
			// 
			// btn_save_lesson
			// 
			this.btn_save_lesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
			this.btn_save_lesson.FlatAppearance.BorderSize = 0;
			this.btn_save_lesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_save_lesson.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 10.2F);
			this.btn_save_lesson.ForeColor = System.Drawing.Color.White;
			this.btn_save_lesson.Location = new System.Drawing.Point(1054, 659);
			this.btn_save_lesson.Name = "btn_save_lesson";
			this.btn_save_lesson.Size = new System.Drawing.Size(175, 46);
			this.btn_save_lesson.TabIndex = 7;
			this.btn_save_lesson.Text = "Opslaan";
			this.btn_save_lesson.UseVisualStyleBackColor = false;
			this.btn_save_lesson.Click += new System.EventHandler(this.btn_save_lesson_Click);
			// 
			// GB_ListOfObjects
			// 
			this.GB_ListOfObjects.BackColor = System.Drawing.Color.Transparent;
			this.GB_ListOfObjects.Controls.Add(this.LB_Art_Items);
			this.GB_ListOfObjects.Font = new System.Drawing.Font("AvenirNext LT Pro Bold", 10.2F, System.Drawing.FontStyle.Bold);
			this.GB_ListOfObjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(13)))), ((int)(((byte)(48)))));
			this.GB_ListOfObjects.Location = new System.Drawing.Point(442, 161);
			this.GB_ListOfObjects.Name = "GB_ListOfObjects";
			this.GB_ListOfObjects.Size = new System.Drawing.Size(380, 191);
			this.GB_ListOfObjects.TabIndex = 8;
			this.GB_ListOfObjects.TabStop = false;
			this.GB_ListOfObjects.Text = "Lijst van 3D Kunst Objecten in les";
			// 
			// LB_Art_Items
			// 
			this.LB_Art_Items.BackColor = System.Drawing.Color.White;
			this.LB_Art_Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LB_Art_Items.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 10F);
			this.LB_Art_Items.ForeColor = System.Drawing.Color.Black;
			this.LB_Art_Items.FormattingEnabled = true;
			this.LB_Art_Items.ItemHeight = 20;
			this.LB_Art_Items.Location = new System.Drawing.Point(14, 27);
			this.LB_Art_Items.Name = "LB_Art_Items";
			this.LB_Art_Items.Size = new System.Drawing.Size(360, 160);
			this.LB_Art_Items.TabIndex = 0;
			this.LB_Art_Items.DoubleClick += new System.EventHandler(this.LB_Art_Items_DoubleClick);
			// 
			// label_lesson_title
			// 
			this.label_lesson_title.AutoSize = true;
			this.label_lesson_title.BackColor = System.Drawing.Color.Transparent;
			this.label_lesson_title.Font = new System.Drawing.Font("AvenirNext LT Pro Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_lesson_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(13)))), ((int)(((byte)(48)))));
			this.label_lesson_title.Location = new System.Drawing.Point(21, 163);
			this.label_lesson_title.Name = "label_lesson_title";
			this.label_lesson_title.Size = new System.Drawing.Size(46, 21);
			this.label_lesson_title.TabIndex = 9;
			this.label_lesson_title.Text = "Titel";
			// 
			// TB_Title
			// 
			this.TB_Title.BackColor = System.Drawing.Color.White;
			this.TB_Title.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 10F);
			this.TB_Title.ForeColor = System.Drawing.Color.Black;
			this.TB_Title.Location = new System.Drawing.Point(210, 161);
			this.TB_Title.Name = "TB_Title";
			this.TB_Title.Size = new System.Drawing.Size(207, 27);
			this.TB_Title.TabIndex = 10;
			// 
			// label_published
			// 
			this.label_published.AutoSize = true;
			this.label_published.BackColor = System.Drawing.Color.Transparent;
			this.label_published.Font = new System.Drawing.Font("AvenirNext LT Pro Bold", 10.2F, System.Drawing.FontStyle.Bold);
			this.label_published.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(13)))), ((int)(((byte)(48)))));
			this.label_published.Location = new System.Drawing.Point(21, 195);
			this.label_published.Name = "label_published";
			this.label_published.Size = new System.Drawing.Size(90, 21);
			this.label_published.TabIndex = 11;
			this.label_published.Text = "Published";
			// 
			// CB_Lesson_Status
			// 
			this.CB_Lesson_Status.BackColor = System.Drawing.Color.White;
			this.CB_Lesson_Status.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 10F);
			this.CB_Lesson_Status.ForeColor = System.Drawing.Color.Black;
			this.CB_Lesson_Status.FormattingEnabled = true;
			this.CB_Lesson_Status.Items.AddRange(new object[] {
            "Published",
            "Draft"});
			this.CB_Lesson_Status.Location = new System.Drawing.Point(210, 193);
			this.CB_Lesson_Status.Name = "CB_Lesson_Status";
			this.CB_Lesson_Status.Size = new System.Drawing.Size(207, 28);
			this.CB_Lesson_Status.TabIndex = 12;
			// 
			// btn_add_objects
			// 
			this.btn_add_objects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
			this.btn_add_objects.FlatAppearance.BorderSize = 0;
			this.btn_add_objects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_add_objects.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 10.2F);
			this.btn_add_objects.ForeColor = System.Drawing.Color.White;
			this.btn_add_objects.Location = new System.Drawing.Point(22, 357);
			this.btn_add_objects.Name = "btn_add_objects";
			this.btn_add_objects.Size = new System.Drawing.Size(395, 51);
			this.btn_add_objects.TabIndex = 16;
			this.btn_add_objects.Text = "Voeg 3D Art object toe aan les";
			this.btn_add_objects.UseVisualStyleBackColor = false;
			this.btn_add_objects.Click += new System.EventHandler(this.btn_add_objects_Click);
			// 
			// label_Made_By
			// 
			this.label_Made_By.AutoSize = true;
			this.label_Made_By.BackColor = System.Drawing.Color.Transparent;
			this.label_Made_By.Font = new System.Drawing.Font("AvenirNext LT Pro Bold", 10.2F, System.Drawing.FontStyle.Bold);
			this.label_Made_By.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(13)))), ((int)(((byte)(48)))));
			this.label_Made_By.Location = new System.Drawing.Point(19, 227);
			this.label_Made_By.Name = "label_Made_By";
			this.label_Made_By.Size = new System.Drawing.Size(129, 21);
			this.label_Made_By.TabIndex = 17;
			this.label_Made_By.Text = "Gemaakt door";
			// 
			// TB_Made_By
			// 
			this.TB_Made_By.BackColor = System.Drawing.Color.White;
			this.TB_Made_By.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 10F);
			this.TB_Made_By.ForeColor = System.Drawing.Color.Black;
			this.TB_Made_By.Location = new System.Drawing.Point(210, 225);
			this.TB_Made_By.Name = "TB_Made_By";
			this.TB_Made_By.Size = new System.Drawing.Size(207, 27);
			this.TB_Made_By.TabIndex = 18;
			// 
			// TB_Subject
			// 
			this.TB_Subject.BackColor = System.Drawing.Color.White;
			this.TB_Subject.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 10F);
			this.TB_Subject.ForeColor = System.Drawing.Color.Black;
			this.TB_Subject.Location = new System.Drawing.Point(210, 255);
			this.TB_Subject.Name = "TB_Subject";
			this.TB_Subject.Size = new System.Drawing.Size(207, 27);
			this.TB_Subject.TabIndex = 20;
			// 
			// label_subject
			// 
			this.label_subject.AutoSize = true;
			this.label_subject.BackColor = System.Drawing.Color.Transparent;
			this.label_subject.Font = new System.Drawing.Font("AvenirNext LT Pro Bold", 10.2F, System.Drawing.FontStyle.Bold);
			this.label_subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(13)))), ((int)(((byte)(48)))));
			this.label_subject.Location = new System.Drawing.Point(19, 257);
			this.label_subject.Name = "label_subject";
			this.label_subject.Size = new System.Drawing.Size(105, 21);
			this.label_subject.TabIndex = 19;
			this.label_subject.Text = "Onderwerp";
			// 
			// btn_update
			// 
			this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
			this.btn_update.Enabled = false;
			this.btn_update.FlatAppearance.BorderSize = 0;
			this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_update.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 10.2F);
			this.btn_update.ForeColor = System.Drawing.Color.White;
			this.btn_update.Location = new System.Drawing.Point(860, 659);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(175, 46);
			this.btn_update.TabIndex = 21;
			this.btn_update.Text = "Update";
			this.btn_update.UseVisualStyleBackColor = false;
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("AvenirNext LT Pro Bold", 10.2F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(13)))), ((int)(((byte)(48)))));
			this.label1.Location = new System.Drawing.Point(21, 285);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 21);
			this.label1.TabIndex = 22;
			this.label1.Text = "Klassen";
			// 
			// CB_Classes
			// 
			this.CB_Classes.BackColor = System.Drawing.Color.White;
			this.CB_Classes.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 10F);
			this.CB_Classes.ForeColor = System.Drawing.Color.Black;
			this.CB_Classes.FormattingEnabled = true;
			this.CB_Classes.Items.AddRange(new object[] {
            "All"});
			this.CB_Classes.Location = new System.Drawing.Point(210, 285);
			this.CB_Classes.Name = "CB_Classes";
			this.CB_Classes.Size = new System.Drawing.Size(207, 28);
			this.CB_Classes.TabIndex = 23;
			// 
			// btn_add_images
			// 
			this.btn_add_images.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
			this.btn_add_images.FlatAppearance.BorderSize = 0;
			this.btn_add_images.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_add_images.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 10.2F);
			this.btn_add_images.ForeColor = System.Drawing.Color.White;
			this.btn_add_images.Location = new System.Drawing.Point(849, 358);
			this.btn_add_images.Name = "btn_add_images";
			this.btn_add_images.Size = new System.Drawing.Size(380, 51);
			this.btn_add_images.TabIndex = 24;
			this.btn_add_images.Text = "Voeg afbeelding toe aan les";
			this.btn_add_images.UseVisualStyleBackColor = false;
			this.btn_add_images.Click += new System.EventHandler(this.btn_add_images_Click);
			// 
			// btn_Add_Image_to_system
			// 
			this.btn_Add_Image_to_system.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
			this.btn_Add_Image_to_system.FlatAppearance.BorderSize = 0;
			this.btn_Add_Image_to_system.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Add_Image_to_system.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 10.2F);
			this.btn_Add_Image_to_system.ForeColor = System.Drawing.Color.White;
			this.btn_Add_Image_to_system.Location = new System.Drawing.Point(442, 358);
			this.btn_Add_Image_to_system.Name = "btn_Add_Image_to_system";
			this.btn_Add_Image_to_system.Size = new System.Drawing.Size(380, 51);
			this.btn_Add_Image_to_system.TabIndex = 25;
			this.btn_Add_Image_to_system.Text = "Voeg afbeelding toe aan History VAR";
			this.btn_Add_Image_to_system.UseVisualStyleBackColor = false;
			this.btn_Add_Image_to_system.Click += new System.EventHandler(this.btn_Add_Image_to_system_Click);
			// 
			// LB_Images
			// 
			this.LB_Images.BackColor = System.Drawing.Color.White;
			this.LB_Images.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LB_Images.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 10F);
			this.LB_Images.ForeColor = System.Drawing.Color.Black;
			this.LB_Images.FormattingEnabled = true;
			this.LB_Images.ItemHeight = 20;
			this.LB_Images.Location = new System.Drawing.Point(14, 27);
			this.LB_Images.Name = "LB_Images";
			this.LB_Images.Size = new System.Drawing.Size(360, 160);
			this.LB_Images.TabIndex = 0;
			this.LB_Images.DoubleClick += new System.EventHandler(this.LB_Images_DoubleClick);
			// 
			// GB_Images
			// 
			this.GB_Images.BackColor = System.Drawing.Color.Transparent;
			this.GB_Images.Controls.Add(this.LB_Images);
			this.GB_Images.Font = new System.Drawing.Font("AvenirNext LT Pro Bold", 10.2F, System.Drawing.FontStyle.Bold);
			this.GB_Images.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(13)))), ((int)(((byte)(48)))));
			this.GB_Images.Location = new System.Drawing.Point(849, 161);
			this.GB_Images.Name = "GB_Images";
			this.GB_Images.Size = new System.Drawing.Size(380, 189);
			this.GB_Images.TabIndex = 9;
			this.GB_Images.TabStop = false;
			this.GB_Images.Text = "Lijst van afbeeldingen in les";
			// 
			// CB_Art
			// 
			this.CB_Art.BackColor = System.Drawing.Color.White;
			this.CB_Art.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 10F);
			this.CB_Art.ForeColor = System.Drawing.Color.Black;
			this.CB_Art.FormattingEnabled = true;
			this.CB_Art.Location = new System.Drawing.Point(210, 317);
			this.CB_Art.Name = "CB_Art";
			this.CB_Art.Size = new System.Drawing.Size(207, 28);
			this.CB_Art.TabIndex = 26;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("AvenirNext LT Pro Bold", 10.2F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(13)))), ((int)(((byte)(48)))));
			this.label2.Location = new System.Drawing.Point(21, 319);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 21);
			this.label2.TabIndex = 27;
			this.label2.Text = "3D Kunst Objecten";
			// 
			// LBL_Title_New_Set
			// 
			this.LBL_Title_New_Set.BackColor = System.Drawing.Color.Transparent;
			this.LBL_Title_New_Set.Font = new System.Drawing.Font("Poetsen One", 48F, System.Drawing.FontStyle.Bold);
			this.LBL_Title_New_Set.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(13)))), ((int)(((byte)(48)))));
			this.LBL_Title_New_Set.Location = new System.Drawing.Point(29, 9);
			this.LBL_Title_New_Set.Name = "LBL_Title_New_Set";
			this.LBL_Title_New_Set.Padding = new System.Windows.Forms.Padding(10);
			this.LBL_Title_New_Set.Size = new System.Drawing.Size(1200, 116);
			this.LBL_Title_New_Set.TabIndex = 28;
			this.LBL_Title_New_Set.Text = "Maak een nieuwe les";
			this.LBL_Title_New_Set.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Teacher_Make_New_Sets
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::History_VAR.Properties.Resources.HistoryVAR_BG;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1262, 753);
			this.Controls.Add(this.LBL_Title_New_Set);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CB_Art);
			this.Controls.Add(this.GB_Images);
			this.Controls.Add(this.btn_Add_Image_to_system);
			this.Controls.Add(this.btn_add_images);
			this.Controls.Add(this.CB_Classes);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_update);
			this.Controls.Add(this.TB_Subject);
			this.Controls.Add(this.label_subject);
			this.Controls.Add(this.TB_Made_By);
			this.Controls.Add(this.label_Made_By);
			this.Controls.Add(this.btn_add_objects);
			this.Controls.Add(this.CB_Lesson_Status);
			this.Controls.Add(this.label_published);
			this.Controls.Add(this.TB_Title);
			this.Controls.Add(this.label_lesson_title);
			this.Controls.Add(this.GB_ListOfObjects);
			this.Controls.Add(this.btn_save_lesson);
			this.Controls.Add(this.btn_back);
			this.Controls.Add(this.TB_Desc);
			this.DoubleBuffered = true;
			this.Name = "Teacher_Make_New_Sets";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Teacher_Make_New_Sets";
			this.GB_ListOfObjects.ResumeLayout(false);
			this.GB_Images.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_Desc;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_save_lesson;
        private System.Windows.Forms.GroupBox GB_ListOfObjects;
        private System.Windows.Forms.Label label_lesson_title;
        private System.Windows.Forms.TextBox TB_Title;
        private System.Windows.Forms.Label label_published;
        private System.Windows.Forms.ComboBox CB_Lesson_Status;
        private System.Windows.Forms.Button btn_add_objects;
        private System.Windows.Forms.Label label_Made_By;
        private System.Windows.Forms.TextBox TB_Made_By;
        private System.Windows.Forms.ListBox LB_Art_Items;
        private System.Windows.Forms.TextBox TB_Subject;
        private System.Windows.Forms.Label label_subject;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Classes;
        private System.Windows.Forms.Button btn_add_images;
        private System.Windows.Forms.Button btn_Add_Image_to_system;
        private System.Windows.Forms.ListBox LB_Images;
        private System.Windows.Forms.GroupBox GB_Images;
        private System.Windows.Forms.ComboBox CB_Art;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label LBL_Title_New_Set;
	}
}