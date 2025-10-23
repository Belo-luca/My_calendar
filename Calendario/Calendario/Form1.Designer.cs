namespace Calendario
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.show_date = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.upload_commit = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.show_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Homepagemenu = new System.Windows.Forms.ToolStripMenuItem();
            this.controleventmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.neweventmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.changeeventmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteeventmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaElencoProgettiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 60);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // show_date
            // 
            this.show_date.Location = new System.Drawing.Point(3, 3);
            this.show_date.Name = "show_date";
            this.show_date.Size = new System.Drawing.Size(128, 54);
            this.show_date.TabIndex = 2;
            this.show_date.Text = "Visualizza data";
            this.show_date.UseVisualStyleBackColor = true;
            this.show_date.Click += new System.EventHandler(this.show_date_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.show_date, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.upload_commit, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 277);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(272, 70);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // upload_commit
            // 
            this.upload_commit.Location = new System.Drawing.Point(139, 3);
            this.upload_commit.Name = "upload_commit";
            this.upload_commit.Size = new System.Drawing.Size(128, 56);
            this.upload_commit.TabIndex = 5;
            this.upload_commit.Text = "Carica impegni";
            this.upload_commit.UseVisualStyleBackColor = true;
            this.upload_commit.Click += new System.EventHandler(this.upload_commit_Click);
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(743, 397);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(34, 30);
            this.help.TabIndex = 5;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // show_label
            // 
            this.show_label.AutoSize = true;
            this.show_label.Location = new System.Drawing.Point(536, 34);
            this.show_label.Name = "show_label";
            this.show_label.Size = new System.Drawing.Size(58, 16);
            this.show_label.TabIndex = 4;
            this.show_label.Text = "nessuna";
            this.show_label.Click += new System.EventHandler(this.show_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data selezionata è:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Homepagemenu,
            this.controleventmenu,
            this.visualizzaElencoProgettiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Homepagemenu
            // 
            this.Homepagemenu.Checked = true;
            this.Homepagemenu.CheckOnClick = true;
            this.Homepagemenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Homepagemenu.Name = "Homepagemenu";
            this.Homepagemenu.Size = new System.Drawing.Size(98, 24);
            this.Homepagemenu.Text = "Homepage";
            this.Homepagemenu.Click += new System.EventHandler(this.Homepagemenu_Click);
            // 
            // controleventmenu
            // 
            this.controleventmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neweventmenu,
            this.changeeventmenu,
            this.deleteeventmenu});
            this.controleventmenu.Name = "controleventmenu";
            this.controleventmenu.Size = new System.Drawing.Size(117, 24);
            this.controleventmenu.Text = "Gestisci eventi";
            this.controleventmenu.Click += new System.EventHandler(this.aggiungiEventoToolStripMenuItem_Click);
            // 
            // neweventmenu
            // 
            this.neweventmenu.Name = "neweventmenu";
            this.neweventmenu.Size = new System.Drawing.Size(200, 26);
            this.neweventmenu.Text = "aggiungi evento";
            this.neweventmenu.Click += new System.EventHandler(this.neweventmenu_Click);
            // 
            // changeeventmenu
            // 
            this.changeeventmenu.Name = "changeeventmenu";
            this.changeeventmenu.Size = new System.Drawing.Size(200, 26);
            this.changeeventmenu.Text = "modifica evento";
            this.changeeventmenu.Click += new System.EventHandler(this.modificaImpegnoToolStripMenuItem_Click);
            // 
            // deleteeventmenu
            // 
            this.deleteeventmenu.Name = "deleteeventmenu";
            this.deleteeventmenu.Size = new System.Drawing.Size(200, 26);
            this.deleteeventmenu.Text = "elimina evento";
            // 
            // visualizzaElencoProgettiToolStripMenuItem
            // 
            this.visualizzaElencoProgettiToolStripMenuItem.Name = "visualizzaElencoProgettiToolStripMenuItem";
            this.visualizzaElencoProgettiToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.visualizzaElencoProgettiToolStripMenuItem.Text = "Visualizza elenco progetti";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 111);
            this.label2.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(428, 86);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(329, 282);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.show_label);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.help);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button show_date;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Label show_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button upload_commit;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Homepagemenu;
        private System.Windows.Forms.ToolStripMenuItem controleventmenu;
        private System.Windows.Forms.ToolStripMenuItem neweventmenu;
        private System.Windows.Forms.ToolStripMenuItem changeeventmenu;
        private System.Windows.Forms.ToolStripMenuItem deleteeventmenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem visualizzaElencoProgettiToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

