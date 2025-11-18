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
                if(ora_inizio.Value > 24 && minuto_inizio.Value > 60 && ora_durata.Value > 24 && minuti_durata.Value > 60)
                {
                    MessageBox.Show("Inserire un orario valido");
                }
                else
                {
                    if (textBox1.Text.Trim() == "" && textBox2.Text.Trim() == "")
                    {
                        MessageBox.Show("Inserire una descrizione valida");
                    }
                    else
                    {
                        string titolo = textBox1.Text;
                        string descrizione = textBox2.Text;
                        DateTime data = dateTimePicker1.Value;
                        Color colore = label5.BackColor;
                        string contenuto = $"{titolo}§{descrizione}§{data.ToString("yyyy-MM-dd")}§{ora_inizio.Value}§{minuto_inizio.Value}§{ora_durata.Value}§{minuti_durata.Value}§{colore.ToArgb()}";
                        string percorso = Path.Combine(Application.StartupPath, "calendario.txt");
                        File.WriteAllText(percorso, contenuto);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ora_inizio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void minuto_inizio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ora_durata_ValueChanged(object sender, EventArgs e)
        {

        }

        private void minuti_durata_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
