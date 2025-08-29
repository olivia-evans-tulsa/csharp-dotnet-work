namespace oliviaEvansC_Final
{
    partial class download
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
            this.excelButton = new System.Windows.Forms.Button();
            this.txtButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // excelButton
            // 
            this.excelButton.Location = new System.Drawing.Point(63, 40);
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(272, 39);
            this.excelButton.TabIndex = 0;
            this.excelButton.Text = "Download as Excel Spreadsheet";
            this.excelButton.UseVisualStyleBackColor = true;
            this.excelButton.Click += new System.EventHandler(this.excelButton_Click);
            // 
            // txtButton
            // 
            this.txtButton.Location = new System.Drawing.Point(63, 101);
            this.txtButton.Name = "txtButton";
            this.txtButton.Size = new System.Drawing.Size(272, 39);
            this.txtButton.TabIndex = 1;
            this.txtButton.Text = "Download as Text File";
            this.txtButton.UseVisualStyleBackColor = true;
            this.txtButton.Click += new System.EventHandler(this.txtButton_Click);
            // 
            // download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 183);
            this.Controls.Add(this.txtButton);
            this.Controls.Add(this.excelButton);
            this.Name = "download";
            this.Text = "Download";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button excelButton;
        private System.Windows.Forms.Button txtButton;
    }
}