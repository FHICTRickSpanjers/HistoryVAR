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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_enter_application
            // 
            this.btn_enter_application.Location = new System.Drawing.Point(12, 80);
            this.btn_enter_application.Name = "btn_enter_application";
            this.btn_enter_application.Size = new System.Drawing.Size(470, 51);
            this.btn_enter_application.TabIndex = 0;
            this.btn_enter_application.Text = "Enter Application";
            this.btn_enter_application.UseVisualStyleBackColor = true;
            this.btn_enter_application.Click += new System.EventHandler(this.btn_enter_application_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(470, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "HISTORY VAR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Opening_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 149);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_enter_application);
            this.Name = "Opening_Screen";
            this.Text = "Opening Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_enter_application;
        private System.Windows.Forms.Label label2;
    }
}

