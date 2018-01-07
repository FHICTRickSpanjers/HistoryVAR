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
			this.CB_Lessons = new System.Windows.Forms.ComboBox();
			this.btn_edit = new System.Windows.Forms.Button();
			this.btn_back = new System.Windows.Forms.Button();
			this.btn_publish = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CB_Lessons
			// 
			this.CB_Lessons.BackColor = System.Drawing.Color.White;
			this.CB_Lessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.CB_Lessons.ForeColor = System.Drawing.Color.Black;
			this.CB_Lessons.FormattingEnabled = true;
			this.CB_Lessons.Location = new System.Drawing.Point(73, 164);
			this.CB_Lessons.Name = "CB_Lessons";
			this.CB_Lessons.Size = new System.Drawing.Size(631, 30);
			this.CB_Lessons.TabIndex = 4;
			// 
			// btn_edit
			// 
			this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(13)))), ((int)(((byte)(48)))));
			this.btn_edit.FlatAppearance.BorderSize = 0;
			this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.btn_edit.ForeColor = System.Drawing.Color.White;
			this.btn_edit.Location = new System.Drawing.Point(73, 207);
			this.btn_edit.Margin = new System.Windows.Forms.Padding(10);
			this.btn_edit.Name = "btn_edit";
			this.btn_edit.Size = new System.Drawing.Size(631, 52);
			this.btn_edit.TabIndex = 5;
			this.btn_edit.Text = "Edit Lesson";
			this.btn_edit.UseVisualStyleBackColor = false;
			this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
			// 
			// btn_back
			// 
			this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(13)))), ((int)(((byte)(48)))));
			this.btn_back.FlatAppearance.BorderSize = 0;
			this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.btn_back.ForeColor = System.Drawing.Color.White;
			this.btn_back.Location = new System.Drawing.Point(73, 423);
			this.btn_back.Margin = new System.Windows.Forms.Padding(10);
			this.btn_back.Name = "btn_back";
			this.btn_back.Size = new System.Drawing.Size(631, 52);
			this.btn_back.TabIndex = 9;
			this.btn_back.Text = "Back";
			this.btn_back.UseVisualStyleBackColor = false;
			this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
			// 
			// btn_publish
			// 
			this.btn_publish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(13)))), ((int)(((byte)(48)))));
			this.btn_publish.FlatAppearance.BorderSize = 0;
			this.btn_publish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_publish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.btn_publish.ForeColor = System.Drawing.Color.White;
			this.btn_publish.Location = new System.Drawing.Point(73, 351);
			this.btn_publish.Margin = new System.Windows.Forms.Padding(10);
			this.btn_publish.Name = "btn_publish";
			this.btn_publish.Size = new System.Drawing.Size(631, 52);
			this.btn_publish.TabIndex = 11;
			this.btn_publish.Text = "Change Lesson Status";
			this.btn_publish.UseVisualStyleBackColor = false;
			this.btn_publish.Click += new System.EventHandler(this.btn_publish_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(13)))), ((int)(((byte)(48)))));
			this.btn_delete.FlatAppearance.BorderSize = 0;
			this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.btn_delete.ForeColor = System.Drawing.Color.White;
			this.btn_delete.Location = new System.Drawing.Point(73, 279);
			this.btn_delete.Margin = new System.Windows.Forms.Padding(10);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(631, 52);
			this.btn_delete.TabIndex = 10;
			this.btn_delete.Text = "Delete Lesson";
			this.btn_delete.UseVisualStyleBackColor = false;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Poetsen One", 45F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
			this.label3.Location = new System.Drawing.Point(77, 29);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(10);
			this.label3.Size = new System.Drawing.Size(627, 110);
			this.label3.TabIndex = 29;
			this.label3.Text = "Teacher options";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Teacher_Current_Sets
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(216)))));
			this.BackgroundImage = global::History_VAR.Properties.Resources.HistoryVAR_BG;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(782, 553);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_publish);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_back);
			this.Controls.Add(this.btn_edit);
			this.Controls.Add(this.CB_Lessons);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "Teacher_Current_Sets";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Teacher_Current_Sets";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CB_Lessons;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_publish;
        private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Label label3;
	}
}