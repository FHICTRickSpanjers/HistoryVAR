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
            this.btn_enter_application.BackColor = System.Drawing.Color.White;
            this.btn_enter_application.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enter_application.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_enter_application.ForeColor = System.Drawing.Color.Black;
            this.btn_enter_application.Location = new System.Drawing.Point(112, 286);
            this.btn_enter_application.Name = "btn_enter_application";
            this.btn_enter_application.Size = new System.Drawing.Size(567, 51);
            this.btn_enter_application.TabIndex = 0;
            this.btn_enter_application.Text = "Enter Application";
            this.btn_enter_application.UseVisualStyleBackColor = false;
            this.btn_enter_application.Click += new System.EventHandler(this.btn_enter_application_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(121, 36);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(529, 115);
            this.label2.TabIndex = 2;
            this.label2.Text = "History VAR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Opening_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_enter_application);
            this.Name = "Opening_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opening Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enter_application;
        private System.Windows.Forms.Label label2;
    }
}

