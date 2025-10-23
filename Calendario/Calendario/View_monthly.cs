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
    public partial class View_monthly : Form
    {

        public View_monthly()
        {
            InitializeComponent();
            InitializeVScrollBar();
        }

        private void InitializeVScrollBar()
        {
            vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = 100; // Set maximum value as needed
            vScrollBar1.Value = 0;
            vScrollBar1.Scroll += new ScrollEventHandler(vScrollBar1_Scroll);
            this.Controls.Add(vScrollBar1);

            // Set the large change and small change values for better scrolling experience
            vScrollBar1.LargeChange = 10; // Amount to scroll when the scrollbar is moved
            vScrollBar1.SmallChange = 1; // Amount to scroll when the scrollbar is clicked
        }

        private Panel panel1;

        private void InitializePanel()
        {
            panel1 = new Panel();
            panel1.Dock = DockStyle.Fill; // Imposta il dock per riempire il form
            panel1.AutoScroll = true; // Abilita lo scorrimento automatico se necessario
            this.Controls.Add(panel1);
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // Esempio: Regola la posizione di un controllo in base al valore della scrollbar
            panel1.Top = -vScrollBar1.Value; // Sostituisci 'panel1' con il controllo effettivo che vuoi far scorrere
        }
    }
}
