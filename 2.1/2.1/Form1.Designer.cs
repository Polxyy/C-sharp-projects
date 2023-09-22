namespace _2._1
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
            this.DGrid = new System.Windows.Forms.DataGridView();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.BT1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DGrid
            // 
            this.DGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGrid.Location = new System.Drawing.Point(12, 12);
            this.DGrid.Name = "DGrid";
            this.DGrid.RowHeadersWidth = 62;
            this.DGrid.RowTemplate.Height = 28;
            this.DGrid.Size = new System.Drawing.Size(819, 484);
            this.DGrid.TabIndex = 0;
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(12, 519);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(115, 26);
            this.TB1.TabIndex = 1;
            // 
            // BT1
            // 
            this.BT1.Location = new System.Drawing.Point(749, 517);
            this.BT1.Name = "BT1";
            this.BT1.Size = new System.Drawing.Size(75, 31);
            this.BT1.TabIndex = 2;
            this.BT1.Text = "Sort";
            this.BT1.UseVisualStyleBackColor = true;
            this.BT1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 565);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BT1);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.DGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGrid;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.Button BT1;
        private System.Windows.Forms.Button button1;
    }
}

