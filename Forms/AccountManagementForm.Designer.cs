namespace Fitness_Tracker.Forms
{
    partial class AccountManagementForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.deleteAccButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.anotherAccButton = new System.Windows.Forms.Button();
            this.newAccButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(137, 41);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(184, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name of the user";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameLabel.Location = new System.Drawing.Point(138, 66);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(152, 19);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username: username";
            // 
            // deleteAccButton
            // 
            this.deleteAccButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteAccButton.BackColor = System.Drawing.Color.Navy;
            this.deleteAccButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.deleteAccButton.FlatAppearance.BorderSize = 0;
            this.deleteAccButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAccButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAccButton.ForeColor = System.Drawing.Color.White;
            this.deleteAccButton.Location = new System.Drawing.Point(69, 103);
            this.deleteAccButton.Name = "deleteAccButton";
            this.deleteAccButton.Size = new System.Drawing.Size(305, 57);
            this.deleteAccButton.TabIndex = 28;
            this.deleteAccButton.Text = "Delete account";
            this.deleteAccButton.UseVisualStyleBackColor = false;
            this.deleteAccButton.Click += new System.EventHandler(this.btnDeleteAcc_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logOutButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.Navy;
            this.logOutButton.Location = new System.Drawing.Point(69, 166);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(305, 57);
            this.logOutButton.TabIndex = 30;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // anotherAccButton
            // 
            this.anotherAccButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.anotherAccButton.BackColor = System.Drawing.Color.Navy;
            this.anotherAccButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.anotherAccButton.FlatAppearance.BorderSize = 0;
            this.anotherAccButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anotherAccButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anotherAccButton.ForeColor = System.Drawing.Color.White;
            this.anotherAccButton.Location = new System.Drawing.Point(69, 229);
            this.anotherAccButton.Name = "anotherAccButton";
            this.anotherAccButton.Size = new System.Drawing.Size(305, 57);
            this.anotherAccButton.TabIndex = 32;
            this.anotherAccButton.Text = "Log in with another account";
            this.anotherAccButton.UseVisualStyleBackColor = false;
            this.anotherAccButton.Click += new System.EventHandler(this.btnAnthAcc_Click);
            // 
            // newAccButton
            // 
            this.newAccButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newAccButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.newAccButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newAccButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccButton.ForeColor = System.Drawing.Color.Navy;
            this.newAccButton.Location = new System.Drawing.Point(69, 292);
            this.newAccButton.Name = "newAccButton";
            this.newAccButton.Size = new System.Drawing.Size(305, 57);
            this.newAccButton.TabIndex = 31;
            this.newAccButton.Text = "Create a new account";
            this.newAccButton.UseVisualStyleBackColor = true;
            this.newAccButton.Click += new System.EventHandler(this.btnNewAcc_Click);
            // 
            // AccountManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 403);
            this.Controls.Add(this.anotherAccButton);
            this.Controls.Add(this.newAccButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.deleteAccButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(450, 450);
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "AccountManagementForm";
            this.Text = "Account";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAccountMgmt_FormClosing);
            this.Load += new System.EventHandler(this.frmAccountMgmt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button deleteAccButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button anotherAccButton;
        private System.Windows.Forms.Button newAccButton;
    }
}