namespace Fitness_Tracker.Forms
{
    partial class frmActivitiesPicking
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
            this.label10 = new System.Windows.Forms.Label();
            this.lblActivitiesListDisplay = new System.Windows.Forms.Label();
            this.cbxWalking = new System.Windows.Forms.CheckBox();
            this.cbxSwimming = new System.Windows.Forms.CheckBox();
            this.cbxRunning = new System.Windows.Forms.CheckBox();
            this.cbxCycling = new System.Windows.Forms.CheckBox();
            this.cbxJumbRope = new System.Windows.Forms.CheckBox();
            this.cbxJumpJack = new System.Windows.Forms.CheckBox();
            this.cbxBurpee = new System.Windows.Forms.CheckBox();
            this.cbxZumba = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(460, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Choose five of your regular physical activities";
            // 
            // lblActivitiesListDisplay
            // 
            this.lblActivitiesListDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblActivitiesListDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblActivitiesListDisplay.Location = new System.Drawing.Point(539, 51);
            this.lblActivitiesListDisplay.Name = "lblActivitiesListDisplay";
            this.lblActivitiesListDisplay.Padding = new System.Windows.Forms.Padding(10);
            this.lblActivitiesListDisplay.Size = new System.Drawing.Size(325, 240);
            this.lblActivitiesListDisplay.TabIndex = 26;
            // 
            // cbxWalking
            // 
            this.cbxWalking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxWalking.AutoSize = true;
            this.cbxWalking.Location = new System.Drawing.Point(44, 92);
            this.cbxWalking.Name = "cbxWalking";
            this.cbxWalking.Size = new System.Drawing.Size(110, 30);
            this.cbxWalking.TabIndex = 29;
            this.cbxWalking.Text = "Walking";
            this.cbxWalking.UseVisualStyleBackColor = true;
            this.cbxWalking.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // cbxSwimming
            // 
            this.cbxSwimming.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxSwimming.AutoSize = true;
            this.cbxSwimming.Location = new System.Drawing.Point(44, 128);
            this.cbxSwimming.Name = "cbxSwimming";
            this.cbxSwimming.Size = new System.Drawing.Size(135, 30);
            this.cbxSwimming.TabIndex = 30;
            this.cbxSwimming.Text = "Swimming";
            this.cbxSwimming.UseVisualStyleBackColor = true;
            this.cbxSwimming.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // cbxRunning
            // 
            this.cbxRunning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxRunning.AutoSize = true;
            this.cbxRunning.Location = new System.Drawing.Point(44, 164);
            this.cbxRunning.Name = "cbxRunning";
            this.cbxRunning.Size = new System.Drawing.Size(114, 30);
            this.cbxRunning.TabIndex = 31;
            this.cbxRunning.Text = "Running";
            this.cbxRunning.UseVisualStyleBackColor = true;
            this.cbxRunning.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // cbxCycling
            // 
            this.cbxCycling.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxCycling.AutoSize = true;
            this.cbxCycling.Location = new System.Drawing.Point(43, 200);
            this.cbxCycling.Name = "cbxCycling";
            this.cbxCycling.Size = new System.Drawing.Size(105, 30);
            this.cbxCycling.TabIndex = 32;
            this.cbxCycling.Text = "Cycling";
            this.cbxCycling.UseVisualStyleBackColor = true;
            this.cbxCycling.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // cbxJumbRope
            // 
            this.cbxJumbRope.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxJumbRope.AutoSize = true;
            this.cbxJumbRope.Location = new System.Drawing.Point(44, 236);
            this.cbxJumbRope.Name = "cbxJumbRope";
            this.cbxJumbRope.Size = new System.Drawing.Size(133, 30);
            this.cbxJumbRope.TabIndex = 33;
            this.cbxJumbRope.Text = "Jump rope";
            this.cbxJumbRope.UseVisualStyleBackColor = true;
            this.cbxJumbRope.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // cbxJumpJack
            // 
            this.cbxJumpJack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxJumpJack.AutoSize = true;
            this.cbxJumpJack.Location = new System.Drawing.Point(202, 164);
            this.cbxJumpJack.Name = "cbxJumpJack";
            this.cbxJumpJack.Size = new System.Drawing.Size(161, 30);
            this.cbxJumpJack.TabIndex = 36;
            this.cbxJumpJack.Text = "Jumping Jack";
            this.cbxJumpJack.UseVisualStyleBackColor = true;
            this.cbxJumpJack.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // cbxBurpee
            // 
            this.cbxBurpee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxBurpee.AutoSize = true;
            this.cbxBurpee.Location = new System.Drawing.Point(202, 128);
            this.cbxBurpee.Name = "cbxBurpee";
            this.cbxBurpee.Size = new System.Drawing.Size(100, 30);
            this.cbxBurpee.TabIndex = 35;
            this.cbxBurpee.Text = "Burpee";
            this.cbxBurpee.UseVisualStyleBackColor = true;
            this.cbxBurpee.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // cbxZumba
            // 
            this.cbxZumba.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxZumba.AutoSize = true;
            this.cbxZumba.Location = new System.Drawing.Point(202, 92);
            this.cbxZumba.Name = "cbxZumba";
            this.cbxZumba.Size = new System.Drawing.Size(99, 30);
            this.cbxZumba.TabIndex = 34;
            this.cbxZumba.Text = "Zumba";
            this.cbxZumba.UseVisualStyleBackColor = true;
            this.cbxZumba.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(722, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 41);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(607, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 41);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmActivitiesPicking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 363);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbxJumpJack);
            this.Controls.Add(this.cbxBurpee);
            this.Controls.Add(this.cbxZumba);
            this.Controls.Add(this.cbxJumbRope);
            this.Controls.Add(this.cbxCycling);
            this.Controls.Add(this.cbxRunning);
            this.Controls.Add(this.cbxSwimming);
            this.Controls.Add(this.cbxWalking);
            this.Controls.Add(this.lblActivitiesListDisplay);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(920, 410);
            this.Name = "frmActivitiesPicking";
            this.Text = "Activities";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmActivityTracking_FormClosing);
            this.Load += new System.EventHandler(this.frmActivitiesPicking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblActivitiesListDisplay;
        private System.Windows.Forms.CheckBox cbxWalking;
        private System.Windows.Forms.CheckBox cbxSwimming;
        private System.Windows.Forms.CheckBox cbxRunning;
        private System.Windows.Forms.CheckBox cbxCycling;
        private System.Windows.Forms.CheckBox cbxJumbRope;
        private System.Windows.Forms.CheckBox cbxJumpJack;
        private System.Windows.Forms.CheckBox cbxBurpee;
        private System.Windows.Forms.CheckBox cbxZumba;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}