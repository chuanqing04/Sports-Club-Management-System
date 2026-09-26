namespace Assignment
{
    partial class Adduser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbMember = new System.Windows.Forms.RadioButton();
            this.rbCoach = new System.Windows.Forms.RadioButton();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnregister = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.mtbsalary = new System.Windows.Forms.MaskedTextBox();
            this.mtbtraining = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbconfirm = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add user";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAdmin);
            this.groupBox1.Controls.Add(this.rbMember);
            this.groupBox1.Controls.Add(this.rbCoach);
            this.groupBox1.Controls.Add(this.rbManager);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select user type";
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(6, 41);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(89, 29);
            this.rbAdmin.TabIndex = 3;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            this.rbAdmin.CheckedChanged += new System.EventHandler(this.rbAdmin_CheckedChanged);
            // 
            // rbMember
            // 
            this.rbMember.AutoSize = true;
            this.rbMember.Location = new System.Drawing.Point(6, 148);
            this.rbMember.Name = "rbMember";
            this.rbMember.Size = new System.Drawing.Size(105, 29);
            this.rbMember.TabIndex = 2;
            this.rbMember.TabStop = true;
            this.rbMember.Text = "Member";
            this.rbMember.UseVisualStyleBackColor = true;
            this.rbMember.CheckedChanged += new System.EventHandler(this.rbMember_CheckedChanged);
            // 
            // rbCoach
            // 
            this.rbCoach.AutoSize = true;
            this.rbCoach.Location = new System.Drawing.Point(6, 112);
            this.rbCoach.Name = "rbCoach";
            this.rbCoach.Size = new System.Drawing.Size(91, 29);
            this.rbCoach.TabIndex = 1;
            this.rbCoach.TabStop = true;
            this.rbCoach.Text = "Coach";
            this.rbCoach.UseVisualStyleBackColor = true;
            this.rbCoach.CheckedChanged += new System.EventHandler(this.rbCoach_CheckedChanged);
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Location = new System.Drawing.Point(6, 76);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(111, 29);
            this.rbManager.TabIndex = 0;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "Manager";
            this.rbManager.UseVisualStyleBackColor = true;
            this.rbManager.CheckedChanged += new System.EventHandler(this.rbManager_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Training Level:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(293, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Salary:";
            this.label6.Visible = false;
            // 
            // btnregister
            // 
            this.btnregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.Location = new System.Drawing.Point(329, 366);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(105, 41);
            this.btnregister.TabIndex = 7;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(510, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(472, 135);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(257, 22);
            this.tbemail.TabIndex = 9;
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(472, 166);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(257, 22);
            this.tbpassword.TabIndex = 10;
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(472, 240);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(257, 22);
            this.tbusername.TabIndex = 11;
            // 
            // mtbsalary
            // 
            this.mtbsalary.Location = new System.Drawing.Point(472, 311);
            this.mtbsalary.Mask = "00000";
            this.mtbsalary.Name = "mtbsalary";
            this.mtbsalary.Size = new System.Drawing.Size(257, 22);
            this.mtbsalary.TabIndex = 13;
            this.mtbsalary.ValidatingType = typeof(int);
            this.mtbsalary.Visible = false;
            // 
            // mtbtraining
            // 
            this.mtbtraining.Location = new System.Drawing.Point(472, 272);
            this.mtbtraining.Name = "mtbtraining";
            this.mtbtraining.Size = new System.Drawing.Size(257, 22);
            this.mtbtraining.TabIndex = 14;
            this.mtbtraining.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(293, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Confirm Password: ";
            // 
            // tbconfirm
            // 
            this.tbconfirm.Location = new System.Drawing.Point(472, 204);
            this.tbconfirm.Name = "tbconfirm";
            this.tbconfirm.PasswordChar = '*';
            this.tbconfirm.Size = new System.Drawing.Size(257, 22);
            this.tbconfirm.TabIndex = 16;
            // 
            // Adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.tbconfirm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtbtraining);
            this.Controls.Add(this.mtbsalary);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Adduser";
            this.Text = "AddUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMember;
        private System.Windows.Forms.RadioButton rbCoach;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.MaskedTextBox mtbsalary;
        private System.Windows.Forms.MaskedTextBox mtbtraining;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbconfirm;
    }
}