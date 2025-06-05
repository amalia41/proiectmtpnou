namespace BabyMonitor
{
    partial class StatisticiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticiForm));
            this.lblStatistici = new System.Windows.Forms.Label();
            this.dgvStatistici = new System.Windows.Forms.DataGridView();
            this.dgvActivitati = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCautaActivitate = new System.Windows.Forms.TextBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnStergeActivitate = new System.Windows.Forms.Button();
            this.btnModificaActivitate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivitati)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatistici
            // 
            this.lblStatistici.AutoSize = true;
            this.lblStatistici.BackColor = System.Drawing.Color.SandyBrown;
            this.lblStatistici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatistici.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistici.ForeColor = System.Drawing.Color.Black;
            this.lblStatistici.Location = new System.Drawing.Point(261, 29);
            this.lblStatistici.Name = "lblStatistici";
            this.lblStatistici.Size = new System.Drawing.Size(285, 40);
            this.lblStatistici.TabIndex = 0;
            this.lblStatistici.Text = "Statistici detaliate";
            // 
            // dgvStatistici
            // 
            this.dgvStatistici.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgvStatistici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistici.GridColor = System.Drawing.Color.MistyRose;
            this.dgvStatistici.Location = new System.Drawing.Point(25, 84);
            this.dgvStatistici.Name = "dgvStatistici";
            this.dgvStatistici.Size = new System.Drawing.Size(344, 246);
            this.dgvStatistici.TabIndex = 1;
            this.dgvStatistici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvActivitati
            // 
            this.dgvActivitati.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgvActivitati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivitati.Location = new System.Drawing.Point(411, 84);
            this.dgvActivitati.Name = "dgvActivitati";
            this.dgvActivitati.Size = new System.Drawing.Size(344, 246);
            this.dgvActivitati.TabIndex = 2;
            this.dgvActivitati.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cauta dupa tipul activitatii";
            // 
            // txtCautaActivitate
            // 
            this.txtCautaActivitate.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCautaActivitate.Location = new System.Drawing.Point(597, 358);
            this.txtCautaActivitate.Name = "txtCautaActivitate";
            this.txtCautaActivitate.Size = new System.Drawing.Size(158, 24);
            this.txtCautaActivitate.TabIndex = 4;
            // 
            // btnCauta
            // 
            this.btnCauta.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.Location = new System.Drawing.Point(411, 397);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(85, 24);
            this.btnCauta.TabIndex = 5;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnStergeActivitate
            // 
            this.btnStergeActivitate.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergeActivitate.Location = new System.Drawing.Point(512, 395);
            this.btnStergeActivitate.Name = "btnStergeActivitate";
            this.btnStergeActivitate.Size = new System.Drawing.Size(147, 26);
            this.btnStergeActivitate.TabIndex = 6;
            this.btnStergeActivitate.Text = "Sterge activitate";
            this.btnStergeActivitate.UseVisualStyleBackColor = true;
            this.btnStergeActivitate.Click += new System.EventHandler(this.btnStergeActivitate_Click);
            // 
            // btnModificaActivitate
            // 
            this.btnModificaActivitate.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaActivitate.Location = new System.Drawing.Point(680, 397);
            this.btnModificaActivitate.Name = "btnModificaActivitate";
            this.btnModificaActivitate.Size = new System.Drawing.Size(75, 23);
            this.btnModificaActivitate.TabIndex = 7;
            this.btnModificaActivitate.Text = "Modifica";
            this.btnModificaActivitate.UseVisualStyleBackColor = true;
            this.btnModificaActivitate.Click += new System.EventHandler(this.btnModificaActivitate_Click);
            // 
            // StatisticiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModificaActivitate);
            this.Controls.Add(this.btnStergeActivitate);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.txtCautaActivitate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvActivitati);
            this.Controls.Add(this.dgvStatistici);
            this.Controls.Add(this.lblStatistici);
            this.Name = "StatisticiForm";
            this.Text = "StatisticiForm";
            this.Load += new System.EventHandler(this.StatisticiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivitati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatistici;
        private System.Windows.Forms.DataGridView dgvStatistici;
        private System.Windows.Forms.DataGridView dgvActivitati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCautaActivitate;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnStergeActivitate;
        private System.Windows.Forms.Button btnModificaActivitate;
    }
}