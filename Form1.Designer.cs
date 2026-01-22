namespace EwidencjaPojazdow
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        private void InitializeComponent()
        {
            this.NrRejestracyjny = new System.Windows.Forms.Label();
            this.txtRejestracja = new System.Windows.Forms.TextBox();
            this.dtpPrzeglad = new System.Windows.Forms.DateTimePicker();
            this.numRok = new System.Windows.Forms.NumericUpDown();
            this.Marka = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.RokProdukcji = new System.Windows.Forms.Label();
            this.DataPrzegladu = new System.Windows.Forms.Label();
            this.Wlasciciel = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtWlasciciel = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvPojazdy = new System.Windows.Forms.DataGridView();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdy)).BeginInit();
            this.SuspendLayout();
            // 
            // NrRejestracyjny
            // 
            this.NrRejestracyjny.AutoSize = true;
            this.NrRejestracyjny.Location = new System.Drawing.Point(9, 65);
            this.NrRejestracyjny.Name = "NrRejestracyjny";
            this.NrRejestracyjny.Size = new System.Drawing.Size(126, 16);
            this.NrRejestracyjny.TabIndex = 0;
            this.NrRejestracyjny.Text = "Numer rejestracyjny";
            this.NrRejestracyjny.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRejestracja
            // 
            this.txtRejestracja.Location = new System.Drawing.Point(12, 40);
            this.txtRejestracja.Name = "txtRejestracja";
            this.txtRejestracja.Size = new System.Drawing.Size(100, 22);
            this.txtRejestracja.TabIndex = 1;
            // 
            // dtpPrzeglad
            // 
            this.dtpPrzeglad.Location = new System.Drawing.Point(296, 132);
            this.dtpPrzeglad.Name = "dtpPrzeglad";
            this.dtpPrzeglad.Size = new System.Drawing.Size(200, 22);
            this.dtpPrzeglad.TabIndex = 2;
            this.dtpPrzeglad.Value = new System.DateTime(2026, 1, 20, 19, 3, 53, 0);
            this.dtpPrzeglad.ValueChanged += new System.EventHandler(this.dtpPrzeglad_ValueChanged);
            // 
            // numRok
            // 
            this.numRok.Location = new System.Drawing.Point(296, 41);
            this.numRok.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numRok.Name = "numRok";
            this.numRok.Size = new System.Drawing.Size(120, 22);
            this.numRok.TabIndex = 3;
            this.numRok.ValueChanged += new System.EventHandler(this.numRok_ValueChanged);
            // 
            // Marka
            // 
            this.Marka.AutoSize = true;
            this.Marka.Location = new System.Drawing.Point(26, 138);
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(45, 16);
            this.Marka.TabIndex = 4;
            this.Marka.Text = "Marka";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(26, 217);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(45, 16);
            this.Model.TabIndex = 5;
            this.Model.Text = "Model";
            // 
            // RokProdukcji
            // 
            this.RokProdukcji.AutoSize = true;
            this.RokProdukcji.Location = new System.Drawing.Point(304, 66);
            this.RokProdukcji.Name = "RokProdukcji";
            this.RokProdukcji.Size = new System.Drawing.Size(90, 16);
            this.RokProdukcji.TabIndex = 6;
            this.RokProdukcji.Text = "Rok produkcji";
            // 
            // DataPrzegladu
            // 
            this.DataPrzegladu.AutoSize = true;
            this.DataPrzegladu.Location = new System.Drawing.Point(304, 157);
            this.DataPrzegladu.Name = "DataPrzegladu";
            this.DataPrzegladu.Size = new System.Drawing.Size(99, 16);
            this.DataPrzegladu.TabIndex = 7;
            this.DataPrzegladu.Text = "Data przeglądu";
            // 
            // Wlasciciel
            // 
            this.Wlasciciel.AutoSize = true;
            this.Wlasciciel.Location = new System.Drawing.Point(26, 291);
            this.Wlasciciel.Name = "Wlasciciel";
            this.Wlasciciel.Size = new System.Drawing.Size(72, 16);
            this.Wlasciciel.TabIndex = 8;
            this.Wlasciciel.Text = "Właściciel";
            this.Wlasciciel.Click += new System.EventHandler(this.Wlasciciel_Click);
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(12, 113);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 22);
            this.txtMarka.TabIndex = 9;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(12, 192);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 10;
            // 
            // txtWlasciciel
            // 
            this.txtWlasciciel.Location = new System.Drawing.Point(12, 266);
            this.txtWlasciciel.Name = "txtWlasciciel";
            this.txtWlasciciel.Size = new System.Drawing.Size(100, 22);
            this.txtWlasciciel.TabIndex = 11;
            this.txtWlasciciel.TextChanged += new System.EventHandler(this.txtWlasciciel_TextChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(296, 328);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(98, 23);
            this.btnDodaj.TabIndex = 12;
            this.btnDodaj.Text = "Dodaj pojazd";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvPojazdy
            // 
            this.dgvPojazdy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPojazdy.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPojazdy.Location = new System.Drawing.Point(0, 0);
            this.dgvPojazdy.Name = "dgvPojazdy";
            this.dgvPojazdy.RowHeadersWidth = 51;
            this.dgvPojazdy.RowTemplate.Height = 24;
            this.dgvPojazdy.Size = new System.Drawing.Size(754, 363);
            this.dgvPojazdy.TabIndex = 13;
            this.dgvPojazdy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPojazdy_CellContentClick);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportViewer1.Location = new System.Drawing.Point(0, 315);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(754, 300);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_2);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(608, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Eksportuj do PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 615);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtWlasciciel);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.Wlasciciel);
            this.Controls.Add(this.DataPrzegladu);
            this.Controls.Add(this.RokProdukcji);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Marka);
            this.Controls.Add(this.numRok);
            this.Controls.Add(this.dtpPrzeglad);
            this.Controls.Add(this.txtRejestracja);
            this.Controls.Add(this.NrRejestracyjny);
            this.Controls.Add(this.dgvPojazdy);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NrRejestracyjny;
        private System.Windows.Forms.TextBox txtRejestracja;
        private System.Windows.Forms.DateTimePicker dtpPrzeglad;
        private System.Windows.Forms.NumericUpDown numRok;
        private System.Windows.Forms.Label Marka;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label RokProdukcji;
        private System.Windows.Forms.Label DataPrzegladu;
        private System.Windows.Forms.Label Wlasciciel;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtWlasciciel;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvPojazdy;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
    }
}

