using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calendario
{
    public partial class View_monthly : Form
    {
        public struct impegno
        {
            public string titolo;
            public string descrizione;
            public DateTime inizio;   // data e ora di inizio
            public TimeSpan durata;   // durata completa (ore + minuti)
            public Color colore;
        }

        private impegno[] impegni;

        public View_monthly()
        {
            InitializeComponent();

            // Carica gli impegni dal file
            string percorso = Path.Combine(Application.StartupPath, "calendario.txt");
            if (File.Exists(percorso))
            {
                string[] righe = File.ReadAllLines(percorso);
                impegni = new impegno[righe.Length];
                for (int i = 0; i < righe.Length; i++)
                {
                    string[] parti = righe[i].Split('§');

                    // Titolo e descrizione
                    impegni[i].titolo = parti[0];
                    impegni[i].descrizione = parti[1];

                    // Data (solo giorno)
                    DateTime giorno = DateTime.Parse(parti[2]);

                    // Ora e minuti di inizio
                    int oraInizio = int.Parse(parti[3]);
                    int minutoInizio = int.Parse(parti[4]);

                    // Durata ore e minuti
                    int durataOre = int.Parse(parti[5]);
                    int durataMinuti = int.Parse(parti[6]);

                    // Colore
                    impegni[i].colore = Color.FromArgb(int.Parse(parti[7]));

                    // Costruisci DateTime di inizio
                    impegni[i].inizio = new DateTime(
                        giorno.Year, giorno.Month, giorno.Day,
                        oraInizio, minutoInizio, 0);

                    // Costruisci TimeSpan durata
                    impegni[i].durata = new TimeSpan(durataOre, durataMinuti, 0);
                }
            }
            else
            {
                impegni = new impegno[0];
            }
        }

        // Funzione per calcolare la riga corretta (2 celle sotto l’etichetta dell’ora)
        private int GetRowForHour(int ora)
        {
            int row = (ora * 2) + 2;
            if (row >= tableLayoutPanel1.RowCount)
                row = tableLayoutPanel1.RowCount - 1;
            return row;
        }

        // Quando cambia la data nel calendario
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime giornoSelezionato = e.Start.Date;
            MostraImpegniPerGiorno(giornoSelezionato);
        }

        // Mostra gli impegni del giorno selezionato
        private void MostraImpegniPerGiorno(DateTime giorno)
        {
            // Pulisci la colonna di destra
            for (int r = 0; r < tableLayoutPanel1.RowCount; r++)
            {
                var toRemove = tableLayoutPanel1.Controls
                    .Cast<Control>()
                    .Where(c => tableLayoutPanel1.GetPositionFromControl(c).Column == 1
                             && tableLayoutPanel1.GetPositionFromControl(c).Row == r)
                    .ToList();
                foreach (var c in toRemove) tableLayoutPanel1.Controls.Remove(c);
            }

            // Filtra gli impegni del giorno
            var impegniDelGiorno = impegni
                .Where(i => i.inizio.Date == giorno)
                .OrderBy(i => i.inizio)
                .ToList();

            foreach (var imp in impegniDelGiorno)
            {
                DateTime fine = imp.inizio + imp.durata;

                // Inserisci il bottone in tutte le ore coperte
                for (DateTime ora = imp.inizio; ora < fine; ora = ora.AddHours(1))
                {
                    int rowIndex = GetRowForHour(ora.Hour);

                    // Usa un FlowLayoutPanel per gestire più impegni nella stessa ora
                    Control existing = tableLayoutPanel1.GetControlFromPosition(1, rowIndex);
                    FlowLayoutPanel flp;
                    if (existing == null)
                    {
                        flp = new FlowLayoutPanel
                        {
                            Dock = DockStyle.Fill,
                            AutoSize = true,
                            FlowDirection = FlowDirection.LeftToRight,
                            WrapContents = true,
                            Margin = new Padding(0),
                            Padding = new Padding(3)
                        };
                        tableLayoutPanel1.Controls.Add(flp, 1, rowIndex);
                    }
                    else
                    {
                        flp = existing as FlowLayoutPanel;
                        if (flp == null)
                        {
                            tableLayoutPanel1.Controls.Remove(existing);
                            flp = new FlowLayoutPanel
                            {
                                Dock = DockStyle.Fill,
                                AutoSize = true,
                                FlowDirection = FlowDirection.LeftToRight,
                                WrapContents = true,
                                Margin = new Padding(0),
                                Padding = new Padding(3)
                            };
                            tableLayoutPanel1.Controls.Add(flp, 1, rowIndex);
                        }
                    }

                    var btn = new Button
                    {
                        Text = $"{imp.titolo} ({imp.inizio:HH:mm})",
                        BackColor = imp.colore,
                        AutoSize = true,
                        Margin = new Padding(3, 3, 6, 3)
                    };

                    btn.Click += (s, e) =>
                    {
                        var f = new guarda_evento(imp.titolo, imp.descrizione, imp.inizio, imp.colore);
                        f.ShowDialog();
                    };

                    flp.Controls.Add(btn);
                }
            }
        }

        // Eventi vuoti del designer
        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime data = monthCalendar1.SelectionStart;
            MostraImpegniPerGiorno(data);
        }
    }
}
