namespace OliviaEvansProg11Employee
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
            this.employeeLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.shiftGroupBox = new System.Windows.Forms.GroupBox();
            this.dayRadioButton = new System.Windows.Forms.RadioButton();
            this.nightRadioButton = new System.Windows.Forms.RadioButton();
            this.payLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.payRateTextBox = new System.Windows.Forms.TextBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.shiftGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeLabel
            // 
            this.employeeLabel.Location = new System.Drawing.Point(12, 38);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(177, 30);
            this.employeeLabel.TabIndex = 0;
            this.employeeLabel.Text = "Employee Name:";
            this.employeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numberLabel
            // 
            this.numberLabel.Location = new System.Drawing.Point(12, 86);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(177, 30);
            this.numberLabel.TabIndex = 2;
            this.numberLabel.Text = "Employee Number:";
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shiftGroupBox
            // 
            this.shiftGroupBox.Controls.Add(this.nightRadioButton);
            this.shiftGroupBox.Controls.Add(this.dayRadioButton);
            this.shiftGroupBox.Location = new System.Drawing.Point(16, 140);
            this.shiftGroupBox.Name = "shiftGroupBox";
            this.shiftGroupBox.Size = new System.Drawing.Size(352, 68);
            this.shiftGroupBox.TabIndex = 3;
            this.shiftGroupBox.TabStop = false;
            this.shiftGroupBox.Text = "Shift Number:";
            // 
            // dayRadioButton
            // 
            this.dayRadioButton.AutoSize = true;
            this.dayRadioButton.Location = new System.Drawing.Point(128, 25);
            this.dayRadioButton.Name = "dayRadioButton";
            this.dayRadioButton.Size = new System.Drawing.Size(82, 24);
            this.dayRadioButton.TabIndex = 0;
            this.dayRadioButton.TabStop = true;
            this.dayRadioButton.Text = "day (1)";
            this.dayRadioButton.UseVisualStyleBackColor = true;
            this.dayRadioButton.CheckedChanged += new System.EventHandler(this.dayRadioButton_CheckedChanged);
            // 
            // nightRadioButton
            // 
            this.nightRadioButton.AutoSize = true;
            this.nightRadioButton.Location = new System.Drawing.Point(233, 25);
            this.nightRadioButton.Name = "nightRadioButton";
            this.nightRadioButton.Size = new System.Drawing.Size(92, 24);
            this.nightRadioButton.TabIndex = 1;
            this.nightRadioButton.TabStop = true;
            this.nightRadioButton.Text = "night (2)";
            this.nightRadioButton.UseVisualStyleBackColor = true;
            this.nightRadioButton.CheckedChanged += new System.EventHandler(this.nightRadioButton_CheckedChanged);
            // 
            // payLabel
            // 
            this.payLabel.Location = new System.Drawing.Point(12, 239);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(177, 30);
            this.payLabel.TabIndex = 4;
            this.payLabel.Text = "Hourly Pay Rate:    $";
            this.payLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(166, 40);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(202, 26);
            this.nameTextBox.TabIndex = 5;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(166, 88);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(202, 26);
            this.numberTextBox.TabIndex = 6;
            // 
            // payRateTextBox
            // 
            this.payRateTextBox.Location = new System.Drawing.Point(166, 241);
            this.payRateTextBox.Name = "payRateTextBox";
            this.payRateTextBox.Size = new System.Drawing.Size(202, 26);
            this.payRateTextBox.TabIndex = 7;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(249, 277);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(119, 34);
            this.displayButton.TabIndex = 8;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(12, 324);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(356, 140);
            this.outputLabel.TabIndex = 9;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(252, 472);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(119, 34);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 518);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.payRateTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.payLabel);
            this.Controls.Add(this.shiftGroupBox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.employeeLabel);
            this.Name = "Form1";
            this.Text = "Employee & ProductionWorker";
            this.shiftGroupBox.ResumeLayout(false);
            this.shiftGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.GroupBox shiftGroupBox;
        private System.Windows.Forms.RadioButton nightRadioButton;
        private System.Windows.Forms.RadioButton dayRadioButton;
        private System.Windows.Forms.Label payLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox payRateTextBox;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

