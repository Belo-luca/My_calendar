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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/*
 *SISTEMARE L'UPLOAD DEL PROGETTO 
 */


namespace Calendario
{
    public struct impegno
    {
        public string titolo;
        public string descrizione;
        public DateTime data;
        public Color colore;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            impegni = new impegno[1];
            impegni[0].titolo = "Nessun impegno";
        }
        private impegno[] impegni;
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
  
        }

        private void show_date_Click(object sender, EventArgs e)
        {
            bool controllo = false;
            show_label.Text = monthCalendar1.SelectionStart.ToShortDateString();
            if (impegni[0].titolo == "Nessun impegno")
            {
                MessageBox.Show("Non ci sono impegni caricati, carica 'Calendario.txt' di testo con gli impegni", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                for (int i = 0; i < impegni.Length; i++)
                {
                    if (impegni[i].data == monthCalendar1.SelectionStart)
                    {
                        Color colore = impegni[i].colore;
                        label2.ForeColor = colore;
                        label2.Text = "Titolo: " + impegni[i].titolo + "\n" + "Descrizione: " + impegni[i].descrizione;
                        controllo = true;
                    }
                }
                if (controllo == false)
                {
                    label2.Text = "Non ci sono impegni per questa data";
                }
            }
        }

        private void show_today_Click(object sender, EventArgs e)
        {

        }

        private void new_commit_Click(object sender, EventArgs e)
        {
            New_commit form_aggiungi_evento = new New_commit();
            form_aggiungi_evento.Show();
        }

        private void del_commit_Click(object sender, EventArgs e)
        {

        }

        private void edit_commit_Click(object sender, EventArgs e)
        {

        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In questa pagina puoi vedere i tuoi impegni selezionando la data dal calendario, premere visualizza e poi a destra vedrai i tuoi impegni. Mentre per modificare, eliminare o creare nuovi eventi: guarda il menù", "Yuhao è cinese", MessageBoxButtons.OK);
        }

        private void show_label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void upload_commit_Click(object sender, EventArgs e)
        {
            OpenFileDialog apri = new OpenFileDialog();
            apri.Filter = "File di testo (*.txt)|*.txt|Tutti i file (*.*)|*.*";
            apri.Title = "Seleziona il file Calendario.txt";
            apri.FileName = "Calendario.txt";

            if (apri.ShowDialog() == DialogResult.OK)
            {
                string path = apri.FileName;
                string[] righe = File.ReadAllLines(path);
                impegni = null;
                impegni = new impegno[righe.Length] ;

                int indice = 0;
                foreach (string riga in righe)
                {
                    string[] parti = riga.Split('>');
                    if (parti.Length == 4)
                    {
                        impegno nuovo_impegno = new impegno
                        {
                            titolo = parti[0],
                            descrizione = parti[1],
                            data = DateTime.Parse(parti[2]),
                            colore = Color.FromArgb(int.Parse(parti[3]))
                        };

                        impegni[indice] = nuovo_impegno;
                        indice++;
                    }
                }

                MessageBox.Show($"Sono presenti: {indice} impegni.");
            }
        }

        private void aggiungiEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        #region menu
        private void neweventmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_commit new_Commit = new New_commit();
            new_Commit.Show();
        }

        private void modificaImpegnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Change_commit edit_Commit = new Change_commit();
            edit_Commit.Show();
        }

        #endregion

        private void Homepagemenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_monthly view_Monthly = new View_monthly();
            view_Monthly.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
