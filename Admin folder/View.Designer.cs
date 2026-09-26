namespace Assignment
{
    partial class View
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
            this.lbid = new System.Windows.Forms.ListBox();
            this.rtbsuggestion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbid
            // 
            this.lbid.FormattingEnabled = true;
            this.lbid.ItemHeight = 16;
            this.lbid.Location = new System.Drawing.Point(43, 41);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(252, 356);
            this.lbid.TabIndex = 0;
            this.lbid.SelectedIndexChanged += new System.EventHandler(this.lbid_SelectedIndexChanged);
            // 
            // rtbsuggestion
            // 
            this.rtbsuggestion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtbsuggestion.Location = new System.Drawing.Point(335, 41);
            this.rtbsuggestion.Name = "rtbsuggestion";
            this.rtbsuggestion.ReadOnly = true;
            this.rtbsuggestion.Size = new System.Drawing.Size(433, 356);
            this.rtbsuggestion.TabIndex = 1;
            this.rtbsuggestion.Text = "";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbsuggestion);
            this.Controls.Add(this.lbid);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "View";
            this.Text = "View";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbid;
        private System.Windows.Forms.RichTextBox rtbsuggestion;
    }
}