namespace History_VAR.Forms
{
    partial class Student_Screen
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
            this.btn_back = new System.Windows.Forms.Button();
            this.FlowLayoutPanelLessons = new System.Windows.Forms.FlowLayoutPanel();
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
            this.label_available_lessons.Size = new System.Drawing.Size(653, 59);
            this.label_available_lessons.TabIndex = 2;
            this.label_available_lessons.Tag = "";
            this.label_available_lessons.Text = "AVAILABLE LESSONS";
            this.label_available_lessons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(17, 360);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(115, 41);
            this.btn_back.TabIndex = 20;
            this.btn_back.Text = "Logout";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // FlowLayoutPanelLessons
            // 
            this.FlowLayoutPanelLessons.Location = new System.Drawing.Point(12, 80);
            this.FlowLayoutPanelLessons.Name = "FlowLayoutPanelLessons";
            this.FlowLayoutPanelLessons.Size = new System.Drawing.Size(653, 265);
            this.FlowLayoutPanelLessons.TabIndex = 21;
            // 
            // Student_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 413);
            this.Controls.Add(this.FlowLayoutPanelLessons);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label_available_lessons);
            this.Name = "Student_Screen";
            this.Text = "Student_Screen";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_available_lessons;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelLessons;
    }
}