namespace Fitness_Tracker.Forms
{
    partial class frmMain
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
            this.lblCalories = new System.Windows.Forms.Label();
            this.btnToGoal = new System.Windows.Forms.Button();
            this.btnToCalories = new System.Windows.Forms.Button();
            this.btnToActivities = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnToAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(12, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(141, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username Display";
            // 
            // lblCalories
            // 
            this.lblCalories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCalories.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalories.Location = new System.Drawing.Point(347, 9);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(300, 20);
            this.lblCalories.TabIndex = 0;
            this.lblCalories.Text = "Daily calorie burn goal";
            this.lblCalories.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnToGoal
            // 
            this.btnToGoal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToGoal.Location = new System.Drawing.Point(14, 115);
            this.btnToGoal.Name = "btnToGoal";
            this.btnToGoal.Size = new System.Drawing.Size(309, 89);
            this.btnToGoal.TabIndex = 1;
            this.btnToGoal.Text = "Fitness goals";
            this.btnToGoal.UseVisualStyleBackColor = true;
            this.btnToGoal.Click += new System.EventHandler(this.btnToGoal_Click);
            // 
            // btnToCalories
            // 
            this.btnToCalories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToCalories.Location = new System.Drawing.Point(338, 115);
            this.btnToCalories.Name = "btnToCalories";
            this.btnToCalories.Size = new System.Drawing.Size(307, 89);
            this.btnToCalories.TabIndex = 2;
            this.btnToCalories.Text = "Calories burnt";
            this.btnToCalories.UseVisualStyleBackColor = true;
            this.btnToCalories.Click += new System.EventHandler(this.btnToCalories_Click);
            // 
            // btnToActivities
            // 
            this.btnToActivities.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToActivities.Location = new System.Drawing.Point(14, 224);
            this.btnToActivities.Name = "btnToActivities";
            this.btnToActivities.Size = new System.Drawing.Size(309, 89);
            this.btnToActivities.TabIndex = 3;
            this.btnToActivities.Text = "Choose activities";
            this.btnToActivities.UseVisualStyleBackColor = true;
            this.btnToActivities.Click += new System.EventHandler(this.btnToActivities_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(117, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(459, 50);
            this.label10.TabIndex = 23;
            this.label10.Text = "\"The body achieves what the mind believes.\"\n\n";
            // 
            // btnToAccount
            // 
            this.btnToAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToAccount.Location = new System.Drawing.Point(338, 224);
            this.btnToAccount.Name = "btnToAccount";
            this.btnToAccount.Size = new System.Drawing.Size(309, 89);
            this.btnToAccount.TabIndex = 27;
            this.btnToAccount.Text = "Manage account";
            this.btnToAccount.UseVisualStyleBackColor = true;
            this.btnToAccount.Click += new System.EventHandler(this.btnToAccount_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 333);
            this.Controls.Add(this.btnToAccount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnToActivities);
            this.Controls.Add(this.btnToCalories);
            this.Controls.Add(this.btnToGoal);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.lblUsername);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(675, 380);
            this.Name = "frmMain";
            this.Text = "Fitness Assistant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Button btnToGoal;
        private System.Windows.Forms.Button btnToCalories;
        private System.Windows.Forms.Button btnToActivities;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnToAccount;
    }
}