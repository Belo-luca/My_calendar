using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendario
{
    public partial class Change_commit : Form
    {
        public Change_commit()
        {
            InitializeComponent();
        }

        private void controlloEventiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void aggiungiEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_commit new_Commit = new New_commit();
            new_Commit.ShowDialog();
        }

        private void modificaEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
