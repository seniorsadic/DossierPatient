namespace Medecin.Consultations
{
    partial class FormConsultationBis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitaliserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordonnaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dossierPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idConsultationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idExamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.examenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medecinDataSet = new Medecin.MedecinDataSet();
            this.idResultatExamenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateResultatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultatexamenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idMedicamentOrdonnanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOrdonnanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedicamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.medicamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombrePriseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamentordonnanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pathologieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medecinDataSet1 = new Medecin.MedecinDataSet();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultatexamenBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentordonnanceBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pathologieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.hospitaliserToolStripMenuItem,
            this.ordonnaceToolStripMenuItem,
            this.dossierPatientToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 80);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Image = global::Medecin.Properties.Resources.toolStripButton1_Image;
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(75, 76);
            this.ajouterToolStripMenuItem.Text = "Enregistrer";
            this.ajouterToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // hospitaliserToolStripMenuItem
            // 
            this.hospitaliserToolStripMenuItem.Image = global::Medecin.Properties.Resources.ddzsluifkiweszxwrpkz;
            this.hospitaliserToolStripMenuItem.Name = "hospitaliserToolStripMenuItem";
            this.hospitaliserToolStripMenuItem.Size = new System.Drawing.Size(81, 76);
            this.hospitaliserToolStripMenuItem.Text = "Hospitaliser";
            this.hospitaliserToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.hospitaliserToolStripMenuItem.Click += new System.EventHandler(this.hospitaliserToolStripMenuItem_Click);
            // 
            // ordonnaceToolStripMenuItem
            // 
            this.ordonnaceToolStripMenuItem.Image = global::Medecin.Properties.Resources.images__3_;
            this.ordonnaceToolStripMenuItem.Name = "ordonnaceToolStripMenuItem";
            this.ordonnaceToolStripMenuItem.Size = new System.Drawing.Size(78, 76);
            this.ordonnaceToolStripMenuItem.Text = "Ordonnace";
            this.ordonnaceToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ordonnaceToolStripMenuItem.Click += new System.EventHandler(this.ordonnaceToolStripMenuItem_Click);
            // 
            // dossierPatientToolStripMenuItem
            // 
            this.dossierPatientToolStripMenuItem.Image = global::Medecin.Properties.Resources.téléchargement;
            this.dossierPatientToolStripMenuItem.Name = "dossierPatientToolStripMenuItem";
            this.dossierPatientToolStripMenuItem.Size = new System.Drawing.Size(97, 76);
            this.dossierPatientToolStripMenuItem.Text = "Dossier Patient";
            this.dossierPatientToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 76);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 370);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(194, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 351);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 197);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Analyse";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idConsultationDataGridViewTextBoxColumn,
            this.idExamDataGridViewTextBoxColumn,
            this.idResultatExamenDataGridViewTextBoxColumn,
            this.resultatDataGridViewTextBoxColumn,
            this.dateResultatDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.resultatexamenBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(597, 178);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idConsultationDataGridViewTextBoxColumn
            // 
            this.idConsultationDataGridViewTextBoxColumn.DataPropertyName = "idConsultation";
            this.idConsultationDataGridViewTextBoxColumn.HeaderText = "idConsultation";
            this.idConsultationDataGridViewTextBoxColumn.Name = "idConsultationDataGridViewTextBoxColumn";
            this.idConsultationDataGridViewTextBoxColumn.Visible = false;
            // 
            // idExamDataGridViewTextBoxColumn
            // 
            this.idExamDataGridViewTextBoxColumn.DataPropertyName = "idExam";
            this.idExamDataGridViewTextBoxColumn.DataSource = this.examenBindingSource;
            this.idExamDataGridViewTextBoxColumn.DisplayMember = "nom";
            this.idExamDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idExamDataGridViewTextBoxColumn.HeaderText = "Exam";
            this.idExamDataGridViewTextBoxColumn.Name = "idExamDataGridViewTextBoxColumn";
            this.idExamDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idExamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idExamDataGridViewTextBoxColumn.ValueMember = "idExam";
            // 
            // examenBindingSource
            // 
            this.examenBindingSource.DataMember = "examen";
            this.examenBindingSource.DataSource = this.medecinDataSet;
            // 
            // medecinDataSet
            // 
            this.medecinDataSet.DataSetName = "MedecinDataSet";
            this.medecinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idResultatExamenDataGridViewTextBoxColumn
            // 
            this.idResultatExamenDataGridViewTextBoxColumn.DataPropertyName = "idResultatExamen";
            this.idResultatExamenDataGridViewTextBoxColumn.HeaderText = "idResultatExamen";
            this.idResultatExamenDataGridViewTextBoxColumn.Name = "idResultatExamenDataGridViewTextBoxColumn";
            this.idResultatExamenDataGridViewTextBoxColumn.Visible = false;
            // 
            // resultatDataGridViewTextBoxColumn
            // 
            this.resultatDataGridViewTextBoxColumn.DataPropertyName = "resultat";
            this.resultatDataGridViewTextBoxColumn.HeaderText = "Resultat";
            this.resultatDataGridViewTextBoxColumn.Name = "resultatDataGridViewTextBoxColumn";
            // 
            // dateResultatDataGridViewTextBoxColumn
            // 
            this.dateResultatDataGridViewTextBoxColumn.DataPropertyName = "DateResultat";
            this.dateResultatDataGridViewTextBoxColumn.HeaderText = "Date Resultat";
            this.dateResultatDataGridViewTextBoxColumn.Name = "dateResultatDataGridViewTextBoxColumn";
            // 
            // resultatexamenBindingSource
            // 
            this.resultatexamenBindingSource.DataMember = "resultatexamen";
            this.resultatexamenBindingSource.DataSource = this.medecinDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 154);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordonnance";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedicamentOrdonnanceDataGridViewTextBoxColumn,
            this.idOrdonnanceDataGridViewTextBoxColumn,
            this.idMedicamentDataGridViewTextBoxColumn,
            this.nombrePriseDataGridViewTextBoxColumn,
            this.dateDebutDataGridViewTextBoxColumn,
            this.dateFinDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medicamentordonnanceBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 135);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idMedicamentOrdonnanceDataGridViewTextBoxColumn
            // 
            this.idMedicamentOrdonnanceDataGridViewTextBoxColumn.DataPropertyName = "idMedicamentOrdonnance";
            this.idMedicamentOrdonnanceDataGridViewTextBoxColumn.HeaderText = "idMedicamentOrdonnance";
            this.idMedicamentOrdonnanceDataGridViewTextBoxColumn.Name = "idMedicamentOrdonnanceDataGridViewTextBoxColumn";
            this.idMedicamentOrdonnanceDataGridViewTextBoxColumn.Visible = false;
            // 
            // idOrdonnanceDataGridViewTextBoxColumn
            // 
            this.idOrdonnanceDataGridViewTextBoxColumn.DataPropertyName = "idOrdonnance";
            this.idOrdonnanceDataGridViewTextBoxColumn.HeaderText = "idOrdonnance";
            this.idOrdonnanceDataGridViewTextBoxColumn.Name = "idOrdonnanceDataGridViewTextBoxColumn";
            this.idOrdonnanceDataGridViewTextBoxColumn.Visible = false;
            // 
            // idMedicamentDataGridViewTextBoxColumn
            // 
            this.idMedicamentDataGridViewTextBoxColumn.DataPropertyName = "idMedicament";
            this.idMedicamentDataGridViewTextBoxColumn.DataSource = this.medicamentBindingSource;
            this.idMedicamentDataGridViewTextBoxColumn.DisplayMember = "nomMedicament";
            this.idMedicamentDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idMedicamentDataGridViewTextBoxColumn.HeaderText = "Medicament";
            this.idMedicamentDataGridViewTextBoxColumn.Name = "idMedicamentDataGridViewTextBoxColumn";
            this.idMedicamentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idMedicamentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idMedicamentDataGridViewTextBoxColumn.ValueMember = "idMedicament";
            // 
            // medicamentBindingSource
            // 
            this.medicamentBindingSource.DataMember = "medicament";
            this.medicamentBindingSource.DataSource = this.medecinDataSet;
            // 
            // nombrePriseDataGridViewTextBoxColumn
            // 
            this.nombrePriseDataGridViewTextBoxColumn.DataPropertyName = "nombrePrise";
            this.nombrePriseDataGridViewTextBoxColumn.HeaderText = "Nombre Prise";
            this.nombrePriseDataGridViewTextBoxColumn.Name = "nombrePriseDataGridViewTextBoxColumn";
            // 
            // dateDebutDataGridViewTextBoxColumn
            // 
            this.dateDebutDataGridViewTextBoxColumn.DataPropertyName = "dateDebut";
            this.dateDebutDataGridViewTextBoxColumn.HeaderText = "Date Debut";
            this.dateDebutDataGridViewTextBoxColumn.Name = "dateDebutDataGridViewTextBoxColumn";
            // 
            // dateFinDataGridViewTextBoxColumn
            // 
            this.dateFinDataGridViewTextBoxColumn.DataPropertyName = "dateFin";
            this.dateFinDataGridViewTextBoxColumn.HeaderText = "Date Fin";
            this.dateFinDataGridViewTextBoxColumn.Name = "dateFinDataGridViewTextBoxColumn";
            // 
            // medicamentordonnanceBindingSource
            // 
            this.medicamentordonnanceBindingSource.DataMember = "medicamentordonnance";
            this.medicamentordonnanceBindingSource.DataSource = this.medecinDataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 351);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 102);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 225);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Observations Prescriptions";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.pathologieBindingSource;
            this.comboBox1.DisplayMember = "nomMaladie";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "idPathologie";
            // 
            // pathologieBindingSource
            // 
            this.pathologieBindingSource.DataMember = "pathologie";
            this.pathologieBindingSource.DataSource = this.medecinDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maladie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "nom", true));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du patient";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "patient";
            this.patientBindingSource.DataSource = this.medecinDataSet;
            // 
            // medecinDataSet1
            // 
            this.medecinDataSet1.DataSetName = "MedecinDataSet";
            this.medecinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormConsultationBis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormConsultationBis";
            this.Text = "FormConsultationBis";
            this.Load += new System.EventHandler(this.FormConsultationBis_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultatexamenBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentordonnanceBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pathologieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitaliserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordonnaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dossierPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicamentOrdonnanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrdonnanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idMedicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource medicamentBindingSource;
        private MedecinDataSet medecinDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePriseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource medicamentordonnanceBindingSource;
        private System.Windows.Forms.BindingSource resultatexamenBindingSource;
        private System.Windows.Forms.BindingSource pathologieBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConsultationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idExamDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource examenBindingSource;
        private MedecinDataSet medecinDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idResultatExamenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateResultatDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource patientBindingSource;
    }
}