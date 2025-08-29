namespace OliviaEvansProg03CelFah
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
            this.userTempTextBox = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.toCelButton = new System.Windows.Forms.Button();
            this.toFarButton = new System.Windows.Forms.Button();
            this.convertedLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userTempTextBox
            // 
            this.userTempTextBox.Location = new System.Drawing.Point(39, 67);
            this.userTempTextBox.Name = "userTempTextBox";
            this.userTempTextBox.Size = new System.Drawing.Size(315, 26);
            this.userTempTextBox.TabIndex = 0;
            this.userTempTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // instructionLabel
            // 
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(23, 15);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(348, 56);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Enter a temperature to convert.";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toCelButton
            // 
            this.toCelButton.Location = new System.Drawing.Point(65, 99);
            this.toCelButton.Name = "toCelButton";
            this.toCelButton.Size = new System.Drawing.Size(128, 74);
            this.toCelButton.TabIndex = 2;
            this.toCelButton.Text = "Convert to Celsius";
            this.toCelButton.UseVisualStyleBackColor = true;
            this.toCelButton.Click += new System.EventHandler(this.toCelButton_Click);
            // 
            // toFarButton
            // 
            this.toFarButton.Location = new System.Drawing.Point(199, 99);
            this.toFarButton.Name = "toFarButton";
            this.toFarButton.Size = new System.Drawing.Size(128, 74);
            this.toFarButton.TabIndex = 3;
            this.toFarButton.Text = "Convert to Fahrenheit";
            this.toFarButton.UseVisualStyleBackColor = true;
            this.toFarButton.Click += new System.EventHandler(this.toFarButton_Click);
            // 
            // convertedLabel
            // 
            this.convertedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convertedLabel.Location = new System.Drawing.Point(100, 196);
            this.convertedLabel.Name = "convertedLabel";
            this.convertedLabel.Size = new System.Drawing.Size(191, 48);
            this.convertedLabel.TabIndex = 4;
            this.convertedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(197, 268);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 34);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(84, 268);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(107, 34);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 318);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertedLabel);
            this.Controls.Add(this.toFarButton);
            this.Controls.Add(this.toCelButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.userTempTextBox);
            this.Name = "Form1";
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userTempTextBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button toCelButton;
        private System.Windows.Forms.Button toFarButton;
        private System.Windows.Forms.Label convertedLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

