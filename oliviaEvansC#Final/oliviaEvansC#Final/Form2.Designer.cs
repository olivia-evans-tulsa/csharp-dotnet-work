namespace oliviaEvansC_Final
{
    partial class Form2
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
            this.headerGroupBox = new System.Windows.Forms.GroupBox();
            this.outputList = new System.Windows.Forms.ListView();
            this.sortAlpha = new System.Windows.Forms.Button();
            this.sortReverse = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.headerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerGroupBox
            // 
            this.headerGroupBox.Controls.Add(this.sortReverse);
            this.headerGroupBox.Controls.Add(this.sortAlpha);
            this.headerGroupBox.Location = new System.Drawing.Point(12, 12);
            this.headerGroupBox.Name = "headerGroupBox";
            this.headerGroupBox.Size = new System.Drawing.Size(828, 57);
            this.headerGroupBox.TabIndex = 0;
            this.headerGroupBox.TabStop = false;
            // 
            // outputList
            // 
            this.outputList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputList.FullRowSelect = true;
            this.outputList.GridLines = true;
            this.outputList.HideSelection = false;
            this.outputList.Location = new System.Drawing.Point(12, 75);
            this.outputList.Name = "outputList";
            this.outputList.Size = new System.Drawing.Size(828, 260);
            this.outputList.TabIndex = 1;
            this.outputList.UseCompatibleStateImageBehavior = false;
            // 
            // sortAlpha
            // 
            this.sortAlpha.Location = new System.Drawing.Point(633, 18);
            this.sortAlpha.Name = "sortAlpha";
            this.sortAlpha.Size = new System.Drawing.Size(86, 31);
            this.sortAlpha.TabIndex = 2;
            this.sortAlpha.Text = "Sort A-Z";
            this.sortAlpha.UseVisualStyleBackColor = true;
            this.sortAlpha.Click += new System.EventHandler(this.sortAlpha_Click);
            // 
            // sortReverse
            // 
            this.sortReverse.Location = new System.Drawing.Point(725, 18);
            this.sortReverse.Name = "sortReverse";
            this.sortReverse.Size = new System.Drawing.Size(86, 31);
            this.sortReverse.TabIndex = 3;
            this.sortReverse.Text = "Sort Z-A";
            this.sortReverse.UseVisualStyleBackColor = true;
            this.sortReverse.Click += new System.EventHandler(this.sortReverse_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(246, 362);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(171, 31);
            this.downloadButton.TabIndex = 3;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(433, 362);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(171, 31);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 405);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.outputList);
            this.Controls.Add(this.headerGroupBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.headerGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox headerGroupBox;
        private System.Windows.Forms.ListView outputList;
        private System.Windows.Forms.Button sortReverse;
        private System.Windows.Forms.Button sortAlpha;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button closeButton;
    }
}