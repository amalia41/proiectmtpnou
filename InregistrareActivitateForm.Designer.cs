namespace BabyMonitor
{
    partial class InregistrareActivitateForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InregistrareActivitateForm));
            this.lblTip = new System.Windows.Forms.Label();
            this.cmbTipActivitate = new System.Windows.Forms.ComboBox();
            this.lblOra = new System.Windows.Forms.Label();
            this.dtpOraActivitate = new System.Windows.Forms.DateTimePicker();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.txtCantitateHranire = new System.Windows.Forms.TextBox();
            this.lblTipHrana = new System.Windows.Forms.Label();
            this.txtTipHranire = new System.Windows.Forms.TextBox();
            this.lblOraInceput = new System.Windows.Forms.Label();
            this.dtpOraInceput = new System.Windows.Forms.DateTimePicker();
            this.lblOraSfarsit = new System.Windows.Forms.Label();
            this.dtpOraSfarsit = new System.Windows.Forms.DateTimePicker();
            this.lblTipScaun = new System.Windows.Forms.Label();
            this.cmbTipScutec = new System.Windows.Forms.ComboBox();
            this.lblTipJoaca = new System.Windows.Forms.Label();
            this.txtTipJoaca = new System.Windows.Forms.TextBox();
            this.lblDurata = new System.Windows.Forms.Label();
            this.numDurataJoaca = new System.Windows.Forms.NumericUpDown();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.errorProviderValidare = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numDurataJoaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidare)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.BackColor = System.Drawing.Color.White;
            this.lblTip.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(48, 41);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(164, 25);
            this.lblTip.TabIndex = 0;
            this.lblTip.Text = "Tipul activitatii:";
            this.lblTip.Click += new System.EventHandler(this.lblTip_Click);
            // 
            // cmbTipActivitate
            // 
            this.cmbTipActivitate.BackColor = System.Drawing.Color.White;
            this.cmbTipActivitate.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipActivitate.FormattingEnabled = true;
            this.cmbTipActivitate.Items.AddRange(new object[] {
            "Hranire",
            "Somn",
            "Schimbare scutec",
            "Joaca",
            "Baie"});
            this.cmbTipActivitate.Location = new System.Drawing.Point(230, 38);
            this.cmbTipActivitate.Name = "cmbTipActivitate";
            this.cmbTipActivitate.Size = new System.Drawing.Size(136, 33);
            this.cmbTipActivitate.TabIndex = 1;
            this.cmbTipActivitate.SelectedIndexChanged += new System.EventHandler(this.cmbTipActivitate_SelectedIndexChanged);
            // 
            // lblOra
            // 
            this.lblOra.AutoSize = true;
            this.lblOra.BackColor = System.Drawing.Color.White;
            this.lblOra.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOra.Location = new System.Drawing.Point(48, 104);
            this.lblOra.Name = "lblOra";
            this.lblOra.Size = new System.Drawing.Size(56, 25);
            this.lblOra.TabIndex = 2;
            this.lblOra.Text = "Ora:";
            // 
            // dtpOraActivitate
            // 
            this.dtpOraActivitate.CalendarFont = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOraActivitate.CalendarMonthBackground = System.Drawing.Color.Thistle;
            this.dtpOraActivitate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpOraActivitate.Location = new System.Drawing.Point(142, 106);
            this.dtpOraActivitate.Name = "dtpOraActivitate";
            this.dtpOraActivitate.Size = new System.Drawing.Size(98, 20);
            this.dtpOraActivitate.TabIndex = 3;
            this.dtpOraActivitate.ValueChanged += new System.EventHandler(this.dtpOraActivitate_ValueChanged);
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.BackColor = System.Drawing.Color.White;
            this.lblCantitate.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantitate.Location = new System.Drawing.Point(48, 164);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(107, 25);
            this.lblCantitate.TabIndex = 4;
            this.lblCantitate.Text = "Cantitate:";
            this.lblCantitate.Click += new System.EventHandler(this.lblCantitate_Click);
            // 
            // txtCantitateHranire
            // 
            this.txtCantitateHranire.BackColor = System.Drawing.Color.White;
            this.txtCantitateHranire.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantitateHranire.Location = new System.Drawing.Point(172, 161);
            this.txtCantitateHranire.Name = "txtCantitateHranire";
            this.txtCantitateHranire.Size = new System.Drawing.Size(121, 32);
            this.txtCantitateHranire.TabIndex = 5;
            this.txtCantitateHranire.Enter += new System.EventHandler(this.txtCantitateHranire_Enter);
            // 
            // lblTipHrana
            // 
            this.lblTipHrana.AutoSize = true;
            this.lblTipHrana.BackColor = System.Drawing.Color.White;
            this.lblTipHrana.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipHrana.Location = new System.Drawing.Point(48, 229);
            this.lblTipHrana.Name = "lblTipHrana";
            this.lblTipHrana.Size = new System.Drawing.Size(192, 25);
            this.lblTipHrana.TabIndex = 6;
            this.lblTipHrana.Text = "Tip lapte/mancare:";
            // 
            // txtTipHranire
            // 
            this.txtTipHranire.BackColor = System.Drawing.Color.White;
            this.txtTipHranire.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipHranire.Location = new System.Drawing.Point(259, 226);
            this.txtTipHranire.Name = "txtTipHranire";
            this.txtTipHranire.Size = new System.Drawing.Size(156, 32);
            this.txtTipHranire.TabIndex = 7;
            this.txtTipHranire.Enter += new System.EventHandler(this.txtTipHranire_Enter);
            // 
            // lblOraInceput
            // 
            this.lblOraInceput.AutoSize = true;
            this.lblOraInceput.BackColor = System.Drawing.Color.White;
            this.lblOraInceput.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOraInceput.Location = new System.Drawing.Point(48, 289);
            this.lblOraInceput.Name = "lblOraInceput";
            this.lblOraInceput.Size = new System.Drawing.Size(131, 25);
            this.lblOraInceput.TabIndex = 8;
            this.lblOraInceput.Text = "Ora inceput:";
            // 
            // dtpOraInceput
            // 
            this.dtpOraInceput.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpOraInceput.Location = new System.Drawing.Point(204, 291);
            this.dtpOraInceput.Name = "dtpOraInceput";
            this.dtpOraInceput.Size = new System.Drawing.Size(114, 20);
            this.dtpOraInceput.TabIndex = 9;
            this.dtpOraInceput.ValueChanged += new System.EventHandler(this.dtpOraInceput_ValueChanged);
            // 
            // lblOraSfarsit
            // 
            this.lblOraSfarsit.AutoSize = true;
            this.lblOraSfarsit.BackColor = System.Drawing.Color.White;
            this.lblOraSfarsit.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOraSfarsit.Location = new System.Drawing.Point(48, 343);
            this.lblOraSfarsit.Name = "lblOraSfarsit";
            this.lblOraSfarsit.Size = new System.Drawing.Size(125, 25);
            this.lblOraSfarsit.TabIndex = 10;
            this.lblOraSfarsit.Text = "Ora Sfarsit:";
            // 
            // dtpOraSfarsit
            // 
            this.dtpOraSfarsit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpOraSfarsit.Location = new System.Drawing.Point(194, 345);
            this.dtpOraSfarsit.Name = "dtpOraSfarsit";
            this.dtpOraSfarsit.Size = new System.Drawing.Size(97, 20);
            this.dtpOraSfarsit.TabIndex = 11;
            this.dtpOraSfarsit.ValueChanged += new System.EventHandler(this.dtpOraSfarsit_ValueChanged);
            // 
            // lblTipScaun
            // 
            this.lblTipScaun.AutoSize = true;
            this.lblTipScaun.BackColor = System.Drawing.Color.White;
            this.lblTipScaun.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipScaun.Location = new System.Drawing.Point(45, 396);
            this.lblTipScaun.Name = "lblTipScaun";
            this.lblTipScaun.Size = new System.Drawing.Size(110, 25);
            this.lblTipScaun.TabIndex = 12;
            this.lblTipScaun.Text = "Tip scaun:";
            this.lblTipScaun.Visible = false;
            // 
            // cmbTipScutec
            // 
            this.cmbTipScutec.BackColor = System.Drawing.Color.White;
            this.cmbTipScutec.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipScutec.FormattingEnabled = true;
            this.cmbTipScutec.Items.AddRange(new object[] {
            "Urina",
            "Scaun",
            "Mixt"});
            this.cmbTipScutec.Location = new System.Drawing.Point(172, 393);
            this.cmbTipScutec.Name = "cmbTipScutec";
            this.cmbTipScutec.Size = new System.Drawing.Size(121, 33);
            this.cmbTipScutec.TabIndex = 13;
            this.cmbTipScutec.Visible = false;
            this.cmbTipScutec.SelectedIndexChanged += new System.EventHandler(this.cmbTipScutec_SelectedIndexChanged);
            // 
            // lblTipJoaca
            // 
            this.lblTipJoaca.AutoSize = true;
            this.lblTipJoaca.BackColor = System.Drawing.Color.White;
            this.lblTipJoaca.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipJoaca.Location = new System.Drawing.Point(467, 41);
            this.lblTipJoaca.Name = "lblTipJoaca";
            this.lblTipJoaca.Size = new System.Drawing.Size(105, 25);
            this.lblTipJoaca.TabIndex = 14;
            this.lblTipJoaca.Text = "Tip joaca:";
            this.lblTipJoaca.Visible = false;
            this.lblTipJoaca.Click += new System.EventHandler(this.lblTipJoaca_Click);
            // 
            // txtTipJoaca
            // 
            this.txtTipJoaca.BackColor = System.Drawing.Color.White;
            this.txtTipJoaca.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipJoaca.Location = new System.Drawing.Point(603, 38);
            this.txtTipJoaca.Name = "txtTipJoaca";
            this.txtTipJoaca.Size = new System.Drawing.Size(155, 32);
            this.txtTipJoaca.TabIndex = 15;
            this.txtTipJoaca.Visible = false;
            this.txtTipJoaca.TextChanged += new System.EventHandler(this.txtTipJoaca_TextChanged);
            this.txtTipJoaca.Enter += new System.EventHandler(this.txtTipJoaca_Enter);
            // 
            // lblDurata
            // 
            this.lblDurata.AutoSize = true;
            this.lblDurata.BackColor = System.Drawing.Color.White;
            this.lblDurata.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurata.Location = new System.Drawing.Point(467, 117);
            this.lblDurata.Name = "lblDurata";
            this.lblDurata.Size = new System.Drawing.Size(88, 25);
            this.lblDurata.TabIndex = 16;
            this.lblDurata.Text = "Durata:";
            this.lblDurata.Visible = false;
            // 
            // numDurataJoaca
            // 
            this.numDurataJoaca.BackColor = System.Drawing.Color.White;
            this.numDurataJoaca.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDurataJoaca.Location = new System.Drawing.Point(603, 110);
            this.numDurataJoaca.Name = "numDurataJoaca";
            this.numDurataJoaca.Size = new System.Drawing.Size(120, 32);
            this.numDurataJoaca.TabIndex = 17;
            this.numDurataJoaca.Visible = false;
            this.numDurataJoaca.ValueChanged += new System.EventHandler(this.numDurataJoaca_ValueChanged);
            // 
            // btnSalvare
            // 
            this.btnSalvare.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSalvare.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvare.Location = new System.Drawing.Point(524, 393);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(104, 41);
            this.btnSalvare.TabIndex = 18;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = false;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnAnulare
            // 
            this.btnAnulare.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAnulare.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnulare.Location = new System.Drawing.Point(657, 394);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(101, 38);
            this.btnAnulare.TabIndex = 19;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.UseVisualStyleBackColor = false;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // errorProviderValidare
            // 
            this.errorProviderValidare.ContainerControl = this;
            // 
            // InregistrareActivitateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.numDurataJoaca);
            this.Controls.Add(this.lblDurata);
            this.Controls.Add(this.txtTipJoaca);
            this.Controls.Add(this.lblTipJoaca);
            this.Controls.Add(this.cmbTipScutec);
            this.Controls.Add(this.lblTipScaun);
            this.Controls.Add(this.dtpOraSfarsit);
            this.Controls.Add(this.lblOraSfarsit);
            this.Controls.Add(this.dtpOraInceput);
            this.Controls.Add(this.lblOraInceput);
            this.Controls.Add(this.txtTipHranire);
            this.Controls.Add(this.lblTipHrana);
            this.Controls.Add(this.txtCantitateHranire);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.dtpOraActivitate);
            this.Controls.Add(this.lblOra);
            this.Controls.Add(this.cmbTipActivitate);
            this.Controls.Add(this.lblTip);
            this.Name = "InregistrareActivitateForm";
            this.Text = "InregistrareActivitate";
            this.Load += new System.EventHandler(this.InregistrareActivitateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDurataJoaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.ComboBox cmbTipActivitate;
        private System.Windows.Forms.Label lblOra;
        private System.Windows.Forms.DateTimePicker dtpOraActivitate;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.TextBox txtCantitateHranire;
        private System.Windows.Forms.Label lblTipHrana;
        private System.Windows.Forms.TextBox txtTipHranire;
        private System.Windows.Forms.Label lblOraInceput;
        private System.Windows.Forms.DateTimePicker dtpOraInceput;
        private System.Windows.Forms.Label lblOraSfarsit;
        private System.Windows.Forms.DateTimePicker dtpOraSfarsit;
        private System.Windows.Forms.Label lblTipScaun;
        private System.Windows.Forms.ComboBox cmbTipScutec;
        private System.Windows.Forms.Label lblTipJoaca;
        private System.Windows.Forms.TextBox txtTipJoaca;
        private System.Windows.Forms.Label lblDurata;
        private System.Windows.Forms.NumericUpDown numDurataJoaca;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.ErrorProvider errorProviderValidare;
    }
}