﻿namespace Fitness_Tracker.Forms
{
    partial class frmGoalSetting
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSetGoal = new System.Windows.Forms.Button();
            this.numIntake = new System.Windows.Forms.NumericUpDown();
            this.numGoal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numIntake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGoal)).BeginInit();
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
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Navy;
            this.btnCancel.Location = new System.Drawing.Point(177, 279);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 41);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSetGoal
            // 
            this.btnSetGoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetGoal.BackColor = System.Drawing.Color.Navy;
            this.btnSetGoal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetGoal.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnSetGoal.FlatAppearance.BorderSize = 0;
            this.btnSetGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetGoal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetGoal.ForeColor = System.Drawing.Color.White;
            this.btnSetGoal.Location = new System.Drawing.Point(292, 279);
            this.btnSetGoal.Name = "btnSetGoal";
            this.btnSetGoal.Size = new System.Drawing.Size(109, 41);
            this.btnSetGoal.TabIndex = 16;
            this.btnSetGoal.Text = "Set goal";
            this.btnSetGoal.UseVisualStyleBackColor = false;
            this.btnSetGoal.Click += new System.EventHandler(this.btnSetGoal_Click);
            // 
            // numIntake
            // 
            this.numIntake.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numIntake.BackColor = System.Drawing.Color.White;
            this.numIntake.Location = new System.Drawing.Point(79, 105);
            this.numIntake.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numIntake.Name = "numIntake";
            this.numIntake.Size = new System.Drawing.Size(249, 34);
            this.numIntake.TabIndex = 17;
            // 
            // numGoal
            // 
            this.numGoal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numGoal.BackColor = System.Drawing.Color.White;
            this.numGoal.Location = new System.Drawing.Point(79, 207);
            this.numGoal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numGoal.Name = "numGoal";
            this.numGoal.Size = new System.Drawing.Size(249, 34);
            this.numGoal.TabIndex = 18;
            // 
            // frmGoalSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 340);
            this.Controls.Add(this.numGoal);
            this.Controls.Add(this.numIntake);
            this.Controls.Add(this.btnSetGoal);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(433, 387);
            this.MinimumSize = new System.Drawing.Size(433, 387);
            this.Name = "frmGoalSetting";
            this.Text = "Set a goal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGoalSetting_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numIntake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGoal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSetGoal;
        private System.Windows.Forms.NumericUpDown numIntake;
        private System.Windows.Forms.NumericUpDown numGoal;
    }
}