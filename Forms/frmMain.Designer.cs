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
            this.label10 = new System.Windows.Forms.Label();
            this.btnToAccount = new System.Windows.Forms.Button();
            this.btnToHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(49, 19);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(155, 22);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username Display";
            // 
            // lblCalories
            // 
            this.lblCalories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCalories.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalories.Location = new System.Drawing.Point(446, 19);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(254, 17);
            this.lblCalories.TabIndex = 0;
            this.lblCalories.Text = "Daily calorie burn goal";
            this.lblCalories.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnToGoal
            // 
            this.btnToGoal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToGoal.BackColor = System.Drawing.Color.Navy;
            this.btnToGoal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToGoal.FlatAppearance.BorderSize = 0;
            this.btnToGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToGoal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToGoal.ForeColor = System.Drawing.Color.White;
            this.btnToGoal.Location = new System.Drawing.Point(234, 283);
            this.btnToGoal.Name = "btnToGoal";
            this.btnToGoal.Size = new System.Drawing.Size(236, 57);
            this.btnToGoal.TabIndex = 1;
            this.btnToGoal.Text = "Fitness goals";
            this.btnToGoal.UseVisualStyleBackColor = false;
            this.btnToGoal.Click += new System.EventHandler(this.btnToGoal_Click);
            // 
            // btnToCalories
            // 
            this.btnToCalories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToCalories.BackColor = System.Drawing.Color.Navy;
            this.btnToCalories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToCalories.FlatAppearance.BorderSize = 0;
            this.btnToCalories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToCalories.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToCalories.ForeColor = System.Drawing.Color.White;
            this.btnToCalories.Location = new System.Drawing.Point(234, 137);
            this.btnToCalories.Name = "btnToCalories";
            this.btnToCalories.Size = new System.Drawing.Size(236, 57);
            this.btnToCalories.TabIndex = 2;
            this.btnToCalories.Text = "Calories burnt";
            this.btnToCalories.UseVisualStyleBackColor = false;
            this.btnToCalories.Click += new System.EventHandler(this.btnToCalories_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(117, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(550, 64);
            this.label10.TabIndex = 23;
            this.label10.Text = "\"The body achieves what the mind believes.\"\n\n";
            // 
            // btnToAccount
            // 
            this.btnToAccount.BackColor = System.Drawing.Color.Chocolate;
            this.btnToAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToAccount.FlatAppearance.BorderSize = 0;
            this.btnToAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToAccount.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToAccount.ForeColor = System.Drawing.Color.White;
            this.btnToAccount.Location = new System.Drawing.Point(10, 11);
            this.btnToAccount.Name = "btnToAccount";
            this.btnToAccount.Size = new System.Drawing.Size(34, 34);
            this.btnToAccount.TabIndex = 27;
            this.btnToAccount.Text = "U";
            this.btnToAccount.UseVisualStyleBackColor = false;
            this.btnToAccount.Click += new System.EventHandler(this.btnToAccount_Click);
            // 
            // btnToHistory
            // 
            this.btnToHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToHistory.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnToHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToHistory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToHistory.ForeColor = System.Drawing.Color.Navy;
            this.btnToHistory.Location = new System.Drawing.Point(234, 211);
            this.btnToHistory.Name = "btnToHistory";
            this.btnToHistory.Size = new System.Drawing.Size(236, 57);
            this.btnToHistory.TabIndex = 28;
            this.btnToHistory.Text = "History";
            this.btnToHistory.UseVisualStyleBackColor = true;
            this.btnToHistory.Click += new System.EventHandler(this.btnToHistory_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(710, 391);
            this.Controls.Add(this.btnToHistory);
            this.Controls.Add(this.btnToAccount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnToCalories);
            this.Controls.Add(this.btnToGoal);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.lblUsername);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(728, 438);
            this.Name = "frmMain";
            this.Text = "Fitness Tracker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Button btnToGoal;
        private System.Windows.Forms.Button btnToCalories;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnToAccount;
        private System.Windows.Forms.Button btnToHistory;
    }
}