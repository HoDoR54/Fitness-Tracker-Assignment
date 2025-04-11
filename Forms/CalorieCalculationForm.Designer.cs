namespace Fitness_Tracker.Forms
{
    partial class CalorieCalculationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateDisplay = new System.Windows.Forms.Label();
            this.goalDisplay = new System.Windows.Forms.Label();
            this.metricOneLabel = new System.Windows.Forms.Label();
            this.metricTwoLabel = new System.Windows.Forms.Label();
            this.metricThreeLabel = new System.Windows.Forms.Label();
            this.metricOne = new System.Windows.Forms.NumericUpDown();
            this.metricTwo = new System.Windows.Forms.NumericUpDown();
            this.metricThree = new System.Windows.Forms.NumericUpDown();
            this.unitThreeLabel = new System.Windows.Forms.Label();
            this.unitTwoLabel = new System.Windows.Forms.Label();
            this.unitOneLabel = new System.Windows.Forms.Label();
            this.addActivityButton = new System.Windows.Forms.Button();
            this.activityComboBox = new System.Windows.Forms.ComboBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.toHistoryButton = new System.Windows.Forms.Button();
            this.percentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metricOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metricTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metricThree)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(52, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Activities: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToday
            // 
            this.dateDisplay.BackColor = System.Drawing.Color.Transparent;
            this.dateDisplay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDisplay.Location = new System.Drawing.Point(311, 9);
            this.dateDisplay.Name = "lblToday";
            this.dateDisplay.Size = new System.Drawing.Size(209, 26);
            this.dateDisplay.TabIndex = 3;
            this.dateDisplay.Text = "Today";
            this.dateDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGoal
            // 
            this.goalDisplay.BackColor = System.Drawing.Color.Transparent;
            this.goalDisplay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalDisplay.Location = new System.Drawing.Point(12, 9);
            this.goalDisplay.Name = "lblGoal";
            this.goalDisplay.Size = new System.Drawing.Size(256, 26);
            this.goalDisplay.TabIndex = 5;
            this.goalDisplay.Text = "Goal";
            this.goalDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metricOneLabel
            // 
            this.metricOneLabel.AutoSize = true;
            this.metricOneLabel.BackColor = System.Drawing.Color.Transparent;
            this.metricOneLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metricOneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metricOneLabel.Location = new System.Drawing.Point(52, 229);
            this.metricOneLabel.Name = "metricOneLabel";
            this.metricOneLabel.Size = new System.Drawing.Size(61, 17);
            this.metricOneLabel.TabIndex = 6;
            this.metricOneLabel.Text = "Metric 1:";
            this.metricOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metricTwoLabel
            // 
            this.metricTwoLabel.AutoSize = true;
            this.metricTwoLabel.BackColor = System.Drawing.Color.Transparent;
            this.metricTwoLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metricTwoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metricTwoLabel.Location = new System.Drawing.Point(52, 291);
            this.metricTwoLabel.Name = "metricTwoLabel";
            this.metricTwoLabel.Size = new System.Drawing.Size(61, 17);
            this.metricTwoLabel.TabIndex = 7;
            this.metricTwoLabel.Text = "Metric 2:";
            this.metricTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metricThreeLabel
            // 
            this.metricThreeLabel.AutoSize = true;
            this.metricThreeLabel.BackColor = System.Drawing.Color.Transparent;
            this.metricThreeLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metricThreeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metricThreeLabel.Location = new System.Drawing.Point(52, 355);
            this.metricThreeLabel.Name = "metricThreeLabel";
            this.metricThreeLabel.Size = new System.Drawing.Size(61, 17);
            this.metricThreeLabel.TabIndex = 8;
            this.metricThreeLabel.Text = "Metric 3:";
            this.metricThreeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metricOne
            // 
            this.metricOne.Location = new System.Drawing.Point(55, 249);
            this.metricOne.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.metricOne.Name = "metricOne";
            this.metricOne.Size = new System.Drawing.Size(163, 34);
            this.metricOne.TabIndex = 2;
            // 
            // metricTwo
            // 
            this.metricTwo.Location = new System.Drawing.Point(55, 311);
            this.metricTwo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.metricTwo.Name = "metricTwo";
            this.metricTwo.Size = new System.Drawing.Size(163, 34);
            this.metricTwo.TabIndex = 3;
            // 
            // metricThree
            // 
            this.metricThree.Location = new System.Drawing.Point(55, 375);
            this.metricThree.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.metricThree.Name = "metricThree";
            this.metricThree.Size = new System.Drawing.Size(163, 34);
            this.metricThree.TabIndex = 4;
            // 
            // unitThreeLabel
            // 
            this.unitThreeLabel.AutoSize = true;
            this.unitThreeLabel.Location = new System.Drawing.Point(224, 383);
            this.unitThreeLabel.Name = "unitThreeLabel";
            this.unitThreeLabel.Size = new System.Drawing.Size(51, 26);
            this.unitThreeLabel.TabIndex = 12;
            this.unitThreeLabel.Text = "Unit";
            this.unitThreeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unitTwoLabel
            // 
            this.unitTwoLabel.AutoSize = true;
            this.unitTwoLabel.Location = new System.Drawing.Point(224, 321);
            this.unitTwoLabel.Name = "unitTwoLabel";
            this.unitTwoLabel.Size = new System.Drawing.Size(51, 26);
            this.unitTwoLabel.TabIndex = 13;
            this.unitTwoLabel.Text = "Unit";
            this.unitTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unitOneLabel
            // 
            this.unitOneLabel.AutoSize = true;
            this.unitOneLabel.Location = new System.Drawing.Point(222, 257);
            this.unitOneLabel.Name = "unitOneLabel";
            this.unitOneLabel.Size = new System.Drawing.Size(51, 26);
            this.unitOneLabel.TabIndex = 14;
            this.unitOneLabel.Text = "Unit";
            this.unitOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addActivityButton
            // 
            this.addActivityButton.BackColor = System.Drawing.Color.Navy;
            this.addActivityButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addActivityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addActivityButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addActivityButton.ForeColor = System.Drawing.Color.White;
            this.addActivityButton.Location = new System.Drawing.Point(327, 368);
            this.addActivityButton.Name = "addActivityButton";
            this.addActivityButton.Size = new System.Drawing.Size(144, 41);
            this.addActivityButton.TabIndex = 6;
            this.addActivityButton.Text = "Add activity";
            this.addActivityButton.UseVisualStyleBackColor = false;
            this.addActivityButton.Click += new System.EventHandler(this.addActivityButton_Click);
            // 
            // activityComboBox
            // 
            this.activityComboBox.FormattingEnabled = true;
            this.activityComboBox.Location = new System.Drawing.Point(55, 187);
            this.activityComboBox.Name = "activityComboBox";
            this.activityComboBox.Size = new System.Drawing.Size(220, 34);
            this.activityComboBox.TabIndex = 1;
            this.activityComboBox.SelectedIndexChanged += new System.EventHandler(this.activityComboBox_SelectedIndexChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(55, 67);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(416, 26);
            this.progressBar.TabIndex = 19;
            // 
            // toHistoryButton
            // 
            this.toHistoryButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.toHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toHistoryButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toHistoryButton.ForeColor = System.Drawing.Color.Navy;
            this.toHistoryButton.Location = new System.Drawing.Point(327, 314);
            this.toHistoryButton.Name = "toHistoryButton";
            this.toHistoryButton.Size = new System.Drawing.Size(144, 41);
            this.toHistoryButton.TabIndex = 5;
            this.toHistoryButton.Text = "Recents";
            this.toHistoryButton.UseVisualStyleBackColor = true;
            this.toHistoryButton.Click += new System.EventHandler(this.toHistoryButton_Click);
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Location = new System.Drawing.Point(50, 96);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(158, 26);
            this.percentLabel.TabIndex = 21;
            this.percentLabel.Text = "100/100 (100%)";
            this.percentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CalorieCalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 453);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.toHistoryButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.activityComboBox);
            this.Controls.Add(this.addActivityButton);
            this.Controls.Add(this.unitOneLabel);
            this.Controls.Add(this.unitTwoLabel);
            this.Controls.Add(this.unitThreeLabel);
            this.Controls.Add(this.metricThree);
            this.Controls.Add(this.metricTwo);
            this.Controls.Add(this.metricOne);
            this.Controls.Add(this.metricThreeLabel);
            this.Controls.Add(this.metricTwoLabel);
            this.Controls.Add(this.metricOneLabel);
            this.Controls.Add(this.goalDisplay);
            this.Controls.Add(this.dateDisplay);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(550, 500);
            this.MinimumSize = new System.Drawing.Size(550, 500);
            this.Name = "CalorieCalculationForm";
            this.Text = "Your progress";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalorieCalculationForm_FormClosing);
            this.Load += new System.EventHandler(this.CalorieCalculationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metricOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metricTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metricThree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateDisplay;
        private System.Windows.Forms.Label goalDisplay;
        private System.Windows.Forms.Label metricOneLabel;
        private System.Windows.Forms.Label metricTwoLabel;
        private System.Windows.Forms.Label metricThreeLabel;
        private System.Windows.Forms.NumericUpDown metricOne;
        private System.Windows.Forms.NumericUpDown metricTwo;
        private System.Windows.Forms.NumericUpDown metricThree;
        private System.Windows.Forms.Label unitThreeLabel;
        private System.Windows.Forms.Label unitTwoLabel;
        private System.Windows.Forms.Label unitOneLabel;
        private System.Windows.Forms.Button addActivityButton;
        private System.Windows.Forms.ComboBox activityComboBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button toHistoryButton;
        private System.Windows.Forms.Label percentLabel;
    }
}