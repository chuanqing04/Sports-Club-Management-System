namespace Assignment
{
    partial class CoachMenu
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
            this.TSbtn = new System.Windows.Forms.Button();
            this.Feebtn = new System.Windows.Forms.Button();
            this.Performbtn = new System.Windows.Forms.Button();
            this.Recbtn = new System.Windows.Forms.Button();
            this.Profbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coach Menu";
            // 
            // TSbtn
            // 
            this.TSbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSbtn.Location = new System.Drawing.Point(211, 155);
            this.TSbtn.Name = "TSbtn";
            this.TSbtn.Size = new System.Drawing.Size(376, 50);
            this.TSbtn.TabIndex = 1;
            this.TSbtn.Text = "Traning schedule";
            this.TSbtn.UseVisualStyleBackColor = true;
            this.TSbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Feebtn
            // 
            this.Feebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feebtn.Location = new System.Drawing.Point(211, 211);
            this.Feebtn.Name = "Feebtn";
            this.Feebtn.Size = new System.Drawing.Size(376, 50);
            this.Feebtn.TabIndex = 2;
            this.Feebtn.Text = "Member fees";
            this.Feebtn.UseVisualStyleBackColor = true;
            this.Feebtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Performbtn
            // 
            this.Performbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Performbtn.Location = new System.Drawing.Point(211, 267);
            this.Performbtn.Name = "Performbtn";
            this.Performbtn.Size = new System.Drawing.Size(376, 50);
            this.Performbtn.TabIndex = 3;
            this.Performbtn.Text = "Record performance";
            this.Performbtn.UseVisualStyleBackColor = true;
            this.Performbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Recbtn
            // 
            this.Recbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recbtn.Location = new System.Drawing.Point(211, 323);
            this.Recbtn.Name = "Recbtn";
            this.Recbtn.Size = new System.Drawing.Size(376, 50);
            this.Recbtn.TabIndex = 4;
            this.Recbtn.Text = "Recommendation for competition";
            this.Recbtn.UseVisualStyleBackColor = true;
            this.Recbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Profbtn
            // 
            this.Profbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profbtn.Location = new System.Drawing.Point(211, 379);
            this.Profbtn.Name = "Profbtn";
            this.Profbtn.Size = new System.Drawing.Size(376, 50);
            this.Profbtn.TabIndex = 5;
            this.Profbtn.Text = "Update profile";
            this.Profbtn.UseVisualStyleBackColor = true;
            this.Profbtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome";
            // 
            // labelemail
            // 
            this.labelemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.Location = new System.Drawing.Point(208, 112);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(379, 23);
            this.labelemail.TabIndex = 7;
            this.labelemail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CoachMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Profbtn);
            this.Controls.Add(this.Recbtn);
            this.Controls.Add(this.Performbtn);
            this.Controls.Add(this.Feebtn);
            this.Controls.Add(this.TSbtn);
            this.Controls.Add(this.label1);
            this.Name = "CoachMenu";
            this.Text = "CoachMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TSbtn;
        private System.Windows.Forms.Button Feebtn;
        private System.Windows.Forms.Button Performbtn;
        private System.Windows.Forms.Button Recbtn;
        private System.Windows.Forms.Button Profbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelemail;
    }
}

