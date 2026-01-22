
using Microsoft.Reporting.WinForms;
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

namespace EwidencjaPojazdow
{
    public partial class Form1 : Form
    {
        List<Pojazd> pojazdy = new List<Pojazd>();

        public Form1()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Pojazd p = new Pojazd()
            {
                NrRejestracyjny = txtRejestracja.Text,
                Marka = txtMarka.Text,
                Model = txtModel.Text,
                RokProdukcji = (int)numRok.Value,
                DataPrzegladu = dtpPrzeglad.Value,
                Wlasciciel = txtWlasciciel.Text
            };

            pojazdy.Add(p);

            dgvPojazdy.DataSource = null;
            dgvPojazdy.DataSource = pojazdy;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("PojazdyDS", pojazdy));
            reportViewer1.RefreshReport();

            


        }



        private void txtWlasciciel_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RaportPrzeglady_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvPojazdy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "EwidencjaPojazdow.RaportPrzeglady.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("PojazdyDS", pojazdy));
            reportViewer1.RefreshReport();
        }

        private void Wlasciciel_Click(object sender, EventArgs e)
        {

        }

        private void numRok_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpPrzeglad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            byte[] pdfBytes = reportViewer1.LocalReport.Render("PDF");

            
            string sciezka = "Raport_Pojazdy.pdf";

            
            File.WriteAllBytes(sciezka, pdfBytes);

            
            var wynik = MessageBox.Show("Zapisano raport! Czy chcesz go otworzyć?", "Sukces", MessageBoxButtons.YesNo);

            if (wynik == DialogResult.Yes)
            {
               
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(sciezka) { UseShellExecute = true });
            }
        }
    }
}
