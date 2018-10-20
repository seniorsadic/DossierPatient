namespace Medecin.Consultations
{
    partial class FicheConsultation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicheConsultation));
            this.button2 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.consultationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medecinDataSet = new Medecin.MedecinDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_medecin = new System.Windows.Forms.ComboBox();
            this.personnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label_medecin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_pathologie = new System.Windows.Forms.ComboBox();
            this.pathologieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_patient = new System.Windows.Forms.Label();
            this.label_pathologie = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.textBox_observation = new System.Windows.Forms.TextBox();
            this.label_adresse = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_numCons = new System.Windows.Forms.TextBox();
            this.comboBox_patient = new System.Windows.Forms.ComboBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.consultationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathologieBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
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
            // date
            // 
            this.date.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.consultationBindingSource, "date", true));
            this.date.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultationBindingSource, "date", true));
            this.date.Location = new System.Drawing.Point(161, 180);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(250, 21);
            this.date.TabIndex = 48;
            // 
            // consultationBindingSource
            // 
            this.consultationBindingSource.DataMember = "consultation";
            this.consultationBindingSource.DataSource = this.medecinDataSet;
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
            // comboBox_medecin
            // 
            this.comboBox_medecin.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consultationBindingSource, "idPersonnel", true));
            this.comboBox_medecin.DataSource = this.personnelBindingSource;
            this.comboBox_medecin.DisplayMember = "nom";
            this.comboBox_medecin.FormattingEnabled = true;
            this.comboBox_medecin.Location = new System.Drawing.Point(161, 61);
            this.comboBox_medecin.Name = "comboBox_medecin";
            this.comboBox_medecin.Size = new System.Drawing.Size(250, 22);
            this.comboBox_medecin.TabIndex = 46;
            this.comboBox_medecin.ValueMember = "idPersonne";
            // 
            // personnelBindingSource
            // 
            this.personnelBindingSource.DataMember = "personnel";
            this.personnelBindingSource.DataSource = this.medecinDataSet;
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
            // label_medecin
            // 
            this.label_medecin.AutoSize = true;
            this.label_medecin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_medecin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_medecin.Location = new System.Drawing.Point(14, 65);
            this.label_medecin.Name = "label_medecin";
            this.label_medecin.Size = new System.Drawing.Size(62, 16);
            this.label_medecin.TabIndex = 45;
            this.label_medecin.Text = "Medecin";
            this.label_medecin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(423, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(419, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(423, 184);
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
            this.label11.Location = new System.Drawing.Point(419, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "*";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_pathologie
            // 
            this.comboBox_pathologie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_pathologie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_pathologie.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consultationBindingSource, "idPathologie", true));
            this.comboBox_pathologie.DataSource = this.pathologieBindingSource;
            this.comboBox_pathologie.DisplayMember = "nomMaladie";
            this.comboBox_pathologie.FormattingEnabled = true;
            this.comboBox_pathologie.Location = new System.Drawing.Point(161, 23);
            this.comboBox_pathologie.Name = "comboBox_pathologie";
            this.comboBox_pathologie.Size = new System.Drawing.Size(250, 22);
            this.comboBox_pathologie.TabIndex = 4;
            this.comboBox_pathologie.ValueMember = "idPathologie";
            // 
            // pathologieBindingSource
            // 
            this.pathologieBindingSource.DataMember = "pathologie";
            this.pathologieBindingSource.DataSource = this.medecinDataSet;
            // 
            // label_patient
            // 
            this.label_patient.AutoSize = true;
            this.label_patient.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_patient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_patient.Location = new System.Drawing.Point(14, 112);
            this.label_patient.Name = "label_patient";
            this.label_patient.Size = new System.Drawing.Size(52, 16);
            this.label_patient.TabIndex = 19;
            this.label_patient.Text = "Patient";
            this.label_patient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_pathologie
            // 
            this.label_pathologie.AutoSize = true;
            this.label_pathologie.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pathologie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_pathologie.Location = new System.Drawing.Point(14, 30);
            this.label_pathologie.Name = "label_pathologie";
            this.label_pathologie.Size = new System.Drawing.Size(75, 16);
            this.label_pathologie.TabIndex = 31;
            this.label_pathologie.Text = "Pathologie";
            this.label_pathologie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_date.Location = new System.Drawing.Point(14, 180);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(42, 16);
            this.label_date.TabIndex = 28;
            this.label_date.Text = "Date ";
            this.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_observation
            // 
            this.textBox_observation.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.consultationBindingSource, "observationsPrescriptions", true));
            this.textBox_observation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultationBindingSource, "observationsPrescriptions", true));
            this.textBox_observation.Location = new System.Drawing.Point(161, 216);
            this.textBox_observation.MaxLength = 100;
            this.textBox_observation.Multiline = true;
            this.textBox_observation.Name = "textBox_observation";
            this.textBox_observation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_observation.Size = new System.Drawing.Size(250, 85);
            this.textBox_observation.TabIndex = 7;
            // 
            // label_adresse
            // 
            this.label_adresse.AutoSize = true;
            this.label_adresse.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_adresse.Location = new System.Drawing.Point(-3, 238);
            this.label_adresse.Name = "label_adresse";
            this.label_adresse.Size = new System.Drawing.Size(167, 16);
            this.label_adresse.TabIndex = 20;
            this.label_adresse.Text = "Observation Consultation";
            this.label_adresse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_numCons);
            this.groupBox2.Controls.Add(this.comboBox_patient);
            this.groupBox2.Controls.Add(this.date);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBox_medecin);
            this.groupBox2.Controls.Add(this.label_medecin);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboBox_pathologie);
            this.groupBox2.Controls.Add(this.label_pathologie);
            this.groupBox2.Controls.Add(this.label_date);
            this.groupBox2.Controls.Add(this.textBox_observation);
            this.groupBox2.Controls.Add(this.label_adresse);
            this.groupBox2.Controls.Add(this.label_patient);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 307);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(-1, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Numéro Consultation";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(419, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_numCons
            // 
            this.textBox_numCons.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.consultationBindingSource, "numeroConsultation", true));
            this.textBox_numCons.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultationBindingSource, "numeroConsultation", true));
            this.textBox_numCons.Location = new System.Drawing.Point(161, 147);
            this.textBox_numCons.Name = "textBox_numCons";
            this.textBox_numCons.Size = new System.Drawing.Size(250, 21);
            this.textBox_numCons.TabIndex = 50;
            // 
            // comboBox_patient
            // 
            this.comboBox_patient.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consultationBindingSource, "idPatient", true));
            this.comboBox_patient.DataSource = this.patientBindingSource;
            this.comboBox_patient.DisplayMember = "nom";
            this.comboBox_patient.FormattingEnabled = true;
            this.comboBox_patient.Location = new System.Drawing.Point(161, 107);
            this.comboBox_patient.Name = "comboBox_patient";
            this.comboBox_patient.Size = new System.Drawing.Size(250, 22);
            this.comboBox_patient.TabIndex = 49;
            this.comboBox_patient.ValueMember = "idPersonne";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "patient";
            this.patientBindingSource.DataSource = this.medecinDataSet;
            // 
            // FicheConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 363);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FicheConsultation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiche Consultation";
            this.Load += new System.EventHandler(this.FicheConsultation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathologieBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_medecin;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_medecin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_pathologie;
        private System.Windows.Forms.Label label_patient;
        private System.Windows.Forms.Label label_pathologie;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.TextBox textBox_observation;
        private System.Windows.Forms.Label label_adresse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_patient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_numCons;
        private System.Windows.Forms.BindingSource consultationBindingSource;
        private MedecinDataSet medecinDataSet;
        private System.Windows.Forms.BindingSource personnelBindingSource;
        private System.Windows.Forms.BindingSource pathologieBindingSource;
        private System.Windows.Forms.BindingSource patientBindingSource;
    }
}