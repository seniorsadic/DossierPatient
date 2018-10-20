namespace Medecin.Hospitalisations
{
    partial class FicheHospitalisation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicheHospitalisation));
            this.button2 = new System.Windows.Forms.Button();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.hospitalisationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medecinDataSet = new Medecin.MedecinDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_consultation = new System.Windows.Forms.ComboBox();
            this.consultationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_datSanc = new System.Windows.Forms.Label();
            this.label_consultation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_adresse = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_mode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datedebut = new System.Windows.Forms.DateTimePicker();
            this.textBox_motif = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalisationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultationBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(355, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 44);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateFin
            // 
            this.dateFin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hospitalisationBindingSource, "dateFin", true));
            this.dateFin.Location = new System.Drawing.Point(146, 226);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(265, 21);
            this.dateFin.TabIndex = 48;
            // 
            // hospitalisationBindingSource
            // 
            this.hospitalisationBindingSource.DataMember = "hospitalisation";
            this.hospitalisationBindingSource.DataSource = this.medecinDataSet;
            // 
            // medecinDataSet
            // 
            this.medecinDataSet.DataSetName = "MedecinDataSet";
            this.medecinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(419, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "*";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(296, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 44);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(417, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.OrangeRed;
            this.label11.Location = new System.Drawing.Point(417, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "*";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_consultation
            // 
            this.comboBox_consultation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_consultation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_consultation.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consultationBindingSource, "idConsultation", true));
            this.comboBox_consultation.DataSource = this.consultationBindingSource;
            this.comboBox_consultation.DisplayMember = "numeroConsultation";
            this.comboBox_consultation.FormattingEnabled = true;
            this.comboBox_consultation.Location = new System.Drawing.Point(146, 23);
            this.comboBox_consultation.Name = "comboBox_consultation";
            this.comboBox_consultation.Size = new System.Drawing.Size(265, 22);
            this.comboBox_consultation.TabIndex = 4;
            this.comboBox_consultation.ValueMember = "idConsultation";
            // 
            // consultationBindingSource
            // 
            this.consultationBindingSource.DataMember = "consultation";
            this.consultationBindingSource.DataSource = this.medecinDataSet;
            // 
            // label_datSanc
            // 
            this.label_datSanc.AutoSize = true;
            this.label_datSanc.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_datSanc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_datSanc.Location = new System.Drawing.Point(6, 193);
            this.label_datSanc.Name = "label_datSanc";
            this.label_datSanc.Size = new System.Drawing.Size(80, 16);
            this.label_datSanc.TabIndex = 19;
            this.label_datSanc.Text = "Date Debut";
            this.label_datSanc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_consultation
            // 
            this.label_consultation.AutoSize = true;
            this.label_consultation.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_consultation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_consultation.Location = new System.Drawing.Point(14, 30);
            this.label_consultation.Name = "label_consultation";
            this.label_consultation.Size = new System.Drawing.Size(87, 16);
            this.label_consultation.TabIndex = 31;
            this.label_consultation.Text = "Consultation";
            this.label_consultation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(6, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Date Fin";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_adresse
            // 
            this.label_adresse.AutoSize = true;
            this.label_adresse.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_adresse.Location = new System.Drawing.Point(12, 106);
            this.label_adresse.Name = "label_adresse";
            this.label_adresse.Size = new System.Drawing.Size(39, 16);
            this.label_adresse.TabIndex = 20;
            this.label_adresse.Text = "Motif";
            this.label_adresse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.textBox_mode);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.datedebut);
            this.groupBox2.Controls.Add(this.textBox_motif);
            this.groupBox2.Controls.Add(this.dateFin);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboBox_consultation);
            this.groupBox2.Controls.Add(this.label_consultation);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label_adresse);
            this.groupBox2.Controls.Add(this.label_datSanc);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 307);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // textBox_mode
            // 
            this.textBox_mode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hospitalisationBindingSource, "modeSortie", true));
            this.textBox_mode.Location = new System.Drawing.Point(146, 270);
            this.textBox_mode.Name = "textBox_mode";
            this.textBox_mode.Size = new System.Drawing.Size(265, 21);
            this.textBox_mode.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(6, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Mode de Sortie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datedebut
            // 
            this.datedebut.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hospitalisationBindingSource, "dateDebut", true));
            this.datedebut.Location = new System.Drawing.Point(146, 188);
            this.datedebut.Name = "datedebut";
            this.datedebut.Size = new System.Drawing.Size(265, 21);
            this.datedebut.TabIndex = 50;
            // 
            // textBox_motif
            // 
            this.textBox_motif.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hospitalisationBindingSource, "motif", true));
            this.textBox_motif.Location = new System.Drawing.Point(146, 60);
            this.textBox_motif.MaxLength = 100;
            this.textBox_motif.Multiline = true;
            this.textBox_motif.Name = "textBox_motif";
            this.textBox_motif.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_motif.Size = new System.Drawing.Size(261, 112);
            this.textBox_motif.TabIndex = 49;
            // 
            // FicheHospitalisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 363);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FicheHospitalisation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiche Hospitalisation";
            this.Load += new System.EventHandler(this.FicheHospitalisation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalisationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultationBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_consultation;
        private System.Windows.Forms.Label label_datSanc;
        private System.Windows.Forms.Label label_consultation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_adresse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource hospitalisationBindingSource;
        private MedecinDataSet medecinDataSet;
        private System.Windows.Forms.BindingSource consultationBindingSource;
        private System.Windows.Forms.TextBox textBox_mode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datedebut;
        private System.Windows.Forms.TextBox textBox_motif;
    }
}