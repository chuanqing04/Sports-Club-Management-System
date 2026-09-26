namespace Assignment
{
    partial class TrainingSchedule
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
            this.Traninglbl = new System.Windows.Forms.Label();
            this.AddTbtn = new System.Windows.Forms.Button();
            this.EditTbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Traninglbl
            // 
            this.Traninglbl.AutoSize = true;
            this.Traninglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Traninglbl.Location = new System.Drawing.Point(203, 123);
            this.Traninglbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Traninglbl.Name = "Traninglbl";
            this.Traninglbl.Size = new System.Drawing.Size(360, 51);
            this.Traninglbl.TabIndex = 0;
            this.Traninglbl.Text = "Traning Schedule";
            this.Traninglbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddTbtn
            // 
            this.AddTbtn.Location = new System.Drawing.Point(86, 268);
            this.AddTbtn.Margin = new System.Windows.Forms.Padding(6);
            this.AddTbtn.Name = "AddTbtn";
            this.AddTbtn.Size = new System.Drawing.Size(199, 76);
            this.AddTbtn.TabIndex = 1;
            this.AddTbtn.Text = "Add";
            this.AddTbtn.UseVisualStyleBackColor = true;
            this.AddTbtn.Click += new System.EventHandler(this.AddTbtn_Click);
            // 
            // EditTbtn
            // 
            this.EditTbtn.Location = new System.Drawing.Point(479, 268);
            this.EditTbtn.Margin = new System.Windows.Forms.Padding(6);
            this.EditTbtn.Name = "EditTbtn";
            this.EditTbtn.Size = new System.Drawing.Size(199, 76);
            this.EditTbtn.TabIndex = 2;
            this.EditTbtn.Text = "Edit / Delete";
            this.EditTbtn.UseVisualStyleBackColor = true;
            this.EditTbtn.Click += new System.EventHandler(this.EditTbtn_Click);
            // 
            // TrainingSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.EditTbtn);
            this.Controls.Add(this.AddTbtn);
            this.Controls.Add(this.Traninglbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TrainingSchedule";
            this.Text = "TraningSchedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Traninglbl;
        private System.Windows.Forms.Button AddTbtn;
        private System.Windows.Forms.Button EditTbtn;
    }
}