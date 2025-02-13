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
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
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
            this.btnResult = new System.Windows.Forms.Button();
            this.btnAddAct = new System.Windows.Forms.Button();
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.btnTodaysTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMet3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(104, 26);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Activities: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToday
            // 
            this.lblToday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToday.Location = new System.Drawing.Point(392, 9);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(183, 26);
            this.lblToday.TabIndex = 3;
            this.lblToday.Text = "Today";
            this.lblToday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(11, 90);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(358, 210);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Check if your hard work\r\nis paying off!";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGoal
            // 
            this.lblGoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGoal.Location = new System.Drawing.Point(590, 9);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(180, 21);
            this.lblGoal.TabIndex = 5;
            this.lblGoal.Text = "Goal";
            this.lblGoal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMetric1
            // 
            this.lblMetric1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMetric1.AutoSize = true;
            this.lblMetric1.Location = new System.Drawing.Point(415, 168);
            this.lblMetric1.Name = "lblMetric1";
            this.lblMetric1.Size = new System.Drawing.Size(94, 26);
            this.lblMetric1.TabIndex = 6;
            this.lblMetric1.Text = "Metric 1:";
            this.lblMetric1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetric2
            // 
            this.lblMetric2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMetric2.AutoSize = true;
            this.lblMetric2.Location = new System.Drawing.Point(415, 211);
            this.lblMetric2.Name = "lblMetric2";
            this.lblMetric2.Size = new System.Drawing.Size(94, 26);
            this.lblMetric2.TabIndex = 7;
            this.lblMetric2.Text = "Metric 2:";
            this.lblMetric2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetric3
            // 
            this.lblMetric3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMetric3.AutoSize = true;
            this.lblMetric3.Location = new System.Drawing.Point(415, 251);
            this.lblMetric3.Name = "lblMetric3";
            this.lblMetric3.Size = new System.Drawing.Size(94, 26);
            this.lblMetric3.TabIndex = 8;
            this.lblMetric3.Text = "Metric 3:";
            this.lblMetric3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numMet1
            // 
            this.numMet1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numMet1.Location = new System.Drawing.Point(563, 166);
            this.numMet1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numMet1.Name = "numMet1";
            this.numMet1.Size = new System.Drawing.Size(120, 34);
            this.numMet1.TabIndex = 9;
            // 
            // numMet2
            // 
            this.numMet2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numMet2.Location = new System.Drawing.Point(563, 209);
            this.numMet2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numMet2.Name = "numMet2";
            this.numMet2.Size = new System.Drawing.Size(120, 34);
            this.numMet2.TabIndex = 10;
            // 
            // numMet3
            // 
            this.numMet3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numMet3.Location = new System.Drawing.Point(563, 249);
            this.numMet3.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numMet3.Name = "numMet3";
            this.numMet3.Size = new System.Drawing.Size(120, 34);
            this.numMet3.TabIndex = 11;
            // 
            // lblUnit3
            // 
            this.lblUnit3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnit3.AutoSize = true;
            this.lblUnit3.Location = new System.Drawing.Point(689, 251);
            this.lblUnit3.Name = "lblUnit3";
            this.lblUnit3.Size = new System.Drawing.Size(51, 26);
            this.lblUnit3.TabIndex = 12;
            this.lblUnit3.Text = "Unit";
            this.lblUnit3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnit2
            // 
            this.lblUnit2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnit2.AutoSize = true;
            this.lblUnit2.Location = new System.Drawing.Point(689, 211);
            this.lblUnit2.Name = "lblUnit2";
            this.lblUnit2.Size = new System.Drawing.Size(51, 26);
            this.lblUnit2.TabIndex = 13;
            this.lblUnit2.Text = "Unit";
            this.lblUnit2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnit1
            // 
            this.lblUnit1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnit1.AutoSize = true;
            this.lblUnit1.Location = new System.Drawing.Point(689, 168);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(51, 26);
            this.lblUnit1.TabIndex = 14;
            this.lblUnit1.Text = "Unit";
            this.lblUnit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResult
            // 
            this.btnResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResult.Location = new System.Drawing.Point(474, 325);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(145, 46);
            this.btnResult.TabIndex = 15;
            this.btnResult.Text = "See results";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnAddAct
            // 
            this.btnAddAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAct.Location = new System.Drawing.Point(323, 325);
            this.btnAddAct.Name = "btnAddAct";
            this.btnAddAct.Size = new System.Drawing.Size(145, 46);
            this.btnAddAct.TabIndex = 16;
            this.btnAddAct.Text = "Add activity";
            this.btnAddAct.UseVisualStyleBackColor = true;
            this.btnAddAct.Click += new System.EventHandler(this.btnAddAct_Click);
            // 
            // cboActivities
            // 
            this.cboActivities.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(532, 109);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(209, 34);
            this.cboActivities.TabIndex = 17;
            this.cboActivities.SelectedIndexChanged += new System.EventHandler(this.cboActivities_SelectedIndexChanged);
            // 
            // btnTodaysTotal
            // 
            this.btnTodaysTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTodaysTotal.Location = new System.Drawing.Point(625, 325);
            this.btnTodaysTotal.Name = "btnTodaysTotal";
            this.btnTodaysTotal.Size = new System.Drawing.Size(145, 46);
            this.btnTodaysTotal.TabIndex = 18;
            this.btnTodaysTotal.Text = "Today\'s total";
            this.btnTodaysTotal.UseVisualStyleBackColor = true;
            this.btnTodaysTotal.Click += new System.EventHandler(this.btnTodaysTotal_Click);
            // 
            // frmCalories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 383);
            this.Controls.Add(this.btnTodaysTotal);
            this.Controls.Add(this.cboActivities);
            this.Controls.Add(this.btnAddAct);
            this.Controls.Add(this.btnResult);
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
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsername);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(800, 430);
            this.Name = "frmCalories";
            this.Text = "Calories burnt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCalories_FormClosing);
            this.Load += new System.EventHandler(this.frmCalories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblResult;
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
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnAddAct;
        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.Button btnTodaysTotal;
    }
}