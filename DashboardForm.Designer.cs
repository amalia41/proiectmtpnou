namespace BabyMonitor
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.lblTitluAplicatie = new System.Windows.Forms.Label();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.btnStatistici = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitluAplicatie
            // 
            this.lblTitluAplicatie.AutoSize = true;
            this.lblTitluAplicatie.BackColor = System.Drawing.Color.SandyBrown;
            this.lblTitluAplicatie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitluAplicatie.Font = new System.Drawing.Font("Elephant", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitluAplicatie.ForeColor = System.Drawing.Color.Black;
            this.lblTitluAplicatie.Location = new System.Drawing.Point(265, 54);
            this.lblTitluAplicatie.Name = "lblTitluAplicatie";
            this.lblTitluAplicatie.Size = new System.Drawing.Size(271, 49);
            this.lblTitluAplicatie.TabIndex = 0;
            this.lblTitluAplicatie.Text = "BabyMonitor";
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.BackColor = System.Drawing.Color.SandyBrown;
            this.btnInregistrare.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInregistrare.ForeColor = System.Drawing.Color.Black;
            this.btnInregistrare.Location = new System.Drawing.Point(57, 180);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(176, 104);
            this.btnInregistrare.TabIndex = 1;
            this.btnInregistrare.Text = "Inregistrare activitate";
            this.btnInregistrare.UseVisualStyleBackColor = false;
            this.btnInregistrare.Click += new System.EventHandler(this.btnInregistrare_Click);
            // 
            // btnStatistici
            // 
            this.btnStatistici.BackColor = System.Drawing.Color.SandyBrown;
            this.btnStatistici.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistici.ForeColor = System.Drawing.Color.Black;
            this.btnStatistici.Location = new System.Drawing.Point(315, 180);
            this.btnStatistici.Name = "btnStatistici";
            this.btnStatistici.Size = new System.Drawing.Size(165, 104);
            this.btnStatistici.TabIndex = 2;
            this.btnStatistici.Text = "Vezi statistici";
            this.btnStatistici.UseVisualStyleBackColor = false;
            this.btnStatistici.Click += new System.EventHandler(this.btnStatistici_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.SandyBrown;
            this.btnProfil.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfil.ForeColor = System.Drawing.Color.Black;
            this.btnProfil.Location = new System.Drawing.Point(556, 180);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(194, 104);
            this.btnProfil.TabIndex = 3;
            this.btnProfil.Text = "Gestioneaza profil bebe";
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.btnStatistici);
            this.Controls.Add(this.btnInregistrare);
            this.Controls.Add(this.lblTitluAplicatie);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitluAplicatie;
        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.Button btnStatistici;
        private System.Windows.Forms.Button btnProfil;
    }
}