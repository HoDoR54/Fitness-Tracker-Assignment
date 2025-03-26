namespace Fitness_Tracker.Forms
{
    partial class frmAccountMgmt
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnDeleteAcc = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAnthAcc = new System.Windows.Forms.Button();
            this.btnNewAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(88, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(184, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name of the user";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUsername.Location = new System.Drawing.Point(108, 65);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(152, 19);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username: username";
            // 
            // btnDeleteAcc
            // 
            this.btnDeleteAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteAcc.BackColor = System.Drawing.Color.Navy;
            this.btnDeleteAcc.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnDeleteAcc.FlatAppearance.BorderSize = 0;
            this.btnDeleteAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAcc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAcc.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAcc.Location = new System.Drawing.Point(71, 104);
            this.btnDeleteAcc.Name = "btnDeleteAcc";
            this.btnDeleteAcc.Size = new System.Drawing.Size(236, 57);
            this.btnDeleteAcc.TabIndex = 28;
            this.btnDeleteAcc.Text = "Delete account";
            this.btnDeleteAcc.UseVisualStyleBackColor = false;
            this.btnDeleteAcc.Click += new System.EventHandler(this.btnDeleteAcc_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Navy;
            this.btnLogOut.Location = new System.Drawing.Point(71, 167);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(236, 57);
            this.btnLogOut.TabIndex = 30;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAnthAcc
            // 
            this.btnAnthAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnthAcc.BackColor = System.Drawing.Color.Navy;
            this.btnAnthAcc.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnAnthAcc.FlatAppearance.BorderSize = 0;
            this.btnAnthAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnthAcc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnthAcc.ForeColor = System.Drawing.Color.White;
            this.btnAnthAcc.Location = new System.Drawing.Point(71, 230);
            this.btnAnthAcc.Name = "btnAnthAcc";
            this.btnAnthAcc.Size = new System.Drawing.Size(236, 57);
            this.btnAnthAcc.TabIndex = 32;
            this.btnAnthAcc.Text = "Log in with another account";
            this.btnAnthAcc.UseVisualStyleBackColor = false;
            this.btnAnthAcc.Click += new System.EventHandler(this.btnAnthAcc_Click);
            // 
            // btnNewAcc
            // 
            this.btnNewAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewAcc.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnNewAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAcc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAcc.ForeColor = System.Drawing.Color.Navy;
            this.btnNewAcc.Location = new System.Drawing.Point(71, 293);
            this.btnNewAcc.Name = "btnNewAcc";
            this.btnNewAcc.Size = new System.Drawing.Size(236, 57);
            this.btnNewAcc.TabIndex = 31;
            this.btnNewAcc.Text = "Create a new account";
            this.btnNewAcc.UseVisualStyleBackColor = true;
            this.btnNewAcc.Click += new System.EventHandler(this.btnNewAcc_Click);
            // 
            // frmAccountMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 400);
            this.Controls.Add(this.btnAnthAcc);
            this.Controls.Add(this.btnNewAcc);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnDeleteAcc);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(391, 447);
            this.MinimumSize = new System.Drawing.Size(391, 447);
            this.Name = "frmAccountMgmt";
            this.Text = "Manage your account";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAccountMgmt_FormClosing);
            this.Load += new System.EventHandler(this.frmAccountMgmt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnDeleteAcc;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAnthAcc;
        private System.Windows.Forms.Button btnNewAcc;
    }
}