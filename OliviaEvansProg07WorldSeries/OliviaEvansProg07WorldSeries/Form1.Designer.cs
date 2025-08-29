namespace OliviaEvansProg07WorldSeries
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
            this.teamList = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numWinsLabel = new System.Windows.Forms.Label();
            this.timesLabel = new System.Windows.Forms.Label();
            this.disclaimerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teamList
            // 
            this.teamList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamList.FormattingEnabled = true;
            this.teamList.ItemHeight = 20;
            this.teamList.Location = new System.Drawing.Point(33, 18);
            this.teamList.Name = "teamList";
            this.teamList.Size = new System.Drawing.Size(162, 184);
            this.teamList.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(218, 200);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(85, 35);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(319, 200);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 35);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(218, 18);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(186, 65);
            this.instructionLabel.TabIndex = 4;
            this.instructionLabel.Text = "Select an MLB team from the list at left, then click \"Search\"";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Your team has won the World Series";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numWinsLabel
            // 
            this.numWinsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numWinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numWinsLabel.Location = new System.Drawing.Point(245, 153);
            this.numWinsLabel.Name = "numWinsLabel";
            this.numWinsLabel.Size = new System.Drawing.Size(67, 31);
            this.numWinsLabel.TabIndex = 6;
            this.numWinsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLabel
            // 
            this.timesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLabel.Location = new System.Drawing.Point(330, 153);
            this.timesLabel.Name = "timesLabel";
            this.timesLabel.Size = new System.Drawing.Size(74, 31);
            this.timesLabel.TabIndex = 7;
            this.timesLabel.Text = "time(s)!";
            this.timesLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // disclaimerButton
            // 
            this.disclaimerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disclaimerButton.Location = new System.Drawing.Point(33, 206);
            this.disclaimerButton.Name = "disclaimerButton";
            this.disclaimerButton.Size = new System.Drawing.Size(89, 23);
            this.disclaimerButton.TabIndex = 8;
            this.disclaimerButton.Text = "Disclaimer";
            this.disclaimerButton.UseVisualStyleBackColor = true;
            this.disclaimerButton.Click += new System.EventHandler(this.disclaimerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 249);
            this.Controls.Add(this.disclaimerButton);
            this.Controls.Add(this.timesLabel);
            this.Controls.Add(this.numWinsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.teamList);
            this.Name = "Form1";
            this.Text = "World Series Champions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox teamList;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numWinsLabel;
        private System.Windows.Forms.Label timesLabel;
        private System.Windows.Forms.Button disclaimerButton;
    }
}

