namespace WindowsFormsApp3
{
    partial class Form1
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
            this.Dshax = new System.Windows.Forms.DataGridView();
            this.LR = new System.Windows.Forms.Label();
            this.BT1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dshax)).BeginInit();
            this.SuspendLayout();
            // 
            // Dshax
            // 
            this.Dshax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dshax.Location = new System.Drawing.Point(46, 49);
            this.Dshax.Name = "Dshax";
            this.Dshax.RowHeadersWidth = 62;
            this.Dshax.RowTemplate.Height = 28;
            this.Dshax.Size = new System.Drawing.Size(786, 586);
            this.Dshax.TabIndex = 0;
            this.Dshax.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LR
            // 
            this.LR.AutoSize = true;
            this.LR.Location = new System.Drawing.Point(862, 85);
            this.LR.Name = "LR";
            this.LR.Size = new System.Drawing.Size(79, 20);
            this.LR.TabIndex = 1;
            this.LR.Text = "резултат";
            // 
            // BT1
            // 
            this.BT1.Location = new System.Drawing.Point(854, 184);
            this.BT1.Name = "BT1";
            this.BT1.Size = new System.Drawing.Size(87, 59);
            this.BT1.TabIndex = 2;
            this.BT1.Text = "нова игра";
            this.BT1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 660);
            this.Controls.Add(this.BT1);
            this.Controls.Add(this.LR);
            this.Controls.Add(this.Dshax);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dshax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dshax;
        private System.Windows.Forms.Label LR;
        private System.Windows.Forms.Button BT1;
    }
}

