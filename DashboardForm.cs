using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabyMonitor
{
    public partial class DashboardForm : Form
    {
        public static Dictionary<string, int> statisticiAgregate = new Dictionary<string, int>();
        private static readonly object lockObject = new object();

        public static void ActualizeazaStatisticiAgregate(Dictionary<string, int> counts)
        {
            lock (lockObject)
            {
                if (statisticiAgregate == null)
                {
                    statisticiAgregate = new Dictionary<string, int>();
                }

                foreach (var entry in counts) 
                {
                    if (statisticiAgregate.ContainsKey(entry.Key))
                    {
                        statisticiAgregate[entry.Key] += entry.Value;
                    }
                    else
                    {
                        statisticiAgregate.Add(entry.Key, entry.Value);
                    }
                }
            }
        }

        public DashboardForm()
        {
            InitializeComponent();
            IncarcaPreferinteCuloare();
        }
        private void IncarcaPreferinteCuloare()
        {
            ProfilBebeForm.culoareFundalAplicatie = Properties.Settings.Default.CuloareFundal;
            ProfilBebeForm.culoareTextAplicatie = Properties.Settings.Default.CuloareText;
            AplicaCulori();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            AplicaCulori();
        }

        private void AplicaCulori()
        {
            this.BackColor = ProfilBebeForm.culoareFundalAplicatie;
            this.ForeColor = ProfilBebeForm.culoareTextAplicatie;
            AplicaCuloareControl(this);
        }

        private void AplicaCuloareControl(Control control)
        {
            foreach (Control subControl in control.Controls)
            {
                subControl.BackColor = ProfilBebeForm.culoareFundalAplicatie;
                subControl.ForeColor = ProfilBebeForm.culoareTextAplicatie;
                AplicaCuloareControl(subControl);
            }
        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {

            InregistrareActivitateForm inregistrareForm = null;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is InregistrareActivitateForm)
                {
                    inregistrareForm = (InregistrareActivitateForm)openForm;
                    break;
                }
            }

            if (inregistrareForm == null)
            {
                inregistrareForm = new InregistrareActivitateForm();
                inregistrareForm.FormClosed += (s, args) => {
                    if (inregistrareForm.DialogResult == DialogResult.OK)
                    {

                    }
                    inregistrareForm = null;
                };
                inregistrareForm.Show();
            }

            if (inregistrareForm == null)
            {
                inregistrareForm = new InregistrareActivitateForm(); 
                inregistrareForm.FormClosed += (s, args) => {
                    if (inregistrareForm.DialogResult == DialogResult.OK)
                    {

                    }
                    inregistrareForm = null;
                };
                inregistrareForm.Show();
            }
            else
            {
                inregistrareForm.BringToFront();
            }
        }

        private void btnStatistici_Click(object sender, EventArgs e)
        {
            StatisticiForm statisticiForm = null;

            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is StatisticiForm form)
                {
                    statisticiForm = form;
                    break;
                }
            }

            if (statisticiForm != null && !statisticiForm.IsDisposed)
            {
                statisticiForm.PopuleazaStatistici();
                statisticiForm.Show();
            }
            else
            {
                statisticiForm = new StatisticiForm();
                statisticiForm.PopuleazaStatistici();
                statisticiForm.Show();
            }
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            ProfilBebeForm profilForm = new ProfilBebeForm();
            profilForm.Show();
        }
    }
}
