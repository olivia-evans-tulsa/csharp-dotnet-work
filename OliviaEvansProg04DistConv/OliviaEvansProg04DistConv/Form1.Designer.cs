namespace OliviaEvansProg04DistConv
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.userAmtTextBox = new System.Windows.Forms.TextBox();
            this.convertFromBox = new System.Windows.Forms.GroupBox();
            this.unitFromListBox = new System.Windows.Forms.ListBox();
            this.convertToBox = new System.Windows.Forms.GroupBox();
            this.unitToListBox = new System.Windows.Forms.ListBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.distanceConvertedLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.convertFromBox.SuspendLayout();
            this.convertToBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.Location = new System.Drawing.Point(30, 30);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(228, 39);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Enter a distance to convert:";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userAmtTextBox
            // 
            this.userAmtTextBox.Location = new System.Drawing.Point(264, 36);
            this.userAmtTextBox.Name = "userAmtTextBox";
            this.userAmtTextBox.Size = new System.Drawing.Size(180, 26);
            this.userAmtTextBox.TabIndex = 1;
            // 
            // convertFromBox
            // 
            this.convertFromBox.Controls.Add(this.unitFromListBox);
            this.convertFromBox.Location = new System.Drawing.Point(16, 72);
            this.convertFromBox.Name = "convertFromBox";
            this.convertFromBox.Size = new System.Drawing.Size(224, 170);
            this.convertFromBox.TabIndex = 2;
            this.convertFromBox.TabStop = false;
            this.convertFromBox.Text = "From";
            // 
            // unitFromListBox
            // 
            this.unitFromListBox.FormattingEnabled = true;
            this.unitFromListBox.ItemHeight = 20;
            this.unitFromListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.unitFromListBox.Location = new System.Drawing.Point(20, 55);
            this.unitFromListBox.Name = "unitFromListBox";
            this.unitFromListBox.Size = new System.Drawing.Size(181, 64);
            this.unitFromListBox.TabIndex = 4;
            // 
            // convertToBox
            // 
            this.convertToBox.Controls.Add(this.unitToListBox);
            this.convertToBox.Location = new System.Drawing.Point(261, 72);
            this.convertToBox.Name = "convertToBox";
            this.convertToBox.Size = new System.Drawing.Size(224, 170);
            this.convertToBox.TabIndex = 3;
            this.convertToBox.TabStop = false;
            this.convertToBox.Text = "To";
            // 
            // unitToListBox
            // 
            this.unitToListBox.FormattingEnabled = true;
            this.unitToListBox.ItemHeight = 20;
            this.unitToListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.unitToListBox.Location = new System.Drawing.Point(21, 55);
            this.unitToListBox.Name = "unitToListBox";
            this.unitToListBox.Size = new System.Drawing.Size(181, 64);
            this.unitToListBox.TabIndex = 5;
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(34, 285);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(186, 39);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "Converted Distance:";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // distanceConvertedLabel
            // 
            this.distanceConvertedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.distanceConvertedLabel.Location = new System.Drawing.Point(236, 280);
            this.distanceConvertedLabel.Name = "distanceConvertedLabel";
            this.distanceConvertedLabel.Size = new System.Drawing.Size(208, 48);
            this.distanceConvertedLabel.TabIndex = 5;
            this.distanceConvertedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(99, 360);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(141, 36);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(261, 360);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(141, 36);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 424);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.distanceConvertedLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.convertToBox);
            this.Controls.Add(this.convertFromBox);
            this.Controls.Add(this.userAmtTextBox);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "Distance Converter";
            this.convertFromBox.ResumeLayout(false);
            this.convertToBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TextBox userAmtTextBox;
        private System.Windows.Forms.GroupBox convertFromBox;
        private System.Windows.Forms.ListBox unitFromListBox;
        private System.Windows.Forms.GroupBox convertToBox;
        private System.Windows.Forms.ListBox unitToListBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label distanceConvertedLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
    }
}

