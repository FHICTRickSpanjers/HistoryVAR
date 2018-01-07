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
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// FlowLayoutPanelIMG
			// 
			this.FlowLayoutPanelIMG.ForeColor = System.Drawing.Color.Black;
			this.FlowLayoutPanelIMG.Location = new System.Drawing.Point(12, 69);
			this.FlowLayoutPanelIMG.Name = "FlowLayoutPanelIMG";
			this.FlowLayoutPanelIMG.Size = new System.Drawing.Size(429, 336);
			this.FlowLayoutPanelIMG.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Poetsen One", 15F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
			this.label3.Location = new System.Drawing.Point(110, 16);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(10);
			this.label3.Size = new System.Drawing.Size(235, 50);
			this.label3.TabIndex = 30;
			this.label3.Text = "Teacher options";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SystemImages
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(216)))));
			this.BackgroundImage = global::History_VAR.Properties.Resources.HistoryVAR_BG;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(458, 418);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.FlowLayoutPanelIMG);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "SystemImages";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SystemImages";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelIMG;
		private System.Windows.Forms.Label label3;
	}
}