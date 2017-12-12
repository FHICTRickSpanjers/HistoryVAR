namespace History_VAR.Forms
{
    partial class Student_Show_Lesson
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
            this.LBL_Lesson_Title = new System.Windows.Forms.Label();
            this.TB_Lesson_Desc = new System.Windows.Forms.TextBox();
            this.LBL_Lesson_Subject = new System.Windows.Forms.Label();
            this.LB_Objects = new System.Windows.Forms.ListBox();
            this.Download_OBJ = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Lesson_Title
            // 
            this.LBL_Lesson_Title.AutoSize = true;
            this.LBL_Lesson_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Lesson_Title.Location = new System.Drawing.Point(13, 13);
            this.LBL_Lesson_Title.Name = "LBL_Lesson_Title";
            this.LBL_Lesson_Title.Size = new System.Drawing.Size(140, 26);
            this.LBL_Lesson_Title.TabIndex = 0;
            this.LBL_Lesson_Title.Text = "Lesson Title";
            // 
            // TB_Lesson_Desc
            // 
            this.TB_Lesson_Desc.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Lesson_Desc.Location = new System.Drawing.Point(18, 53);
            this.TB_Lesson_Desc.Multiline = true;
            this.TB_Lesson_Desc.Name = "TB_Lesson_Desc";
            this.TB_Lesson_Desc.Size = new System.Drawing.Size(524, 189);
            this.TB_Lesson_Desc.TabIndex = 1;
            // 
            // LBL_Lesson_Subject
            // 
            this.LBL_Lesson_Subject.AutoSize = true;
            this.LBL_Lesson_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LBL_Lesson_Subject.Location = new System.Drawing.Point(403, 16);
            this.LBL_Lesson_Subject.Name = "LBL_Lesson_Subject";
            this.LBL_Lesson_Subject.Size = new System.Drawing.Size(139, 24);
            this.LBL_Lesson_Subject.TabIndex = 2;
            this.LBL_Lesson_Subject.Text = "Lesson Subject";
            // 
            // LB_Objects
            // 
            this.LB_Objects.FormattingEnabled = true;
            this.LB_Objects.ItemHeight = 16;
            this.LB_Objects.Location = new System.Drawing.Point(18, 249);
            this.LB_Objects.Name = "LB_Objects";
            this.LB_Objects.Size = new System.Drawing.Size(524, 116);
            this.LB_Objects.TabIndex = 3;
            // 
            // Download_OBJ
            // 
            this.Download_OBJ.Location = new System.Drawing.Point(280, 371);
            this.Download_OBJ.Name = "Download_OBJ";
            this.Download_OBJ.Size = new System.Drawing.Size(262, 44);
            this.Download_OBJ.TabIndex = 4;
            this.Download_OBJ.Text = "Download";
            this.Download_OBJ.UseVisualStyleBackColor = true;
            this.Download_OBJ.Click += new System.EventHandler(this.Download_OBJ_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(18, 371);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(256, 44);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Student_Show_Lesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 444);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.Download_OBJ);
            this.Controls.Add(this.LB_Objects);
            this.Controls.Add(this.LBL_Lesson_Subject);
            this.Controls.Add(this.TB_Lesson_Desc);
            this.Controls.Add(this.LBL_Lesson_Title);
            this.Name = "Student_Show_Lesson";
            this.Text = "Student_Show_Lesson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Lesson_Title;
        private System.Windows.Forms.TextBox TB_Lesson_Desc;
        private System.Windows.Forms.Label LBL_Lesson_Subject;
        private System.Windows.Forms.ListBox LB_Objects;
        private System.Windows.Forms.Button Download_OBJ;
        private System.Windows.Forms.Button btn_back;
    }
}