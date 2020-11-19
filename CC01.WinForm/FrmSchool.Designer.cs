namespace CC01.WinForm
{
    partial class FrmSchool
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblAcronym = new System.Windows.Forms.Label();
            this.tbAcronym = new System.Windows.Forms.TextBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.tbSchool = new System.Windows.Forms.TextBox();
            this.lblSchoolname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(344, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 155);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(34, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(193, 51);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.Location = new System.Drawing.Point(323, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(195, 51);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(337, 26);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(89, 37);
            this.lblLogo.TabIndex = 5;
            this.lblLogo.Text = "Logo";
            // 
            // lblAcronym
            // 
            this.lblAcronym.AutoSize = true;
            this.lblAcronym.Location = new System.Drawing.Point(25, 21);
            this.lblAcronym.Name = "lblAcronym";
            this.lblAcronym.Size = new System.Drawing.Size(144, 37);
            this.lblAcronym.TabIndex = 1;
            this.lblAcronym.Text = "Acronym";
            // 
            // tbAcronym
            // 
            this.tbAcronym.Location = new System.Drawing.Point(32, 71);
            this.tbAcronym.Name = "tbAcronym";
            this.tbAcronym.Size = new System.Drawing.Size(257, 44);
            this.tbAcronym.TabIndex = 2;
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(32, 182);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(257, 44);
            this.tbLocation.TabIndex = 7;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(25, 132);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(139, 37);
            this.lblLocation.TabIndex = 6;
            this.lblLocation.Text = "Location";
            // 
            // tbSchool
            // 
            this.tbSchool.Location = new System.Drawing.Point(32, 295);
            this.tbSchool.Name = "tbSchool";
            this.tbSchool.Size = new System.Drawing.Size(486, 44);
            this.tbSchool.TabIndex = 9;
            // 
            // lblSchoolname
            // 
            this.lblSchoolname.AutoSize = true;
            this.lblSchoolname.Location = new System.Drawing.Point(25, 245);
            this.lblSchoolname.Name = "lblSchoolname";
            this.lblSchoolname.Size = new System.Drawing.Size(195, 37);
            this.lblSchoolname.TabIndex = 8;
            this.lblSchoolname.Text = "Schoolname";
            // 
            // FrmSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 444);
            this.Controls.Add(this.tbSchool);
            this.Controls.Add(this.lblSchoolname);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbAcronym);
            this.Controls.Add(this.lblAcronym);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmSchool";
            this.Text = "School";
            this.Load += new System.EventHandler(this.FrmSchool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblAcronym;
        private System.Windows.Forms.TextBox tbAcronym;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox tbSchool;
        private System.Windows.Forms.Label lblSchoolname;
    }
}