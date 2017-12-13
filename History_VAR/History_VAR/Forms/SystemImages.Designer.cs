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
            this.label1 = new System.Windows.Forms.Label();
            this.FlowLayoutPanelIMG = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose images";
            // 
            // FlowLayoutPanelIMG
            // 
            this.FlowLayoutPanelIMG.Location = new System.Drawing.Point(17, 50);
            this.FlowLayoutPanelIMG.Name = "FlowLayoutPanelIMG";
            this.FlowLayoutPanelIMG.Size = new System.Drawing.Size(489, 356);
            this.FlowLayoutPanelIMG.TabIndex = 1;
            this.FlowLayoutPanelIMG.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutPanelIMG_Paint);
            // 
            // SystemImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 418);
            this.Controls.Add(this.FlowLayoutPanelIMG);
            this.Controls.Add(this.label1);
            this.Name = "SystemImages";
            this.Text = "SystemImages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelIMG;
    }
}