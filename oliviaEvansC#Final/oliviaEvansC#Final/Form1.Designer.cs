namespace oliviaEvansC_Final
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
            this.components = new System.ComponentModel.Container();
            this.westCheckBox = new System.Windows.Forms.CheckBox();
            this.neCheckBox = new System.Windows.Forms.CheckBox();
            this.seCheckBox = new System.Windows.Forms.CheckBox();
            this.metroCheckBox = new System.Windows.Forms.CheckBox();
            this.campusGroupBox = new System.Windows.Forms.GroupBox();
            this.campusLabel = new System.Windows.Forms.Label();
            this.clearReportButton = new System.Windows.Forms.Button();
            this.offenseSelectCheckBox = new System.Windows.Forms.GroupBox();
            this.offenseListBox = new System.Windows.Forms.CheckedListBox();
            this.reportLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.tCCDataContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radio2021 = new System.Windows.Forms.RadioButton();
            this.radio2022 = new System.Windows.Forms.RadioButton();
            this.radio2023 = new System.Windows.Forms.RadioButton();
            this.campusGroupBox.SuspendLayout();
            this.offenseSelectCheckBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCCDataContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // westCheckBox
            // 
            this.westCheckBox.Location = new System.Drawing.Point(461, 36);
            this.westCheckBox.Name = "westCheckBox";
            this.westCheckBox.Size = new System.Drawing.Size(104, 53);
            this.westCheckBox.TabIndex = 6;
            this.westCheckBox.Text = "West";
            this.westCheckBox.UseVisualStyleBackColor = true;
            // 
            // neCheckBox
            // 
            this.neCheckBox.Location = new System.Drawing.Point(154, 36);
            this.neCheckBox.Name = "neCheckBox";
            this.neCheckBox.Size = new System.Drawing.Size(141, 53);
            this.neCheckBox.TabIndex = 7;
            this.neCheckBox.Text = "Northeast";
            this.neCheckBox.UseVisualStyleBackColor = true;
            // 
            // seCheckBox
            // 
            this.seCheckBox.Location = new System.Drawing.Point(308, 36);
            this.seCheckBox.Name = "seCheckBox";
            this.seCheckBox.Size = new System.Drawing.Size(129, 53);
            this.seCheckBox.TabIndex = 8;
            this.seCheckBox.Text = "Southeast";
            this.seCheckBox.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox
            // 
            this.metroCheckBox.Location = new System.Drawing.Point(33, 36);
            this.metroCheckBox.Name = "metroCheckBox";
            this.metroCheckBox.Size = new System.Drawing.Size(79, 53);
            this.metroCheckBox.TabIndex = 9;
            this.metroCheckBox.Text = "Metro";
            this.metroCheckBox.UseVisualStyleBackColor = true;
            // 
            // campusGroupBox
            // 
            this.campusGroupBox.Controls.Add(this.campusLabel);
            this.campusGroupBox.Controls.Add(this.seCheckBox);
            this.campusGroupBox.Controls.Add(this.metroCheckBox);
            this.campusGroupBox.Controls.Add(this.westCheckBox);
            this.campusGroupBox.Controls.Add(this.neCheckBox);
            this.campusGroupBox.Location = new System.Drawing.Point(12, 274);
            this.campusGroupBox.Name = "campusGroupBox";
            this.campusGroupBox.Size = new System.Drawing.Size(571, 93);
            this.campusGroupBox.TabIndex = 10;
            this.campusGroupBox.TabStop = false;
            this.campusGroupBox.Text = "Campus";
            // 
            // campusLabel
            // 
            this.campusLabel.Location = new System.Drawing.Point(22, 22);
            this.campusLabel.Name = "campusLabel";
            this.campusLabel.Size = new System.Drawing.Size(363, 23);
            this.campusLabel.TabIndex = 11;
            this.campusLabel.Text = "Select at least one campus to search in.";
            // 
            // clearReportButton
            // 
            this.clearReportButton.Location = new System.Drawing.Point(221, 207);
            this.clearReportButton.Name = "clearReportButton";
            this.clearReportButton.Size = new System.Drawing.Size(152, 31);
            this.clearReportButton.TabIndex = 11;
            this.clearReportButton.Text = "Clear";
            this.clearReportButton.UseVisualStyleBackColor = true;
            this.clearReportButton.Click += new System.EventHandler(this.clearReportButton_Click);
            // 
            // offenseSelectCheckBox
            // 
            this.offenseSelectCheckBox.Controls.Add(this.offenseListBox);
            this.offenseSelectCheckBox.Controls.Add(this.reportLabel);
            this.offenseSelectCheckBox.Location = new System.Drawing.Point(12, 12);
            this.offenseSelectCheckBox.Name = "offenseSelectCheckBox";
            this.offenseSelectCheckBox.Size = new System.Drawing.Size(571, 237);
            this.offenseSelectCheckBox.TabIndex = 12;
            this.offenseSelectCheckBox.TabStop = false;
            this.offenseSelectCheckBox.Text = "Report Type";
            // 
            // offenseListBox
            // 
            this.offenseListBox.FormattingEnabled = true;
            this.offenseListBox.Location = new System.Drawing.Point(67, 60);
            this.offenseListBox.Name = "offenseListBox";
            this.offenseListBox.Size = new System.Drawing.Size(437, 119);
            this.offenseListBox.TabIndex = 13;
            this.offenseListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.offenseListBox_ItemCheck);
            // 
            // reportLabel
            // 
            this.reportLabel.Location = new System.Drawing.Point(22, 22);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(378, 23);
            this.reportLabel.TabIndex = 12;
            this.reportLabel.Text = "Select at least one report type to search by.";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 516);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(152, 31);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // goButton
            // 
            this.goButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.goButton.Location = new System.Drawing.Point(222, 516);
            this.goButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(152, 31);
            this.goButton.TabIndex = 14;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(431, 516);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(152, 31);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio2023);
            this.groupBox1.Controls.Add(this.radio2022);
            this.groupBox1.Controls.Add(this.radio2021);
            this.groupBox1.Controls.Add(this.yearLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 93);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Year";
            // 
            // yearLabel
            // 
            this.yearLabel.Location = new System.Drawing.Point(22, 17);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(406, 23);
            this.yearLabel.TabIndex = 10;
            this.yearLabel.Text = "Select a year to search in.";
            // 
            // tCCDataContextBindingSource
            // 
            this.tCCDataContextBindingSource.DataSource = typeof(oliviaEvansC_Final.TCCDataContext);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(623, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(413, 421);
            this.dataGridView1.TabIndex = 17;
            // 
            // radio2021
            // 
            this.radio2021.AutoSize = true;
            this.radio2021.Location = new System.Drawing.Point(152, 48);
            this.radio2021.Name = "radio2021";
            this.radio2021.Size = new System.Drawing.Size(70, 24);
            this.radio2021.TabIndex = 11;
            this.radio2021.TabStop = true;
            this.radio2021.Text = "2021";
            this.radio2021.UseVisualStyleBackColor = true;
            // 
            // radio2022
            // 
            this.radio2022.AutoSize = true;
            this.radio2022.Location = new System.Drawing.Point(252, 48);
            this.radio2022.Name = "radio2022";
            this.radio2022.Size = new System.Drawing.Size(70, 24);
            this.radio2022.TabIndex = 12;
            this.radio2022.TabStop = true;
            this.radio2022.Text = "2022";
            this.radio2022.UseVisualStyleBackColor = true;
            // 
            // radio2023
            // 
            this.radio2023.AutoSize = true;
            this.radio2023.Location = new System.Drawing.Point(358, 48);
            this.radio2023.Name = "radio2023";
            this.radio2023.Size = new System.Drawing.Size(70, 24);
            this.radio2023.TabIndex = 13;
            this.radio2023.TabStop = true;
            this.radio2023.Text = "2023";
            this.radio2023.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1069, 558);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearReportButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.offenseSelectCheckBox);
            this.Controls.Add(this.campusGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "2023 TCC Police Report Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.campusGroupBox.ResumeLayout(false);
            this.offenseSelectCheckBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCCDataContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox westCheckBox;
        private System.Windows.Forms.CheckBox neCheckBox;
        private System.Windows.Forms.CheckBox seCheckBox;
        private System.Windows.Forms.CheckBox metroCheckBox;
        private System.Windows.Forms.GroupBox campusGroupBox;
        private System.Windows.Forms.Button clearReportButton;
        private System.Windows.Forms.GroupBox offenseSelectCheckBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label campusLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.CheckedListBox offenseListBox;
        private System.Windows.Forms.BindingSource tCCDataContextBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radio2023;
        private System.Windows.Forms.RadioButton radio2022;
        private System.Windows.Forms.RadioButton radio2021;
    }
}

