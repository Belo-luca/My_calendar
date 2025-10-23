namespace Calendario
{
    partial class Change_commit
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
            this.homepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlloEventiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homepageToolStripMenuItem,
            this.controlloEventiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homepageToolStripMenuItem
            // 
            this.homepageToolStripMenuItem.Name = "homepageToolStripMenuItem";
            this.homepageToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.homepageToolStripMenuItem.Text = "Homepage";
            this.homepageToolStripMenuItem.Click += new System.EventHandler(this.homepageToolStripMenuItem_Click);
            // 
            // controlloEventiToolStripMenuItem
            // 
            this.controlloEventiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiEventoToolStripMenuItem,
            this.modificaEventoToolStripMenuItem,
            this.eliminaEventoToolStripMenuItem});
            this.controlloEventiToolStripMenuItem.Name = "controlloEventiToolStripMenuItem";
            this.controlloEventiToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.controlloEventiToolStripMenuItem.Text = "Gestisci eventi";
            this.controlloEventiToolStripMenuItem.Click += new System.EventHandler(this.controlloEventiToolStripMenuItem_Click);
            // 
            // aggiungiEventoToolStripMenuItem
            // 
            this.aggiungiEventoToolStripMenuItem.Name = "aggiungiEventoToolStripMenuItem";
            this.aggiungiEventoToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.aggiungiEventoToolStripMenuItem.Text = "aggiungi evento";
            this.aggiungiEventoToolStripMenuItem.Click += new System.EventHandler(this.aggiungiEventoToolStripMenuItem_Click);
            // 
            // modificaEventoToolStripMenuItem
            // 
            this.modificaEventoToolStripMenuItem.Name = "modificaEventoToolStripMenuItem";
            this.modificaEventoToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.modificaEventoToolStripMenuItem.Text = "modifica evento";
            this.modificaEventoToolStripMenuItem.Click += new System.EventHandler(this.modificaEventoToolStripMenuItem_Click);
            // 
            // eliminaEventoToolStripMenuItem
            // 
            this.eliminaEventoToolStripMenuItem.Name = "eliminaEventoToolStripMenuItem";
            this.eliminaEventoToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.eliminaEventoToolStripMenuItem.Text = "elimina evento";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(38, 59);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Change_commit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Change_commit";
            this.Text = "Change_commit";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlloEventiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggiungiEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaEventoToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}