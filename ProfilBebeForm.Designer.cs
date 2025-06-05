namespace BabyMonitor
{
    partial class ProfilBebeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilBebeForm));
            this.lblCuloareFundal = new System.Windows.Forms.Label();
            this.lblCuloareText = new System.Windows.Forms.Label();
            this.btnCuloareFundal = new System.Windows.Forms.Button();
            this.btnCuloareText = new System.Windows.Forms.Button();
            this.panelFundal = new System.Windows.Forms.Panel();
            this.panelText = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnSalvarePreferinte = new System.Windows.Forms.Button();
            this.btnRearanjeazaControale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCuloareFundal
            // 
            this.lblCuloareFundal.AutoSize = true;
            this.lblCuloareFundal.BackColor = System.Drawing.Color.SandyBrown;
            this.lblCuloareFundal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCuloareFundal.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuloareFundal.Location = new System.Drawing.Point(62, 84);
            this.lblCuloareFundal.Name = "lblCuloareFundal";
            this.lblCuloareFundal.Size = new System.Drawing.Size(160, 27);
            this.lblCuloareFundal.TabIndex = 0;
            this.lblCuloareFundal.Text = "Culoare fundal:";
            this.lblCuloareFundal.Click += new System.EventHandler(this.lblCuloareFundal_Click);
            // 
            // lblCuloareText
            // 
            this.lblCuloareText.AutoSize = true;
            this.lblCuloareText.BackColor = System.Drawing.Color.SandyBrown;
            this.lblCuloareText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCuloareText.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuloareText.Location = new System.Drawing.Point(62, 149);
            this.lblCuloareText.Name = "lblCuloareText";
            this.lblCuloareText.Size = new System.Drawing.Size(136, 27);
            this.lblCuloareText.TabIndex = 1;
            this.lblCuloareText.Text = "Culoare text:";
            this.lblCuloareText.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCuloareFundal
            // 
            this.btnCuloareFundal.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuloareFundal.Location = new System.Drawing.Point(254, 79);
            this.btnCuloareFundal.Name = "btnCuloareFundal";
            this.btnCuloareFundal.Size = new System.Drawing.Size(188, 35);
            this.btnCuloareFundal.TabIndex = 2;
            this.btnCuloareFundal.Text = "Alege culoarea";
            this.btnCuloareFundal.UseVisualStyleBackColor = true;
            this.btnCuloareFundal.Click += new System.EventHandler(this.btnCuloareFundal_Click);
            // 
            // btnCuloareText
            // 
            this.btnCuloareText.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuloareText.Location = new System.Drawing.Point(254, 139);
            this.btnCuloareText.Name = "btnCuloareText";
            this.btnCuloareText.Size = new System.Drawing.Size(182, 35);
            this.btnCuloareText.TabIndex = 3;
            this.btnCuloareText.Text = "Alege culoarea";
            this.btnCuloareText.UseVisualStyleBackColor = true;
            this.btnCuloareText.Click += new System.EventHandler(this.btnCuloareText_Click);
            // 
            // panelFundal
            // 
            this.panelFundal.Location = new System.Drawing.Point(474, 79);
            this.panelFundal.Name = "panelFundal";
            this.panelFundal.Size = new System.Drawing.Size(83, 35);
            this.panelFundal.TabIndex = 4;
            this.panelFundal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFundal_Paint);
            // 
            // panelText
            // 
            this.panelText.Location = new System.Drawing.Point(474, 139);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(83, 35);
            this.panelText.TabIndex = 5;
            this.panelText.Paint += new System.Windows.Forms.PaintEventHandler(this.panelText_Paint);
            // 
            // btnSalvarePreferinte
            // 
            this.btnSalvarePreferinte.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSalvarePreferinte.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarePreferinte.Location = new System.Drawing.Point(607, 230);
            this.btnSalvarePreferinte.Name = "btnSalvarePreferinte";
            this.btnSalvarePreferinte.Size = new System.Drawing.Size(120, 42);
            this.btnSalvarePreferinte.TabIndex = 6;
            this.btnSalvarePreferinte.Text = "Salveaza";
            this.btnSalvarePreferinte.UseVisualStyleBackColor = false;
            this.btnSalvarePreferinte.Click += new System.EventHandler(this.btnSalvarePreferinte_Click);
            // 
            // btnRearanjeazaControale
            // 
            this.btnRearanjeazaControale.BackColor = System.Drawing.Color.SandyBrown;
            this.btnRearanjeazaControale.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRearanjeazaControale.Location = new System.Drawing.Point(34, 386);
            this.btnRearanjeazaControale.Name = "btnRearanjeazaControale";
            this.btnRearanjeazaControale.Size = new System.Drawing.Size(274, 34);
            this.btnRearanjeazaControale.TabIndex = 7;
            this.btnRearanjeazaControale.Text = "Rearanjeaza Controale";
            this.btnRearanjeazaControale.UseVisualStyleBackColor = false;
            this.btnRearanjeazaControale.Click += new System.EventHandler(this.btnRearanjeazaControale_Click);
            // 
            // ProfilBebeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRearanjeazaControale);
            this.Controls.Add(this.btnSalvarePreferinte);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.panelFundal);
            this.Controls.Add(this.btnCuloareText);
            this.Controls.Add(this.btnCuloareFundal);
            this.Controls.Add(this.lblCuloareText);
            this.Controls.Add(this.lblCuloareFundal);
            this.Name = "ProfilBebeForm";
            this.Text = "ProfilBebeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuloareFundal;
        private System.Windows.Forms.Label lblCuloareText;
        private System.Windows.Forms.Button btnCuloareFundal;
        private System.Windows.Forms.Button btnCuloareText;
        private System.Windows.Forms.Panel panelFundal;
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnSalvarePreferinte;
        private System.Windows.Forms.Button btnRearanjeazaControale;
    }
}