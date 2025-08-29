namespace OliviaEvansProg05RandNum
{
    partial class Form1
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
            this.writingGroupBox = new System.Windows.Forms.GroupBox();
            this.writePromptLabel = new System.Windows.Forms.Label();
            this.amtPromptLabel = new System.Windows.Forms.Label();
            this.numAmtTextBox = new System.Windows.Forms.TextBox();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.writeDescriptionLabel = new System.Windows.Forms.Label();
            this.readingGroupBox = new System.Windows.Forms.GroupBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.countDescriptLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalDescriptLabel = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.writingGroupBox.SuspendLayout();
            this.readingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // writingGroupBox
            // 
            this.writingGroupBox.Controls.Add(this.writePromptLabel);
            this.writingGroupBox.Controls.Add(this.amtPromptLabel);
            this.writingGroupBox.Controls.Add(this.numAmtTextBox);
            this.writingGroupBox.Controls.Add(this.saveFileButton);
            this.writingGroupBox.Controls.Add(this.writeDescriptionLabel);
            this.writingGroupBox.Location = new System.Drawing.Point(23, 51);
            this.writingGroupBox.Name = "writingGroupBox";
            this.writingGroupBox.Size = new System.Drawing.Size(293, 231);
            this.writingGroupBox.TabIndex = 0;
            this.writingGroupBox.TabStop = false;
            this.writingGroupBox.Text = "Write";
            // 
            // writePromptLabel
            // 
            this.writePromptLabel.Location = new System.Drawing.Point(31, 59);
            this.writePromptLabel.Name = "writePromptLabel";
            this.writePromptLabel.Size = new System.Drawing.Size(229, 40);
            this.writePromptLabel.TabIndex = 6;
            this.writePromptLabel.Text = "How many numbers would you like in this file?";
            this.writePromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amtPromptLabel
            // 
            this.amtPromptLabel.AutoSize = true;
            this.amtPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtPromptLabel.Location = new System.Drawing.Point(66, 121);
            this.amtPromptLabel.Name = "amtPromptLabel";
            this.amtPromptLabel.Size = new System.Drawing.Size(63, 18);
            this.amtPromptLabel.TabIndex = 5;
            this.amtPromptLabel.Text = "Amount:";
            // 
            // numAmtTextBox
            // 
            this.numAmtTextBox.Location = new System.Drawing.Point(135, 117);
            this.numAmtTextBox.Name = "numAmtTextBox";
            this.numAmtTextBox.Size = new System.Drawing.Size(100, 26);
            this.numAmtTextBox.TabIndex = 4;
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(69, 163);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(158, 33);
            this.saveFileButton.TabIndex = 4;
            this.saveFileButton.Text = "Create and Save";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // writeDescriptionLabel
            // 
            this.writeDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeDescriptionLabel.Location = new System.Drawing.Point(20, 19);
            this.writeDescriptionLabel.Name = "writeDescriptionLabel";
            this.writeDescriptionLabel.Size = new System.Drawing.Size(267, 20);
            this.writeDescriptionLabel.TabIndex = 4;
            this.writeDescriptionLabel.Text = "Create a text file of random numbers";
            this.writeDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // readingGroupBox
            // 
            this.readingGroupBox.Controls.Add(this.countLabel);
            this.readingGroupBox.Controls.Add(this.countDescriptLabel);
            this.readingGroupBox.Controls.Add(this.totalLabel);
            this.readingGroupBox.Controls.Add(this.totalDescriptLabel);
            this.readingGroupBox.Controls.Add(this.openFileButton);
            this.readingGroupBox.Controls.Add(this.label1);
            this.readingGroupBox.Location = new System.Drawing.Point(349, 51);
            this.readingGroupBox.Name = "readingGroupBox";
            this.readingGroupBox.Size = new System.Drawing.Size(293, 231);
            this.readingGroupBox.TabIndex = 1;
            this.readingGroupBox.TabStop = false;
            this.readingGroupBox.Text = "Read";
            // 
            // countLabel
            // 
            this.countLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countLabel.Location = new System.Drawing.Point(185, 114);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(59, 30);
            this.countLabel.TabIndex = 9;
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countDescriptLabel
            // 
            this.countDescriptLabel.Location = new System.Drawing.Point(18, 105);
            this.countDescriptLabel.Name = "countDescriptLabel";
            this.countDescriptLabel.Size = new System.Drawing.Size(171, 48);
            this.countDescriptLabel.TabIndex = 8;
            this.countDescriptLabel.Text = "Amount of numbers:";
            this.countDescriptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(185, 163);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(59, 30);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalDescriptLabel
            // 
            this.totalDescriptLabel.Location = new System.Drawing.Point(23, 163);
            this.totalDescriptLabel.Name = "totalDescriptLabel";
            this.totalDescriptLabel.Size = new System.Drawing.Size(165, 30);
            this.totalDescriptLabel.TabIndex = 6;
            this.totalDescriptLabel.Text = "Total of all numbers:";
            this.totalDescriptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(94, 59);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(95, 33);
            this.openFileButton.TabIndex = 5;
            this.openFileButton.Text = "Open";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Read from your random number file";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(197, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(273, 29);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Random Number File Menu";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(272, 324);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(122, 32);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "\"Text files (*.txt)|*.txt|All files (*.*)|*.*\"";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 368);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.readingGroupBox);
            this.Controls.Add(this.writingGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.writingGroupBox.ResumeLayout(false);
            this.writingGroupBox.PerformLayout();
            this.readingGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox writingGroupBox;
        private System.Windows.Forms.GroupBox readingGroupBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label writeDescriptionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label amtPromptLabel;
        private System.Windows.Forms.TextBox numAmtTextBox;
        private System.Windows.Forms.Label writePromptLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label totalDescriptLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label countDescriptLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

