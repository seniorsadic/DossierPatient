namespace Medecin.Hospitalisations
{
    partial class FichePrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FichePrescription));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_traitement = new System.Windows.Forms.Label();
            this.label_fait = new System.Windows.Forms.Label();
            this.textBox_traitement = new System.Windows.Forms.TextBox();
            this.textBox_fait = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_medecin = new System.Windows.Forms.ComboBox();
            this.prescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medecinDataSet = new Medecin.MedecinDataSet();
            this.personnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.dirigeantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dirigeantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_traitement);
            this.groupBox1.Controls.Add(this.label_fait);
            this.groupBox1.Controls.Add(this.textBox_traitement);
            this.groupBox1.Controls.Add(this.textBox_fait);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox_medecin);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_date);
            this.groupBox1.Location = new System.Drawing.Point(0, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 204);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(371, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(371, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 53;
            this.label2.Text = "*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_traitement
            // 
            this.label_traitement.AutoSize = true;
            this.label_traitement.Location = new System.Drawing.Point(37, 144);
            this.label_traitement.Name = "label_traitement";
            this.label_traitement.Size = new System.Drawing.Size(57, 13);
            this.label_traitement.TabIndex = 52;
            this.label_traitement.Text = "Traitement";
            this.label_traitement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_fait
            // 
            this.label_fait.AutoSize = true;
            this.label_fait.Location = new System.Drawing.Point(70, 89);
            this.label_fait.Name = "label_fait";
            this.label_fait.Size = new System.Drawing.Size(24, 13);
            this.label_fait.TabIndex = 51;
            this.label_fait.Text = "Fait";
            this.label_fait.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_traitement
            // 
            this.textBox_traitement.Location = new System.Drawing.Point(118, 108);
            this.textBox_traitement.Multiline = true;
            this.textBox_traitement.Name = "textBox_traitement";
            this.textBox_traitement.Size = new System.Drawing.Size(247, 49);
            this.textBox_traitement.TabIndex = 50;
            // 
            // textBox_fait
            // 
            this.textBox_fait.Location = new System.Drawing.Point(118, 55);
            this.textBox_fait.Multiline = true;
            this.textBox_fait.Name = "textBox_fait";
            this.textBox_fait.Size = new System.Drawing.Size(247, 47);
            this.textBox_fait.TabIndex = 49;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 20);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // comboBox_medecin
            // 
            this.comboBox_medecin.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.prescriptionBindingSource, "idPersonne", true));
            this.comboBox_medecin.DataSource = this.personnelBindingSource;
            this.comboBox_medecin.DisplayMember = "nom";
            this.comboBox_medecin.FormattingEnabled = true;
            this.comboBox_medecin.Location = new System.Drawing.Point(118, 28);
            this.comboBox_medecin.Name = "comboBox_medecin";
            this.comboBox_medecin.Size = new System.Drawing.Size(247, 21);
            this.comboBox_medecin.TabIndex = 47;
            this.comboBox_medecin.ValueMember = "idPersonne";
            // 
            // prescriptionBindingSource
            // 
            this.prescriptionBindingSource.DataMember = "Prescription";
            this.prescriptionBindingSource.DataSource = this.medecinDataSet;
            // 
            // medecinDataSet
            // 
            this.medecinDataSet.DataSetName = "MedecinDataSet";
            this.medecinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personnelBindingSource
            // 
            this.personnelBindingSource.DataMember = "personnel";
            this.personnelBindingSource.DataSource = this.medecinDataSet;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.OrangeRed;
            this.label12.Location = new System.Drawing.Point(371, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 15);
            this.label12.TabIndex = 46;
            this.label12.Text = "*";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(371, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 45;
            this.label8.Text = "*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Medecin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(6, 170);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(88, 13);
            this.label_date.TabIndex = 43;
            this.label_date.Text = "Date Prescription";
            this.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dirigeantBindingSource
            // 
            this.dirigeantBindingSource.DataMember = "dirigeant";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(320, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 38);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(269, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 38);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FichePrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 258);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FichePrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiche Prescription";
            this.Load += new System.EventHandler(this.FichePrescription_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dirigeantBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_medecin;
        private System.Windows.Forms.BindingSource dirigeantBindingSource;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_date;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource prescriptionBindingSource;
        private MedecinDataSet medecinDataSet;
        private System.Windows.Forms.BindingSource personnelBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_traitement;
        private System.Windows.Forms.Label label_fait;
        private System.Windows.Forms.TextBox textBox_traitement;
        private System.Windows.Forms.TextBox textBox_fait;
    }
}