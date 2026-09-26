namespace Assignment
{
    partial class Edituser
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
            this.tbconfirm = new System.Windows.Forms.TextBox();
            this.lblconfirm = new System.Windows.Forms.Label();
            this.mtbtraining = new System.Windows.Forms.MaskedTextBox();
            this.mtbsalary = new System.Windows.Forms.MaskedTextBox();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncommit = new System.Windows.Forms.Button();
            this.lblsalary = new System.Windows.Forms.Label();
            this.lbltraining = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit User";
            // 
            // tbconfirm
            // 
            this.tbconfirm.Location = new System.Drawing.Point(200, 93);
            this.tbconfirm.Name = "tbconfirm";
            this.tbconfirm.PasswordChar = '*';
            this.tbconfirm.Size = new System.Drawing.Size(257, 30);
            this.tbconfirm.TabIndex = 30;
            // 
            // lblconfirm
            // 
            this.lblconfirm.AutoSize = true;
            this.lblconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirm.Location = new System.Drawing.Point(21, 96);
            this.lblconfirm.Name = "lblconfirm";
            this.lblconfirm.Size = new System.Drawing.Size(182, 25);
            this.lblconfirm.TabIndex = 29;
            this.lblconfirm.Text = "Confirm Password: ";
            // 
            // mtbtraining
            // 
            this.mtbtraining.Location = new System.Drawing.Point(200, 161);
            this.mtbtraining.Name = "mtbtraining";
            this.mtbtraining.Size = new System.Drawing.Size(257, 30);
            this.mtbtraining.TabIndex = 28;
            this.mtbtraining.Visible = false;
            // 
            // mtbsalary
            // 
            this.mtbsalary.Location = new System.Drawing.Point(200, 200);
            this.mtbsalary.Mask = "00000";
            this.mtbsalary.Name = "mtbsalary";
            this.mtbsalary.Size = new System.Drawing.Size(257, 30);
            this.mtbsalary.TabIndex = 27;
            this.mtbsalary.ValidatingType = typeof(int);
            this.mtbsalary.Visible = false;
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(200, 129);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(257, 30);
            this.tbusername.TabIndex = 26;
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(200, 57);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(257, 30);
            this.tbpassword.TabIndex = 25;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(275, 254);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(101, 42);
            this.btnclear.TabIndex = 23;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncommit
            // 
            this.btncommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncommit.Location = new System.Drawing.Point(57, 255);
            this.btncommit.Name = "btncommit";
            this.btncommit.Size = new System.Drawing.Size(184, 41);
            this.btncommit.TabIndex = 22;
            this.btncommit.Text = "Commit Changes";
            this.btncommit.UseVisualStyleBackColor = true;
            this.btncommit.Click += new System.EventHandler(this.btncommit_Click);
            // 
            // lblsalary
            // 
            this.lblsalary.AutoSize = true;
            this.lblsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalary.Location = new System.Drawing.Point(24, 203);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(74, 25);
            this.lblsalary.TabIndex = 21;
            this.lblsalary.Text = "Salary:";
            this.lblsalary.Visible = false;
            // 
            // lbltraining
            // 
            this.lbltraining.AutoSize = true;
            this.lbltraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltraining.Location = new System.Drawing.Point(21, 164);
            this.lbltraining.Name = "lbltraining";
            this.lbltraining.Size = new System.Drawing.Size(141, 25);
            this.lbltraining.TabIndex = 20;
            this.lbltraining.Text = "Training Level:";
            this.lbltraining.Visible = false;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(21, 132);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(113, 25);
            this.lblusername.TabIndex = 19;
            this.lblusername.Text = "Username: ";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(21, 60);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(109, 25);
            this.lblpassword.TabIndex = 18;
            this.lblpassword.Text = "Password: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblpassword);
            this.groupBox1.Controls.Add(this.lblusername);
            this.groupBox1.Controls.Add(this.tbconfirm);
            this.groupBox1.Controls.Add(this.lbltraining);
            this.groupBox1.Controls.Add(this.lblconfirm);
            this.groupBox1.Controls.Add(this.lblsalary);
            this.groupBox1.Controls.Add(this.mtbtraining);
            this.groupBox1.Controls.Add(this.btncommit);
            this.groupBox1.Controls.Add(this.mtbsalary);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.tbusername);
            this.groupBox1.Controls.Add(this.tbpassword);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 334);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Details";
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(454, 468);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(153, 65);
            this.btndelete.TabIndex = 34;
            this.btndelete.Text = "Delete User";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Edituser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 545);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Edituser";
            this.Text = "Edituser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbconfirm;
        private System.Windows.Forms.Label lblconfirm;
        private System.Windows.Forms.MaskedTextBox mtbtraining;
        private System.Windows.Forms.MaskedTextBox mtbsalary;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncommit;
        private System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.Label lbltraining;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndelete;
    }
}