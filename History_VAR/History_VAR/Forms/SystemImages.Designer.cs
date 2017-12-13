namespace History_VAR.Forms
{
    partial class SystemImages
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
            this.FlowLayoutPanelIMG = new System.Windows.Forms.FlowLayoutPanel();
            this.label_available_lessons = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FlowLayoutPanelIMG
            // 
            this.FlowLayoutPanelIMG.Location = new System.Drawing.Point(12, 69);
            this.FlowLayoutPanelIMG.Name = "FlowLayoutPanelIMG";
            this.FlowLayoutPanelIMG.Size = new System.Drawing.Size(429, 336);
            this.FlowLayoutPanelIMG.TabIndex = 1;
            this.FlowLayoutPanelIMG.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutPanelIMG_Paint);
            // 
            // label_available_lessons
            // 
            this.label_available_lessons.BackColor = System.Drawing.Color.Black;
            this.label_available_lessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label_available_lessons.ForeColor = System.Drawing.Color.White;
            this.label_available_lessons.Location = new System.Drawing.Point(12, 9);
            this.label_available_lessons.Name = "label_available_lessons";
            this.label_available_lessons.Padding = new System.Windows.Forms.Padding(10);
            this.label_available_lessons.Size = new System.Drawing.Size(429, 56);
            this.label_available_lessons.TabIndex = 3;
            this.label_available_lessons.Tag = "";
            this.label_available_lessons.Text = "SELECT IMAGE";
            this.label_available_lessons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SystemImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 418);
            this.Controls.Add(this.label_available_lessons);
            this.Controls.Add(this.FlowLayoutPanelIMG);
            this.Name = "SystemImages";
            this.Text = "SystemImages";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelIMG;
        private System.Windows.Forms.Label label_available_lessons;
    }
}