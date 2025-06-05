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
    public partial class ProfilBebeForm : Form
    {
        public static Color culoareFundalAplicatie = SystemColors.Control; 
        public static Color culoareTextAplicatie = SystemColors.ControlText; 
        public ProfilBebeForm()
        {
            InitializeComponent();
            panelFundal.BackColor = culoareFundalAplicatie;
            panelText.BackColor = culoareTextAplicatie;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       /* private void ProfilBebeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.CuloareFundal = culoareFundalAplicatie;
            Properties.Settings.Default.CuloareText = culoareTextAplicatie;
            Properties.Settings.Default.Save();
        }*/

        private void btnCuloareFundal_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                culoareFundalAplicatie = colorDialog.Color;
                panelFundal.BackColor = culoareFundalAplicatie;
                AplicaCuloriPeFormulare(); 
            }

        }

        private void btnCuloareText_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                culoareTextAplicatie = colorDialog.Color;
                panelText.BackColor = culoareTextAplicatie;
                AplicaCuloriPeFormulare(); 
            }

        }

        private static void AplicaCuloriPeFormulare()
        {
            foreach (Form form in Application.OpenForms)
            {
                AplicaCuloare(form);
            }
        }

        private static void AplicaCuloare(Control control)
        {
            control.BackColor = culoareFundalAplicatie;
            control.ForeColor = culoareTextAplicatie;

            foreach (Control subControl in control.Controls)
            {
                AplicaCuloare(subControl);
            }
        }

        private void lblCuloareFundal_Click(object sender, EventArgs e)
        {

        }

        private void panelFundal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelText_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalvarePreferinte_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CuloareFundal = culoareFundalAplicatie;
            Properties.Settings.Default.CuloareText = culoareTextAplicatie;
            Properties.Settings.Default.Save();
            MessageBox.Show("Preferințele au fost salvate cu succes!", "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRearanjeazaControale_Click(object sender, EventArgs e)
        {
            InregistrareActivitateForm inregistrareForm = null;

            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is InregistrareActivitateForm form)
                {
                    inregistrareForm = form;
                    break;
                }
            }

            if (inregistrareForm != null)
            {
                
                Dictionary<string, int> accessCounts = inregistrareForm.ControlAccessCounts;

                List<Control> sortedControls = inregistrareForm.Controls.Cast<Control>()
                    .OrderByDescending(c => accessCounts.ContainsKey(c.Name) ? accessCounts[c.Name] : 0)
                    .ToList();

                int topOffset = 10;
                int leftOffset = 10;

                
                foreach (Control control in sortedControls)
                {
                   
                    if (!(control is Label))
                    {
                        control.Location = new Point(leftOffset, topOffset);
                        topOffset += control.Height + 10; 
                    }
                   
                }

                MessageBox.Show("Controalele au fost rearanjate în funcție de utilizare.", "Rearanjare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Formularul de înregistrare activitate nu este deschis.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }
    }
    }

