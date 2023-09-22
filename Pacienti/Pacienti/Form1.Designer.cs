namespace Pacienti
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.пациентиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавянеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списъкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пациентиToolStripMenuItem,
            this.изходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1151, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // пациентиToolStripMenuItem
            // 
            this.пациентиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавянеToolStripMenuItem,
            this.списъкToolStripMenuItem});
            this.пациентиToolStripMenuItem.Name = "пациентиToolStripMenuItem";
            this.пациентиToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.пациентиToolStripMenuItem.Text = "Пациенти";
            // 
            // добавянеToolStripMenuItem
            // 
            this.добавянеToolStripMenuItem.Name = "добавянеToolStripMenuItem";
            this.добавянеToolStripMenuItem.Size = new System.Drawing.Size(194, 34);
            this.добавянеToolStripMenuItem.Text = "Добавяне";
            this.добавянеToolStripMenuItem.Click += new System.EventHandler(this.добавянеToolStripMenuItem_Click);
            // 
            // списъкToolStripMenuItem
            // 
            this.списъкToolStripMenuItem.Name = "списъкToolStripMenuItem";
            this.списъкToolStripMenuItem.Size = new System.Drawing.Size(194, 34);
            this.списъкToolStripMenuItem.Text = "Списък";
            this.списъкToolStripMenuItem.Click += new System.EventHandler(this.списъкToolStripMenuItem_Click);
            // 
            // изходToolStripMenuItem
            // 
            this.изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            this.изходToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.изходToolStripMenuItem.Text = "Изход";
            this.изходToolStripMenuItem.Click += new System.EventHandler(this.изходToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1151, 694);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Клиника";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem пациентиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавянеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списъкToolStripMenuItem;
        protected System.Windows.Forms.MenuStrip menuStrip1;
    }
}

