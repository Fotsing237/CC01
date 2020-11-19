namespace CC01.WinForm
{
    partial class FrmStudent
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
            this.tbMat = new System.Windows.Forms.TextBox();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbBirth = new System.Windows.Forms.TextBox();
            this.lblBirth = new System.Windows.Forms.Label();
            this.tbPlace = new System.Windows.Forms.TextBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.tbSchool = new System.Windows.Forms.TextBox();
            this.lblSchool2 = new System.Windows.Forms.Label();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMat
            // 
            this.tbMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMat.Location = new System.Drawing.Point(37, 184);
            this.tbMat.Name = "tbMat";
            this.tbMat.Size = new System.Drawing.Size(257, 44);
            this.tbMat.TabIndex = 15;
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricule.Location = new System.Drawing.Point(30, 134);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(146, 37);
            this.lblMatricule.TabIndex = 14;
            this.lblMatricule.Text = "Matricule";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(355, 463);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(230, 51);
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(37, 463);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(230, 51);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(37, 73);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(257, 44);
            this.tbName.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(30, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 37);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // tbBirth
            // 
            this.tbBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBirth.Location = new System.Drawing.Point(328, 73);
            this.tbBirth.Name = "tbBirth";
            this.tbBirth.Size = new System.Drawing.Size(257, 44);
            this.tbBirth.TabIndex = 19;
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirth.Location = new System.Drawing.Point(321, 23);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(145, 37);
            this.lblBirth.TabIndex = 18;
            this.lblBirth.Text = "Birthdate";
            // 
            // tbPlace
            // 
            this.tbPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlace.Location = new System.Drawing.Point(328, 184);
            this.tbPlace.Name = "tbPlace";
            this.tbPlace.Size = new System.Drawing.Size(257, 44);
            this.tbPlace.TabIndex = 23;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(321, 134);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(189, 37);
            this.lblPlace.TabIndex = 22;
            this.lblPlace.Text = "PlaceofBirth";
            // 
            // tbSchool
            // 
            this.tbSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSchool.Location = new System.Drawing.Point(332, 290);
            this.tbSchool.Name = "tbSchool";
            this.tbSchool.Size = new System.Drawing.Size(257, 44);
            this.tbSchool.TabIndex = 27;
            // 
            // lblSchool2
            // 
            this.lblSchool2.AutoSize = true;
            this.lblSchool2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool2.Location = new System.Drawing.Point(325, 240);
            this.lblSchool2.Name = "lblSchool2";
            this.lblSchool2.Size = new System.Drawing.Size(115, 37);
            this.lblSchool2.TabIndex = 26;
            this.lblSchool2.Text = "School";
            // 
            // tbContact
            // 
            this.tbContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.Location = new System.Drawing.Point(37, 290);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(281, 44);
            this.tbContact.TabIndex = 25;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(34, 240);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(128, 37);
            this.lblContact.TabIndex = 24;
            this.lblContact.Text = "Contact";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(37, 397);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(548, 44);
            this.textBox1.TabIndex = 29;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(36, 347);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(75, 37);
            this.lblMail.TabIndex = 28;
            this.lblMail.Text = "Mail";
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 535);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.tbSchool);
            this.Controls.Add(this.lblSchool2);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.tbPlace);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.tbBirth);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.tbMat);
            this.Controls.Add(this.lblMatricule);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Name = "FrmStudent";
            this.Text = "FrmStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbMat;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbBirth;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.TextBox tbPlace;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.TextBox tbSchool;
        private System.Windows.Forms.Label lblSchool2;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMail;
    }
}