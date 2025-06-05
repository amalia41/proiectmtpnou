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
    public partial class InregistrareActivitateForm : Form
    {
        public Activitate ActivitateDeEditat { get; set; }

        private Dictionary<string, int> controlAccessCounts; 

        public Dictionary<string, int> ControlAccessCounts
        {
            get { return controlAccessCounts; }
        }

        public InregistrareActivitateForm() 
        {
            InitializeComponent();
            this.controlAccessCounts = new Dictionary<string, int>(); 
            InitializareControale();
            ResetForm();
        }

        public InregistrareActivitateForm(Activitate activitate, Dictionary<string, int> existingAccessCounts)
        {
            InitializeComponent();
            this.ActivitateDeEditat = activitate;
            this.controlAccessCounts = new Dictionary<string, int>(); 
            InitializareControale();
            PopuleazaFormularPentruEditare();
        }


        private void InitializareControale()
        {

            cmbTipActivitate.Items.Clear();
            cmbTipActivitate.Items.Add("Hranire");
            cmbTipActivitate.Items.Add("Somn");
            cmbTipActivitate.Items.Add("Schimbare scutec");
            cmbTipActivitate.Items.Add("Joaca");
            cmbTipActivitate.Items.Add("Baie");

            cmbTipScutec.Items.Clear();
            cmbTipScutec.Items.Add("Urina");
            cmbTipScutec.Items.Add("Scaun");
            cmbTipScutec.Items.Add("Ambele");
        }
        private void ResetForm()
        {
            txtCantitateHranire.Text = "";
            txtTipHranire.Text = "";
            dtpOraInceput.Value = DateTime.Now;
            dtpOraSfarsit.Value = DateTime.Now;
            cmbTipScutec.SelectedItem = null;
            cmbTipScutec.Text = "";
            txtTipJoaca.Text = "";
            numDurataJoaca.Value = 0;

            cmbTipActivitate.SelectedItem = null;
            cmbTipActivitate.Text = "";

            errorProviderValidare.Clear();


            cmbTipActivitate_SelectedIndexChanged(cmbTipActivitate, EventArgs.Empty);
        }

        private void PopuleazaFormularPentruEditare()
        {
            if (ActivitateDeEditat != null)
            {
                cmbTipActivitate.SelectedItem = ActivitateDeEditat.TipActivitate;

                switch (ActivitateDeEditat.TipActivitate)
                {
                    case "Hranire":
                        txtCantitateHranire.Text = ActivitateDeEditat.CantitateHranire.ToString();
                        txtTipHranire.Text = ActivitateDeEditat.TipHrana;
                        break;
                    case "Somn":
                        dtpOraInceput.Value = ActivitateDeEditat.OraInceputSomn;
                        dtpOraSfarsit.Value = ActivitateDeEditat.OraSfarsitSomn;
                        break;
                    case "Schimbare scutec":
                        cmbTipScutec.SelectedItem = ActivitateDeEditat.TipScutec;
                        break;
                    case "Joaca":
                        txtTipJoaca.Text = ActivitateDeEditat.TipJoaca;
                        numDurataJoaca.Value = ActivitateDeEditat.DurataJoacaMinute;
                        break;
                    case "Baie":
                        break;
                }
            }
        }

        private void cmbTipActivitate_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCantitate.Visible = false;
            txtCantitateHranire.Visible = false;
            lblTipHrana.Visible = false;
            txtTipHranire.Visible = false;

            lblOraInceput.Visible = false;
            dtpOraInceput.Visible = false;
            lblOraSfarsit.Visible = false;
            dtpOraSfarsit.Visible = false;

            lblTipScaun.Visible = false;
            cmbTipScutec.Visible = false;

            lblTipJoaca.Visible = false;
            txtTipJoaca.Visible = false;
            lblDurata.Visible = false;
            numDurataJoaca.Visible = false;


            txtCantitateHranire.Text = "";
            txtTipHranire.Text = "";
            dtpOraInceput.Value = DateTime.Now;
            dtpOraSfarsit.Value = DateTime.Now;
            cmbTipScutec.SelectedItem = null;
            cmbTipScutec.Text = "";
            txtTipJoaca.Text = "";
            numDurataJoaca.Value = 0;


            string selectedActivity = cmbTipActivitate.SelectedItem?.ToString(); 
            switch (selectedActivity)
            {
                case "Hranire":
                    lblCantitate.Visible = true;
                    txtCantitateHranire.Visible = true;
                    lblTipHrana.Visible = true;
                    txtTipHranire.Visible = true;
                    break;
                case "Somn":
                    lblOraInceput.Visible = true;
                    dtpOraInceput.Visible = true;
                    lblOraSfarsit.Visible = true;
                    dtpOraSfarsit.Visible = true;
                    break;
                case "Schimbare scutec":
                    lblTipScaun.Visible = true;
                    cmbTipScutec.Visible = true;
                    break;
                case "Joaca":
                    lblTipJoaca.Visible = true;
                    txtTipJoaca.Visible = true;
                    lblDurata.Visible = true;
                    numDurataJoaca.Visible = true;
                    break;
                case "Baie":
                    break;
                default:
                    break;
            }

            if (controlAccessCounts != null && controlAccessCounts.ContainsKey(cmbTipActivitate.Name))
            {
                controlAccessCounts[cmbTipActivitate.Name]++;
            }
            else if (controlAccessCounts != null)
            {
                controlAccessCounts.Add(cmbTipActivitate.Name, 1);
            }
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            bool valid = true;
            errorProviderValidare.Clear(); 

            if (cmbTipActivitate.SelectedItem == null)
            {
                errorProviderValidare.SetError(cmbTipActivitate, "Selectați tipul activității!");
                valid = false;
            }
            else
            {
                string selectedActivity = cmbTipActivitate.SelectedItem.ToString();
                switch (selectedActivity)
                {
                    case "Hranire":
                        if (string.IsNullOrWhiteSpace(txtCantitateHranire.Text))
                        {
                            errorProviderValidare.SetError(txtCantitateHranire, "Introduceți cantitatea!");
                            valid = false;
                        }
                        else if (!float.TryParse(txtCantitateHranire.Text, out _))
                        {
                            errorProviderValidare.SetError(txtCantitateHranire, "Cantitate invalidă!");
                            valid = false;
                        }
                        if (string.IsNullOrWhiteSpace(txtTipHranire.Text))
                        {
                            errorProviderValidare.SetError(txtTipHranire, "Introduceți tipul hranei!");
                            valid = false;
                        }
                        break;
                    case "Somn":
                        if (dtpOraInceput.Value >= dtpOraSfarsit.Value)
                        {
                            errorProviderValidare.SetError(dtpOraSfarsit, "Ora de sfârșit trebuie să fie după ora de început!");
                            valid = false;
                        }
                        break;
                    case "Schimbare scutec":
                        if (cmbTipScutec.SelectedItem == null)
                        {
                            errorProviderValidare.SetError(cmbTipScutec, "Selectați tipul scutecului!");
                            valid = false;
                        }
                        break;
                    case "Joaca":
                        if (string.IsNullOrWhiteSpace(txtTipJoaca.Text))
                        {
                            errorProviderValidare.SetError(txtTipJoaca, "Introduceți tipul jocului!");
                            valid = false;
                        }
                        if (numDurataJoaca.Value <= 0)
                        {
                            errorProviderValidare.SetError(numDurataJoaca, "Durata jocului trebuie să fie pozitivă!");
                            valid = false;
                        }
                        break;
                    case "Baie":
                        break;
                }
            }

            if (valid)
            {
                Activitate activitateCurenta;
                if (ActivitateDeEditat == null)
                {
                    activitateCurenta = new Activitate();
                    activitateCurenta.DataOra = DateTime.Now; 
                }
                else
                {
                    activitateCurenta = ActivitateDeEditat; 
                }

                activitateCurenta.TipActivitate = cmbTipActivitate.SelectedItem.ToString();

                switch (activitateCurenta.TipActivitate)
                {
                    case "Hranire":
                        activitateCurenta.CantitateHranire = float.Parse(txtCantitateHranire.Text);
                        activitateCurenta.TipHrana = txtTipHranire.Text;
                        activitateCurenta.OraInceputSomn = DateTime.MinValue;
                        activitateCurenta.OraSfarsitSomn = DateTime.MinValue;
                        activitateCurenta.TipScutec = "";
                        activitateCurenta.TipJoaca = "";
                        activitateCurenta.DurataJoacaMinute = 0;
                        break;
                    case "Somn":
                        activitateCurenta.OraInceputSomn = dtpOraInceput.Value;
                        activitateCurenta.OraSfarsitSomn = dtpOraSfarsit.Value;
                        activitateCurenta.CantitateHranire = 0;
                        activitateCurenta.TipHrana = "";
                        activitateCurenta.TipScutec = "";
                        activitateCurenta.TipJoaca = "";
                        activitateCurenta.DurataJoacaMinute = 0;
                        break;
                    case "Schimbare scutec":
                        activitateCurenta.TipScutec = cmbTipScutec.SelectedItem.ToString();
                        activitateCurenta.CantitateHranire = 0;
                        activitateCurenta.TipHrana = "";
                        activitateCurenta.OraInceputSomn = DateTime.MinValue;
                        activitateCurenta.OraSfarsitSomn = DateTime.MinValue;
                        activitateCurenta.TipJoaca = "";
                        activitateCurenta.DurataJoacaMinute = 0;
                        break;
                    case "Joaca":
                        activitateCurenta.TipJoaca = txtTipJoaca.Text;
                        activitateCurenta.DurataJoacaMinute = (int)numDurataJoaca.Value;
                        activitateCurenta.CantitateHranire = 0;
                        activitateCurenta.TipHrana = "";
                        activitateCurenta.OraInceputSomn = DateTime.MinValue;
                        activitateCurenta.OraSfarsitSomn = DateTime.MinValue;
                        activitateCurenta.TipScutec = "";
                        break;
                    case "Baie":
                        activitateCurenta.CantitateHranire = 0;
                        activitateCurenta.TipHrana = "";
                        activitateCurenta.OraInceputSomn = DateTime.MinValue;
                        activitateCurenta.OraSfarsitSomn = DateTime.MinValue;
                        activitateCurenta.TipScutec = "";
                        activitateCurenta.TipJoaca = "";
                        activitateCurenta.DurataJoacaMinute = 0;
                        break;
                }

                if (ActivitateDeEditat == null)
                {
                    DataManager.SalveazaActivitate(activitateCurenta);
                    MessageBox.Show("Activitate salvată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    List<Activitate> toateActivitatile = DataManager.CitesteActivitati();

                    var activitateOriginalaInLista = toateActivitatile.FirstOrDefault(a =>
                        a.DataOra == ActivitateDeEditat.DataOra &&
                        a.TipActivitate == ActivitateDeEditat.TipActivitate);

                    if (activitateOriginalaInLista != null)
                    {
                        activitateOriginalaInLista.TipActivitate = activitateCurenta.TipActivitate;
                        activitateOriginalaInLista.CantitateHranire = activitateCurenta.CantitateHranire;
                        activitateOriginalaInLista.TipHrana = activitateCurenta.TipHrana;
                        activitateOriginalaInLista.OraInceputSomn = activitateCurenta.OraInceputSomn;
                        activitateOriginalaInLista.OraSfarsitSomn = activitateCurenta.OraSfarsitSomn;
                        activitateOriginalaInLista.TipScutec = activitateCurenta.TipScutec;
                        activitateOriginalaInLista.TipJoaca = activitateCurenta.TipJoaca;
                        activitateOriginalaInLista.DurataJoacaMinute = activitateCurenta.DurataJoacaMinute;
                    }
                    else
                    {

                        toateActivitatile.Add(activitateCurenta);
                    }

                    DataManager.RescrieActivitati(toateActivitatile); 
                    MessageBox.Show("Activitate modificată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Dictionary<string, int> copieControlAccessCounts = new Dictionary<string, int>(controlAccessCounts);
                DashboardForm.ActualizeazaStatisticiAgregate(copieControlAccessCounts);

                this.DialogResult = DialogResult.OK;
                this.Close();

                DashboardForm.ActualizeazaStatisticiAgregate(controlAccessCounts);
                this.DialogResult = DialogResult.OK;
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Vă rugăm să corectați erorile din formular!", "Eroare Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (controlAccessCounts != null && controlAccessCounts.ContainsKey(btnSalvare.Name))
            {
                controlAccessCounts[btnSalvare.Name]++;
            }
        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            this.Close(); 
            if (controlAccessCounts != null && controlAccessCounts.ContainsKey(btnAnulare.Name))
            {
                controlAccessCounts[btnAnulare.Name]++;
            }
        }

 
        private void dtpOraActivitate_ValueChanged(object sender, EventArgs e)
        {
            if (controlAccessCounts != null && controlAccessCounts.ContainsKey(dtpOraActivitate.Name))
            {
                controlAccessCounts[dtpOraActivitate.Name]++;
            }
        }

        private void txtCantitateHranire_Enter(object sender, EventArgs e)
        {
            if (controlAccessCounts != null && controlAccessCounts.ContainsKey(txtCantitateHranire.Name))
            {
                controlAccessCounts[txtCantitateHranire.Name]++;
            }
        }

        private void txtTipHranire_Enter(object sender, EventArgs e)
        {
            if (controlAccessCounts != null && controlAccessCounts.ContainsKey(txtTipHranire.Name))
            {
                controlAccessCounts[txtTipHranire.Name]++;
            }
        }

        private void dtpOraInceput_ValueChanged(object sender, EventArgs e)
        {
            if (controlAccessCounts != null && controlAccessCounts.ContainsKey(dtpOraInceput.Name))
            {
                controlAccessCounts[dtpOraInceput.Name]++;
            }
        }

        private void dtpOraSfarsit_ValueChanged(object sender, EventArgs e)
        {
            if (controlAccessCounts != null && controlAccessCounts.ContainsKey(dtpOraSfarsit.Name))
            {
                controlAccessCounts[dtpOraSfarsit.Name]++;
            }
        }

        private void cmbTipScutec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (controlAccessCounts != null && controlAccessCounts.ContainsKey(cmbTipScutec.Name))
            {
                controlAccessCounts[cmbTipScutec.Name]++;
            }
        }

        private void txtTipJoaca_Enter(object sender, EventArgs e)
        {
            if (controlAccessCounts != null && controlAccessCounts.ContainsKey(txtTipJoaca.Name))
            {
                controlAccessCounts[txtTipJoaca.Name]++;
            }
        }

        private void numDurataJoaca_ValueChanged(object sender, EventArgs e)
        {
            if (controlAccessCounts != null && controlAccessCounts.ContainsKey(numDurataJoaca.Name))
            {
                controlAccessCounts[numDurataJoaca.Name]++;
            }
        }

        private void lblTip_Click(object sender, EventArgs e) { }
        private void lblTipJoaca_Click(object sender, EventArgs e) { }
        private void lblCantitate_Click(object sender, EventArgs e) { }
        private void txtTipJoaca_TextChanged(object sender, EventArgs e) { }
        private void InregistrareActivitateForm_Load(object sender, EventArgs e) { }
    }
}

