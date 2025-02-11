﻿namespace Fitness_Tracker.Forms
{
    partial class frmRegistration
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.numCurrentWeight = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numGoalWeight = new System.Windows.Forms.NumericUpDown();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGoalWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(26, 116);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label1.Size = new System.Drawing.Size(200, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(26, 162);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label2.Size = new System.Drawing.Size(200, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Location = new System.Drawing.Point(26, 208);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label3.Size = new System.Drawing.Size(200, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of birth";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Location = new System.Drawing.Point(26, 346);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label4.Size = new System.Drawing.Size(200, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Location = new System.Drawing.Point(26, 300);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label5.Size = new System.Drawing.Size(200, 46);
            this.label5.TabIndex = 4;
            this.label5.Text = "Body weight";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Location = new System.Drawing.Point(26, 392);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label6.Size = new System.Drawing.Size(200, 46);
            this.label6.TabIndex = 5;
            this.label6.Text = "Body wieght goal";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Location = new System.Drawing.Point(26, 254);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label7.Size = new System.Drawing.Size(200, 46);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gender";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Location = new System.Drawing.Point(232, 113);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 34);
            this.txtUsername.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(232, 159);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 34);
            this.txtName.TabIndex = 8;
            // 
            // dtpDob
            // 
            this.dtpDob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDob.Location = new System.Drawing.Point(232, 208);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(300, 34);
            this.dtpDob.TabIndex = 9;
            // 
            // rdoMale
            // 
            this.rdoMale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(232, 254);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(78, 30);
            this.rdoMale.TabIndex = 10;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(387, 254);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(100, 30);
            this.rdoFemale.TabIndex = 11;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // numCurrentWeight
            // 
            this.numCurrentWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numCurrentWeight.DecimalPlaces = 2;
            this.numCurrentWeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numCurrentWeight.Location = new System.Drawing.Point(232, 300);
            this.numCurrentWeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numCurrentWeight.Name = "numCurrentWeight";
            this.numCurrentWeight.Size = new System.Drawing.Size(144, 34);
            this.numCurrentWeight.TabIndex = 12;
            this.numCurrentWeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numHeight
            // 
            this.numHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numHeight.DecimalPlaces = 2;
            this.numHeight.Location = new System.Drawing.Point(232, 349);
            this.numHeight.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(144, 34);
            this.numHeight.TabIndex = 14;
            this.numHeight.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Location = new System.Drawing.Point(382, 340);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label8.Size = new System.Drawing.Size(150, 46);
            this.label8.TabIndex = 15;
            this.label8.Text = "cm";
            // 
            // numGoalWeight
            // 
            this.numGoalWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numGoalWeight.DecimalPlaces = 2;
            this.numGoalWeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numGoalWeight.Location = new System.Drawing.Point(232, 398);
            this.numGoalWeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numGoalWeight.Name = "numGoalWeight";
            this.numGoalWeight.Size = new System.Drawing.Size(144, 34);
            this.numGoalWeight.TabIndex = 16;
            this.numGoalWeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(232, 441);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = 'o';
            this.txtPassword.Size = new System.Drawing.Size(300, 34);
            this.txtPassword.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Location = new System.Drawing.Point(26, 441);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label9.Size = new System.Drawing.Size(200, 46);
            this.label9.TabIndex = 18;
            this.label9.Text = "Password";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignUp.Location = new System.Drawing.Point(448, 530);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(109, 41);
            this.btnSignUp.TabIndex = 20;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(333, 530);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 41);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(148, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(327, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "A daily assistant for your fitness";
            // 
            // linkLogin
            // 
            this.linkLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLogin.AutoSize = true;
            this.linkLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogin.Location = new System.Drawing.Point(182, 62);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(263, 22);
            this.linkLogin.TabIndex = 23;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Already have an account? log in";
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.Location = new System.Drawing.Point(382, 300);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label11.Size = new System.Drawing.Size(150, 46);
            this.label11.TabIndex = 24;
            this.label11.Text = "kg";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.Location = new System.Drawing.Point(382, 392);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label12.Size = new System.Drawing.Size(150, 46);
            this.label12.TabIndex = 25;
            this.label12.Text = "kg";
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 583);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.linkLogin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numGoalWeight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.numCurrentWeight);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(587, 630);
            this.Name = "frmRegistration";
            this.Text = "Create a new account";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegisteration_FormClosing);
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGoalWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.NumericUpDown numCurrentWeight;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numGoalWeight;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLogin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}