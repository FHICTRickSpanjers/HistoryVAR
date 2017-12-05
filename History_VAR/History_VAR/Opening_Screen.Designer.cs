namespace History_VAR
{
    partial class Opening_Screen
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
            this.btn_enter_application = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_enter_application
            // 
            this.btn_enter_application.Location = new System.Drawing.Point(17, 84);
            this.btn_enter_application.Name = "btn_enter_application";
            this.btn_enter_application.Size = new System.Drawing.Size(192, 51);
            this.btn_enter_application.TabIndex = 0;
            this.btn_enter_application.Text = "Enter Application";
            this.btn_enter_application.UseVisualStyleBackColor = true;
            this.btn_enter_application.Click += new System.EventHandler(this.btn_enter_application_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "HISTORY VAR";
            // 
            // Opening_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 157);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_enter_application);
            this.Name = "Opening_Screen";
            this.Text = "Opening Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enter_application;
        private System.Windows.Forms.Label label1;
    }
}

