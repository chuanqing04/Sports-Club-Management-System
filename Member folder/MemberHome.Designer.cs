namespace hehehe
{
    partial class MemberHome
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
            this.name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.enroll_unenroll = new System.Windows.Forms.Button();
            this.schedule = new System.Windows.Forms.Button();
            this.performance = new System.Windows.Forms.Button();
            this.competition = new System.Windows.Forms.Button();
            this.suggestion = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trainningclass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(12, 10);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(109, 39);
            this.name.TabIndex = 0;
            this.name.Text = "label1";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(14, 61);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(79, 29);
            this.id.TabIndex = 1;
            this.id.Text = "label1";
            // 
            // enroll_unenroll
            // 
            this.enroll_unenroll.Location = new System.Drawing.Point(110, 147);
            this.enroll_unenroll.Name = "enroll_unenroll";
            this.enroll_unenroll.Size = new System.Drawing.Size(166, 62);
            this.enroll_unenroll.TabIndex = 2;
            this.enroll_unenroll.Text = "enroll  unenroll";
            this.enroll_unenroll.UseVisualStyleBackColor = true;
            this.enroll_unenroll.Click += new System.EventHandler(this.enroll_unenroll_Click);
            // 
            // schedule
            // 
            this.schedule.Location = new System.Drawing.Point(110, 248);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(166, 62);
            this.schedule.TabIndex = 3;
            this.schedule.Text = "training scedule";
            this.schedule.UseVisualStyleBackColor = true;
            this.schedule.Click += new System.EventHandler(this.schedule_Click);
            // 
            // performance
            // 
            this.performance.Location = new System.Drawing.Point(110, 350);
            this.performance.Name = "performance";
            this.performance.Size = new System.Drawing.Size(166, 62);
            this.performance.TabIndex = 4;
            this.performance.Text = "performance record";
            this.performance.UseVisualStyleBackColor = true;
            // 
            // competition
            // 
            this.competition.Location = new System.Drawing.Point(417, 147);
            this.competition.Name = "competition";
            this.competition.Size = new System.Drawing.Size(166, 62);
            this.competition.TabIndex = 5;
            this.competition.Text = "competition";
            this.competition.UseVisualStyleBackColor = true;
            // 
            // suggestion
            // 
            this.suggestion.Location = new System.Drawing.Point(417, 248);
            this.suggestion.Name = "suggestion";
            this.suggestion.Size = new System.Drawing.Size(166, 62);
            this.suggestion.TabIndex = 6;
            this.suggestion.Text = "send suggestion";
            this.suggestion.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(417, 350);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(166, 62);
            this.update.TabIndex = 7;
            this.update.Text = "update profile";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(589, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "current training class";
            // 
            // trainningclass
            // 
            this.trainningclass.AutoSize = true;
            this.trainningclass.Location = new System.Drawing.Point(591, 61);
            this.trainningclass.Name = "trainningclass";
            this.trainningclass.Size = new System.Drawing.Size(75, 17);
            this.trainningclass.TabIndex = 9;
            this.trainningclass.Text = "unenrolled";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.trainningclass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.suggestion);
            this.Controls.Add(this.competition);
            this.Controls.Add(this.performance);
            this.Controls.Add(this.schedule);
            this.Controls.Add(this.enroll_unenroll);
            this.Controls.Add(this.id);
            this.Controls.Add(this.name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form1";
            this.Text = "profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button enroll_unenroll;
        private System.Windows.Forms.Button schedule;
        private System.Windows.Forms.Button performance;
        private System.Windows.Forms.Button competition;
        private System.Windows.Forms.Button suggestion;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label trainningclass;
    }
}

