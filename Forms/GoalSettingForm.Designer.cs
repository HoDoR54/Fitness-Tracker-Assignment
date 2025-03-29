namespace Fitness_Tracker.Forms
{
    partial class GoalSettingForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.setGoalButton = new System.Windows.Forms.Button();
            this.calorieIntake = new System.Windows.Forms.NumericUpDown();
            this.calorieBurningGoal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.calorieIntake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorieBurningGoal)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 69);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label2.Size = new System.Drawing.Size(229, 46);
            this.label2.TabIndex = 10;
            this.label2.Text = "Usual calorie intake per day";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 170);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label3.Size = new System.Drawing.Size(186, 47);
            this.label3.TabIndex = 14;
            this.label3.Text = "Daily calories burning goal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Navy;
            this.cancelButton.Location = new System.Drawing.Point(177, 279);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(109, 41);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // setGoalButton
            // 
            this.setGoalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.setGoalButton.BackColor = System.Drawing.Color.Navy;
            this.setGoalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setGoalButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.setGoalButton.FlatAppearance.BorderSize = 0;
            this.setGoalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setGoalButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setGoalButton.ForeColor = System.Drawing.Color.White;
            this.setGoalButton.Location = new System.Drawing.Point(292, 279);
            this.setGoalButton.Name = "setGoalButton";
            this.setGoalButton.Size = new System.Drawing.Size(109, 41);
            this.setGoalButton.TabIndex = 16;
            this.setGoalButton.Text = "Set goal";
            this.setGoalButton.UseVisualStyleBackColor = false;
            this.setGoalButton.Click += new System.EventHandler(this.btnSetGoal_Click);
            // 
            // calorieIntake
            // 
            this.calorieIntake.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calorieIntake.BackColor = System.Drawing.Color.White;
            this.calorieIntake.Location = new System.Drawing.Point(79, 105);
            this.calorieIntake.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.calorieIntake.Name = "calorieIntake";
            this.calorieIntake.Size = new System.Drawing.Size(249, 34);
            this.calorieIntake.TabIndex = 17;
            // 
            // calorieBurningGoal
            // 
            this.calorieBurningGoal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calorieBurningGoal.BackColor = System.Drawing.Color.White;
            this.calorieBurningGoal.Location = new System.Drawing.Point(79, 207);
            this.calorieBurningGoal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.calorieBurningGoal.Name = "calorieBurningGoal";
            this.calorieBurningGoal.Size = new System.Drawing.Size(249, 34);
            this.calorieBurningGoal.TabIndex = 18;
            // 
            // GoalSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 340);
            this.Controls.Add(this.calorieBurningGoal);
            this.Controls.Add(this.calorieIntake);
            this.Controls.Add(this.setGoalButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(433, 387);
            this.MinimumSize = new System.Drawing.Size(433, 387);
            this.Name = "GoalSettingForm";
            this.Text = "Set a goal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGoalSetting_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.calorieIntake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorieBurningGoal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button setGoalButton;
        private System.Windows.Forms.NumericUpDown calorieIntake;
        private System.Windows.Forms.NumericUpDown calorieBurningGoal;
    }
}