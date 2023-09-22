namespace Krsova
{
    partial class StatisticsForm
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
            this.maleLabel = new System.Windows.Forms.Label();
            this.femaleLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.patientListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // maleLabel
            // 
            this.maleLabel.AutoSize = true;
            this.maleLabel.Location = new System.Drawing.Point(13, 13);
            this.maleLabel.Name = "maleLabel";
            this.maleLabel.Size = new System.Drawing.Size(51, 20);
            this.maleLabel.TabIndex = 0;
            this.maleLabel.Text = "label1";
            // 
            // femaleLabel
            // 
            this.femaleLabel.AutoSize = true;
            this.femaleLabel.Location = new System.Drawing.Point(13, 45);
            this.femaleLabel.Name = "femaleLabel";
            this.femaleLabel.Size = new System.Drawing.Size(51, 20);
            this.femaleLabel.TabIndex = 1;
            this.femaleLabel.Text = "label2";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(13, 81);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(51, 20);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "label3";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(12, 110);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(51, 20);
            this.ageLabel.TabIndex = 3;
            this.ageLabel.Text = "label4";
            // 
            // patientListBox
            // 
            this.patientListBox.FormattingEnabled = true;
            this.patientListBox.ItemHeight = 20;
            this.patientListBox.Location = new System.Drawing.Point(17, 145);
            this.patientListBox.Name = "patientListBox";
            this.patientListBox.Size = new System.Drawing.Size(120, 84);
            this.patientListBox.TabIndex = 4;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.patientListBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.femaleLabel);
            this.Controls.Add(this.maleLabel);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox patientListBox;
        public System.Windows.Forms.Label maleLabel;
        public System.Windows.Forms.Label femaleLabel;
        public System.Windows.Forms.Label totalLabel;
        public System.Windows.Forms.Label ageLabel;
    }
}