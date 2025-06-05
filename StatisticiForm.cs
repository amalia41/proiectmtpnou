using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BabyMonitor;

namespace BabyMonitor
{
    public partial class StatisticiForm : Form
    {
        public StatisticiForm()
        {
            InitializeComponent();
            PopuleazaStatistici();
            IncarcaActivitati();

        }

        public void PopuleazaStatistici()
        {
            dgvStatistici.Rows.Clear();
            dgvStatistici.Columns.Clear();

            if (dgvStatistici.Columns.Count == 0)
            {
                dgvStatistici.Columns.Add("NumeControl", "Control");
                dgvStatistici.Columns.Add("NumarAccesari", "Accesări");
            }

            if (DashboardForm.statisticiAgregate != null && DashboardForm.statisticiAgregate.Any())
            {
                var sortedCounts = DashboardForm.statisticiAgregate.OrderByDescending(pair => pair.Value);
                foreach (var pair in sortedCounts)
                {
                    dgvStatistici.Rows.Add(pair.Key, pair.Value);
                }
            }
            else
            {
                dgvStatistici.Rows.Add("Niciun control accesat încă.");
            }

            dgvStatistici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void IncarcaActivitati(string searchTerm = "")
        {
            List<Activitate> activitati = DataManager.CitesteActivitati();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                activitati = activitati
                    .Where(a => a.TipActivitate.ToLower().Contains(searchTerm.ToLower()))
                    .ToList();
            }

            if (activitati.Any())
            {
                dgvActivitati.DataSource = activitati;
                dgvActivitati.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
            {
                dgvActivitati.DataSource = null;
                dgvActivitati.Rows.Clear();
                dgvActivitati.Columns.Clear();
                dgvActivitati.Columns.Add("Info", "Info");
                dgvActivitati.Rows.Add("Nicio activitate găsită pentru termenul de căutare.");
                dgvActivitati.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StatisticiForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string searchTerm = txtCautaActivitate.Text;
            IncarcaActivitati(searchTerm);
        }

        private void btnStergeActivitate_Click(object sender, EventArgs e)
        {
            if (dgvActivitati.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vă rugăm să selectați cel puțin o activitate de șters.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show("Sunteți sigur că doriți să ștergeți activitățile selectate?", "Confirmare ștergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                List<Activitate> activitatiCurente = DataManager.CitesteActivitati();

                List<Activitate> activitatiDeSters = new List<Activitate>();
                foreach (DataGridViewRow row in dgvActivitati.SelectedRows)
                {
                    if (row.DataBoundItem is Activitate activitateSelectata)
                    {
                        activitatiDeSters.Add(activitateSelectata);
                    }
                }

                foreach (Activitate activitate in activitatiDeSters)
                {
                    activitatiCurente.RemoveAll(a =>
                        a.DataOra == activitate.DataOra &&
                        a.TipActivitate == activitate.TipActivitate &&
                        a.CantitateHranire == activitate.CantitateHranire &&
                        a.TipHrana == activitate.TipHrana
                    );
                }

                DataManager.RescrieActivitati(activitatiCurente);
                IncarcaActivitati();
                MessageBox.Show("Activitatile selectate au fost șterse cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificaActivitate_Click(object sender, EventArgs e)
        {
            if (dgvActivitati.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgvActivitati.SelectedRows[0];
                if (selectedRow.DataBoundItem is Activitate activitateDeModificat)
                {
                    InregistrareActivitateForm editForm = new InregistrareActivitateForm(activitateDeModificat, new Dictionary<string, int>()); // Sau chiar new InregistrareActivitateForm(activitateDeModificat); dacă elimini parametrul accessCounts din acel constructor

                    DialogResult result = editForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        IncarcaActivitati(txtCautaActivitate.Text);
                    }
                }
            }
        }
    }
} 

