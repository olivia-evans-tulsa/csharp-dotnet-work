namespace OliviaEvansProg02Cards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.blackJokerBox = new System.Windows.Forms.PictureBox();
            this.heartTenBox = new System.Windows.Forms.PictureBox();
            this.spadeFourBox = new System.Windows.Forms.PictureBox();
            this.clubKingBox = new System.Windows.Forms.PictureBox();
            this.diamondTwoBox = new System.Windows.Forms.PictureBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.cardIDLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.blackJokerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartTenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spadeFourBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubKingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamondTwoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // blackJokerBox
            // 
            this.blackJokerBox.Image = ((System.Drawing.Image)(resources.GetObject("blackJokerBox.Image")));
            this.blackJokerBox.Location = new System.Drawing.Point(19, 106);
            this.blackJokerBox.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.blackJokerBox.Name = "blackJokerBox";
            this.blackJokerBox.Size = new System.Drawing.Size(134, 170);
            this.blackJokerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blackJokerBox.TabIndex = 0;
            this.blackJokerBox.TabStop = false;
            this.blackJokerBox.Click += new System.EventHandler(this.blackJokerBox_Click);
            // 
            // heartTenBox
            // 
            this.heartTenBox.Image = ((System.Drawing.Image)(resources.GetObject("heartTenBox.Image")));
            this.heartTenBox.Location = new System.Drawing.Point(173, 106);
            this.heartTenBox.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.heartTenBox.Name = "heartTenBox";
            this.heartTenBox.Size = new System.Drawing.Size(134, 170);
            this.heartTenBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heartTenBox.TabIndex = 1;
            this.heartTenBox.TabStop = false;
            this.heartTenBox.Click += new System.EventHandler(this.heartTenBox_Click);
            // 
            // spadeFourBox
            // 
            this.spadeFourBox.Image = ((System.Drawing.Image)(resources.GetObject("spadeFourBox.Image")));
            this.spadeFourBox.Location = new System.Drawing.Point(327, 106);
            this.spadeFourBox.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.spadeFourBox.Name = "spadeFourBox";
            this.spadeFourBox.Size = new System.Drawing.Size(134, 170);
            this.spadeFourBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spadeFourBox.TabIndex = 2;
            this.spadeFourBox.TabStop = false;
            this.spadeFourBox.Click += new System.EventHandler(this.spadeFourBox_Click);
            // 
            // clubKingBox
            // 
            this.clubKingBox.Image = ((System.Drawing.Image)(resources.GetObject("clubKingBox.Image")));
            this.clubKingBox.Location = new System.Drawing.Point(481, 106);
            this.clubKingBox.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.clubKingBox.Name = "clubKingBox";
            this.clubKingBox.Size = new System.Drawing.Size(134, 170);
            this.clubKingBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clubKingBox.TabIndex = 3;
            this.clubKingBox.TabStop = false;
            this.clubKingBox.Click += new System.EventHandler(this.clubKingBox_Click);
            // 
            // diamondTwoBox
            // 
            this.diamondTwoBox.Image = ((System.Drawing.Image)(resources.GetObject("diamondTwoBox.Image")));
            this.diamondTwoBox.Location = new System.Drawing.Point(635, 106);
            this.diamondTwoBox.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.diamondTwoBox.Name = "diamondTwoBox";
            this.diamondTwoBox.Size = new System.Drawing.Size(134, 170);
            this.diamondTwoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.diamondTwoBox.TabIndex = 4;
            this.diamondTwoBox.TabStop = false;
            this.diamondTwoBox.Click += new System.EventHandler(this.diamondTwoBox_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(173, 24);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(442, 53);
            this.instructionLabel.TabIndex = 5;
            this.instructionLabel.Text = "Click a Card to See Its Name";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardIDLabel
            // 
            this.cardIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardIDLabel.Location = new System.Drawing.Point(19, 291);
            this.cardIDLabel.Name = "cardIDLabel";
            this.cardIDLabel.Size = new System.Drawing.Size(750, 45);
            this.cardIDLabel.TabIndex = 6;
            this.cardIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(309, 361);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(175, 44);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 425);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cardIDLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.diamondTwoBox);
            this.Controls.Add(this.clubKingBox);
            this.Controls.Add(this.spadeFourBox);
            this.Controls.Add(this.heartTenBox);
            this.Controls.Add(this.blackJokerBox);
            this.Name = "Form1";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.blackJokerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartTenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spadeFourBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubKingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamondTwoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox blackJokerBox;
        private System.Windows.Forms.PictureBox heartTenBox;
        private System.Windows.Forms.PictureBox spadeFourBox;
        private System.Windows.Forms.PictureBox clubKingBox;
        private System.Windows.Forms.PictureBox diamondTwoBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label cardIDLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

