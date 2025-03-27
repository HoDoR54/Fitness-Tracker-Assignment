namespace Fitness_Tracker.Forms
{
    partial class frmCalories
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
            this.lblToday = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblMetric1 = new System.Windows.Forms.Label();
            this.lblMetric2 = new System.Windows.Forms.Label();
            this.lblMetric3 = new System.Windows.Forms.Label();
            this.numMet1 = new System.Windows.Forms.NumericUpDown();
            this.numMet2 = new System.Windows.Forms.NumericUpDown();
            this.numMet3 = new System.Windows.Forms.NumericUpDown();
            this.lblUnit3 = new System.Windows.Forms.Label();
            this.lblUnit2 = new System.Windows.Forms.Label();
            this.lblUnit1 = new System.Windows.Forms.Label();
            this.btnAddAct = new System.Windows.Forms.Button();
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnHistory = new System.Windows.Forms.Button();
            this.lblPercent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMet3)).BeginInit();
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
            this.lblToday.BackColor = System.Drawing.Color.Transparent;
            this.lblToday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToday.Location = new System.Drawing.Point(311, 9);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(209, 26);
            this.lblToday.TabIndex = 3;
            this.lblToday.Text = "Today";
            this.lblToday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGoal
            // 
            this.lblGoal.BackColor = System.Drawing.Color.Transparent;
            this.lblGoal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoal.Location = new System.Drawing.Point(12, 9);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(256, 26);
            this.lblGoal.TabIndex = 5;
            this.lblGoal.Text = "Goal";
            this.lblGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMetric1
            // 
            this.lblMetric1.AutoSize = true;
            this.lblMetric1.BackColor = System.Drawing.Color.Transparent;
            this.lblMetric1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMetric1.Location = new System.Drawing.Point(52, 229);
            this.lblMetric1.Name = "lblMetric1";
            this.lblMetric1.Size = new System.Drawing.Size(61, 17);
            this.lblMetric1.TabIndex = 6;
            this.lblMetric1.Text = "Metric 1:";
            this.lblMetric1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetric2
            // 
            this.lblMetric2.AutoSize = true;
            this.lblMetric2.BackColor = System.Drawing.Color.Transparent;
            this.lblMetric2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMetric2.Location = new System.Drawing.Point(52, 291);
            this.lblMetric2.Name = "lblMetric2";
            this.lblMetric2.Size = new System.Drawing.Size(61, 17);
            this.lblMetric2.TabIndex = 7;
            this.lblMetric2.Text = "Metric 2:";
            this.lblMetric2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetric3
            // 
            this.lblMetric3.AutoSize = true;
            this.lblMetric3.BackColor = System.Drawing.Color.Transparent;
            this.lblMetric3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMetric3.Location = new System.Drawing.Point(52, 355);
            this.lblMetric3.Name = "lblMetric3";
            this.lblMetric3.Size = new System.Drawing.Size(61, 17);
            this.lblMetric3.TabIndex = 8;
            this.lblMetric3.Text = "Metric 3:";
            this.lblMetric3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numMet1
            // 
            this.numMet1.Location = new System.Drawing.Point(55, 249);
            this.numMet1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numMet1.Name = "numMet1";
            this.numMet1.Size = new System.Drawing.Size(163, 34);
            this.numMet1.TabIndex = 2;
            // 
            // numMet2
            // 
            this.numMet2.Location = new System.Drawing.Point(55, 311);
            this.numMet2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numMet2.Name = "numMet2";
            this.numMet2.Size = new System.Drawing.Size(163, 34);
            this.numMet2.TabIndex = 3;
            // 
            // numMet3
            // 
            this.numMet3.Location = new System.Drawing.Point(55, 375);
            this.numMet3.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numMet3.Name = "numMet3";
            this.numMet3.Size = new System.Drawing.Size(163, 34);
            this.numMet3.TabIndex = 4;
            // 
            // lblUnit3
            // 
            this.lblUnit3.AutoSize = true;
            this.lblUnit3.Location = new System.Drawing.Point(224, 383);
            this.lblUnit3.Name = "lblUnit3";
            this.lblUnit3.Size = new System.Drawing.Size(51, 26);
            this.lblUnit3.TabIndex = 12;
            this.lblUnit3.Text = "Unit";
            this.lblUnit3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnit2
            // 
            this.lblUnit2.AutoSize = true;
            this.lblUnit2.Location = new System.Drawing.Point(224, 321);
            this.lblUnit2.Name = "lblUnit2";
            this.lblUnit2.Size = new System.Drawing.Size(51, 26);
            this.lblUnit2.TabIndex = 13;
            this.lblUnit2.Text = "Unit";
            this.lblUnit2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnit1
            // 
            this.lblUnit1.AutoSize = true;
            this.lblUnit1.Location = new System.Drawing.Point(222, 257);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(51, 26);
            this.lblUnit1.TabIndex = 14;
            this.lblUnit1.Text = "Unit";
            this.lblUnit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddAct
            // 
            this.btnAddAct.BackColor = System.Drawing.Color.Navy;
            this.btnAddAct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAct.ForeColor = System.Drawing.Color.White;
            this.btnAddAct.Location = new System.Drawing.Point(327, 368);
            this.btnAddAct.Name = "btnAddAct";
            this.btnAddAct.Size = new System.Drawing.Size(144, 41);
            this.btnAddAct.TabIndex = 6;
            this.btnAddAct.Text = "Add activity";
            this.btnAddAct.UseVisualStyleBackColor = false;
            this.btnAddAct.Click += new System.EventHandler(this.btnAddAct_Click);
            // 
            // cboActivities
            // 
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(55, 187);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(220, 34);
            this.cboActivities.TabIndex = 1;
            this.cboActivities.SelectedIndexChanged += new System.EventHandler(this.cboActivities_SelectedIndexChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(55, 67);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(416, 26);
            this.progressBar.TabIndex = 19;
            // 
            // btnHistory
            // 
            this.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.Navy;
            this.btnHistory.Location = new System.Drawing.Point(327, 314);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(144, 41);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "Recents";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(50, 96);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(158, 26);
            this.lblPercent.TabIndex = 21;
            this.lblPercent.Text = "100/100 (100%)";
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCalories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 453);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.cboActivities);
            this.Controls.Add(this.btnAddAct);
            this.Controls.Add(this.lblUnit1);
            this.Controls.Add(this.lblUnit2);
            this.Controls.Add(this.lblUnit3);
            this.Controls.Add(this.numMet3);
            this.Controls.Add(this.numMet2);
            this.Controls.Add(this.numMet1);
            this.Controls.Add(this.lblMetric3);
            this.Controls.Add(this.lblMetric2);
            this.Controls.Add(this.lblMetric1);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(550, 500);
            this.MinimumSize = new System.Drawing.Size(550, 500);
            this.Name = "frmCalories";
            this.Text = "Your progress";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCalories_FormClosing);
            this.Load += new System.EventHandler(this.frmCalories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblMetric1;
        private System.Windows.Forms.Label lblMetric2;
        private System.Windows.Forms.Label lblMetric3;
        private System.Windows.Forms.NumericUpDown numMet1;
        private System.Windows.Forms.NumericUpDown numMet2;
        private System.Windows.Forms.NumericUpDown numMet3;
        private System.Windows.Forms.Label lblUnit3;
        private System.Windows.Forms.Label lblUnit2;
        private System.Windows.Forms.Label lblUnit1;
        private System.Windows.Forms.Button btnAddAct;
        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Label lblPercent;
    }
}