using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calendario
{
    public partial class New_commit : Form
    {
        public New_commit()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                label5.BackColor = colorDialog1.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ciao2 = textBox1.Text.Trim();
            if (ciao2 == "")
            {
                MessageBox.Show("Inserire un titolo valido");
            }
            else
            {
                if (textBox2.Text.Trim() == "")
                {
                    MessageBox.Show("Inserire una descrizione valida");
                }
                else
                {
                    SaveFileDialog salva = new SaveFileDialog();
                    salva.Filter = "File di testo (*.txt)|*.txt|Tutti i file (*.*)|*.*";
                    salva.Title = "Salvare nuovo impegno";
                    salva.FileName = "Calendario.txt";
                    string titolo = textBox1.Text;
                    string descrizione = textBox2.Text;
                    string data = dateTimePicker1.Value.Day.ToString();
                    string mese = dateTimePicker1.Value.Month.ToString();
                    string anno = dateTimePicker1.Value.Year.ToString();
                    data = data + "/" + mese + "/" + anno;
                    string colore = label5.BackColor.ToArgb().ToString();
                    if (salva.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(salva.FileName))
                        {
                            sw.WriteLine(titolo + ">" + descrizione + ">" + data + ">" + colore);
                        }
                        this.Close();
                        Form1 form1 = new Form1();
                        form1.ShowDialog();
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gestisciEventiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void nuovoEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void modificaImpegnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Change_commit change_Commit = new Change_commit();
            change_Commit.ShowDialog();
        }
    }
}
