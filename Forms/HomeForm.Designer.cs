namespace Fitness_Tracker.Forms
{
    partial class HomeForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.calorieGoalLabel = new System.Windows.Forms.Label();
            this.toGoalButton = new System.Windows.Forms.Button();
            this.toCaloriesButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.toAccountButton = new System.Windows.Forms.Button();
            this.toHistoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(49, 19);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(155, 22);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username Display";
            // 
            // calorieGoalLabel
            // 
            this.calorieGoalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calorieGoalLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calorieGoalLabel.Location = new System.Drawing.Point(446, 19);
            this.calorieGoalLabel.Name = "calorieGoalLabel";
            this.calorieGoalLabel.Size = new System.Drawing.Size(254, 26);
            this.calorieGoalLabel.TabIndex = 0;
            this.calorieGoalLabel.Text = "Daily calorie burn goal";
            this.calorieGoalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // toGoalButton
            // 
            this.toGoalButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toGoalButton.BackColor = System.Drawing.Color.Navy;
            this.toGoalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toGoalButton.FlatAppearance.BorderSize = 0;
            this.toGoalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toGoalButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toGoalButton.ForeColor = System.Drawing.Color.White;
            this.toGoalButton.Location = new System.Drawing.Point(234, 283);
            this.toGoalButton.Name = "toGoalButton";
            this.toGoalButton.Size = new System.Drawing.Size(236, 57);
            this.toGoalButton.TabIndex = 1;
            this.toGoalButton.Text = "Fitness goals";
            this.toGoalButton.UseVisualStyleBackColor = false;
            this.toGoalButton.Click += new System.EventHandler(this.toGoalButton_Click);
            // 
            // toCaloriesButton
            // 
            this.toCaloriesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toCaloriesButton.BackColor = System.Drawing.Color.Navy;
            this.toCaloriesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toCaloriesButton.FlatAppearance.BorderSize = 0;
            this.toCaloriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toCaloriesButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toCaloriesButton.ForeColor = System.Drawing.Color.White;
            this.toCaloriesButton.Location = new System.Drawing.Point(234, 137);
            this.toCaloriesButton.Name = "toCaloriesButton";
            this.toCaloriesButton.Size = new System.Drawing.Size(236, 57);
            this.toCaloriesButton.TabIndex = 2;
            this.toCaloriesButton.Text = "Calories burnt";
            this.toCaloriesButton.UseVisualStyleBackColor = false;
            this.toCaloriesButton.Click += new System.EventHandler(this.toCaloriesButton_Click);
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
            // toAccountButton
            // 
            this.toAccountButton.BackColor = System.Drawing.Color.Chocolate;
            this.toAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toAccountButton.FlatAppearance.BorderSize = 0;
            this.toAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toAccountButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAccountButton.ForeColor = System.Drawing.Color.White;
            this.toAccountButton.Location = new System.Drawing.Point(10, 11);
            this.toAccountButton.Name = "toAccountButton";
            this.toAccountButton.Size = new System.Drawing.Size(34, 34);
            this.toAccountButton.TabIndex = 27;
            this.toAccountButton.Text = "U";
            this.toAccountButton.UseVisualStyleBackColor = false;
            this.toAccountButton.Click += new System.EventHandler(this.toAccountButton_Click);
            // 
            // toHistoryButton
            // 
            this.toHistoryButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toHistoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toHistoryButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.toHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toHistoryButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toHistoryButton.ForeColor = System.Drawing.Color.Navy;
            this.toHistoryButton.Location = new System.Drawing.Point(234, 211);
            this.toHistoryButton.Name = "toHistoryButton";
            this.toHistoryButton.Size = new System.Drawing.Size(236, 57);
            this.toHistoryButton.TabIndex = 28;
            this.toHistoryButton.Text = "History";
            this.toHistoryButton.UseVisualStyleBackColor = true;
            this.toHistoryButton.Click += new System.EventHandler(this.toHistoryButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(710, 391);
            this.Controls.Add(this.toHistoryButton);
            this.Controls.Add(this.toAccountButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.toCaloriesButton);
            this.Controls.Add(this.toGoalButton);
            this.Controls.Add(this.calorieGoalLabel);
            this.Controls.Add(this.usernameLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(728, 438);
            this.Name = "HomeForm";
            this.Text = "Fitness Tracker";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label calorieGoalLabel;
        private System.Windows.Forms.Button toGoalButton;
        private System.Windows.Forms.Button toCaloriesButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button toAccountButton;
        private System.Windows.Forms.Button toHistoryButton;
    }
}