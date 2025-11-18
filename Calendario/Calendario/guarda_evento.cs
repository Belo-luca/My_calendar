using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calendario
{
    public partial class guarda_evento : Form
    {
        public guarda_evento(string titolo, string descrizione, DateTime data, Color colore)
        {
            InitializeComponent();

            // Imposta i valori sulle etichette
            labelTitolo.Text = titolo;
            labelDescrizione.Text = descrizione;
            labelData.Text = data.ToString("dd/MM/yyyy HH:mm");
            panelColore.BackColor = colore;
        }

        private Label labelTitolo;
        private Label labelDescrizione;
        private Label labelData;
        private Panel panelColore;

        private void InitializeComponent()
        {
            this.labelTitolo = new Label();
            this.labelDescrizione = new Label();
            this.labelData = new Label();
            this.panelColore = new Panel();

            // 
            // labelTitolo
            // 
            this.labelTitolo.AutoSize = true;
            this.labelTitolo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.labelTitolo.Location = new Point(20, 20);
            this.labelTitolo.Size = new Size(100, 25);
            this.labelTitolo.Text = "Titolo";

            // 
            // labelDescrizione
            // 
            this.labelDescrizione.AutoSize = true;
            this.labelDescrizione.Location = new Point(20, 60);
            this.labelDescrizione.Size = new Size(300, 20);
            this.labelDescrizione.Text = "Descrizione";

            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new Point(20, 100);
            this.labelData.Size = new Size(200, 20);
            this.labelData.Text = "Data";

            // 
            // panelColore
            // 
            this.panelColore.Location = new Point(20, 140);
            this.panelColore.Size = new Size(50, 25);
            this.panelColore.BackColor = Color.LightGray;

            // 
            // guarda_evento
            // 
            this.ClientSize = new Size(400, 200);
            this.Controls.Add(this.labelTitolo);
            this.Controls.Add(this.labelDescrizione);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.panelColore);
            this.Text = "Dettagli Evento";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
    }
}
