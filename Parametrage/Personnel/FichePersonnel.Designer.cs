namespace Parametrage.Personnel
{
    partial class FichePersonnel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.textBox_telephone = new System.Windows.Forms.TextBox();
            this.personnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paramDataSet = new Parametrage.ParamDataSet();
            this.comboBox_specialite = new System.Windows.Forms.ComboBox();
            this.specialiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_service = new System.Windows.Forms.ComboBox();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_lieuN = new System.Windows.Forms.TextBox();
            this.dateTimePicker_dateN = new System.Windows.Forms.DateTimePicker();
            this.textBox_adresse = new System.Windows.Forms.TextBox();
            this.comboBox_genre = new System.Windows.Forms.ComboBox();
            this.textBox_ancienete = new System.Windows.Forms.TextBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialiteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Nom);
            this.groupBox1.Controls.Add(this.textBox_telephone);
            this.groupBox1.Controls.Add(this.comboBox_specialite);
            this.groupBox1.Controls.Add(this.comboBox_service);
            this.groupBox1.Controls.Add(this.textBox_lieuN);
            this.groupBox1.Controls.Add(this.dateTimePicker_dateN);
            this.groupBox1.Controls.Add(this.textBox_adresse);
            this.groupBox1.Controls.Add(this.comboBox_genre);
            this.groupBox1.Controls.Add(this.textBox_ancienete);
            this.groupBox1.Controls.Add(this.textBox_nom);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 504);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(441, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 29);
            this.button2.TabIndex = 20;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Téléphone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Lieu de naisssance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Date de naissance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ancienete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Spécialité";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Service";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Genre";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(239, 50);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(29, 13);
            this.Nom.TabIndex = 10;
            this.Nom.Text = "Nom";
            // 
            // textBox_telephone
            // 
            this.textBox_telephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personnelBindingSource, "telephone", true));
            this.textBox_telephone.Location = new System.Drawing.Point(343, 413);
            this.textBox_telephone.Name = "textBox_telephone";
            this.textBox_telephone.Size = new System.Drawing.Size(179, 20);
            this.textBox_telephone.TabIndex = 9;
            // 
            // personnelBindingSource
            // 
            this.personnelBindingSource.DataMember = "Personnel";
            this.personnelBindingSource.DataSource = this.paramDataSet;
            // 
            // paramDataSet
            // 
            this.paramDataSet.DataSetName = "ParamDataSet";
            this.paramDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox_specialite
            // 
            this.comboBox_specialite.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personnelBindingSource, "idSpecialite", true));
            this.comboBox_specialite.DataSource = this.specialiteBindingSource;
            this.comboBox_specialite.DisplayMember = "nomSpecialite";
            this.comboBox_specialite.FormattingEnabled = true;
            this.comboBox_specialite.Location = new System.Drawing.Point(343, 179);
            this.comboBox_specialite.Name = "comboBox_specialite";
            this.comboBox_specialite.Size = new System.Drawing.Size(179, 21);
            this.comboBox_specialite.TabIndex = 8;
            this.comboBox_specialite.ValueMember = "idSpecialite";
            // 
            // specialiteBindingSource
            // 
            this.specialiteBindingSource.DataMember = "specialite";
            this.specialiteBindingSource.DataSource = this.paramDataSet;
            // 
            // comboBox_service
            // 
            this.comboBox_service.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personnelBindingSource, "idService", true));
            this.comboBox_service.DataSource = this.serviceBindingSource;
            this.comboBox_service.DisplayMember = "nomService";
            this.comboBox_service.FormattingEnabled = true;
            this.comboBox_service.Location = new System.Drawing.Point(343, 136);
            this.comboBox_service.Name = "comboBox_service";
            this.comboBox_service.Size = new System.Drawing.Size(179, 21);
            this.comboBox_service.TabIndex = 7;
            this.comboBox_service.ValueMember = "idService";
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "service";
            this.serviceBindingSource.DataSource = this.paramDataSet;
            // 
            // textBox_lieuN
            // 
            this.textBox_lieuN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personnelBindingSource, "lieuNaiissance", true));
            this.textBox_lieuN.Location = new System.Drawing.Point(343, 372);
            this.textBox_lieuN.Name = "textBox_lieuN";
            this.textBox_lieuN.Size = new System.Drawing.Size(179, 20);
            this.textBox_lieuN.TabIndex = 6;
            // 
            // dateTimePicker_dateN
            // 
            this.dateTimePicker_dateN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personnelBindingSource, "dateNaissance", true));
            this.dateTimePicker_dateN.Location = new System.Drawing.Point(343, 327);
            this.dateTimePicker_dateN.Name = "dateTimePicker_dateN";
            this.dateTimePicker_dateN.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker_dateN.TabIndex = 5;
            // 
            // textBox_adresse
            // 
            this.textBox_adresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personnelBindingSource, "adresse", true));
            this.textBox_adresse.Location = new System.Drawing.Point(343, 258);
            this.textBox_adresse.Multiline = true;
            this.textBox_adresse.Name = "textBox_adresse";
            this.textBox_adresse.Size = new System.Drawing.Size(179, 47);
            this.textBox_adresse.TabIndex = 4;
            // 
            // comboBox_genre
            // 
            this.comboBox_genre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personnelBindingSource, "sexe", true));
            this.comboBox_genre.FormattingEnabled = true;
            this.comboBox_genre.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBox_genre.Location = new System.Drawing.Point(343, 93);
            this.comboBox_genre.Name = "comboBox_genre";
            this.comboBox_genre.Size = new System.Drawing.Size(179, 21);
            this.comboBox_genre.TabIndex = 3;
            // 
            // textBox_ancienete
            // 
            this.textBox_ancienete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personnelBindingSource, "anciente", true));
            this.textBox_ancienete.Location = new System.Drawing.Point(343, 221);
            this.textBox_ancienete.Name = "textBox_ancienete";
            this.textBox_ancienete.Size = new System.Drawing.Size(179, 20);
            this.textBox_ancienete.TabIndex = 2;
            // 
            // textBox_nom
            // 
            this.textBox_nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personnelBindingSource, "nom", true));
            this.textBox_nom.Location = new System.Drawing.Point(343, 47);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(179, 20);
            this.textBox_nom.TabIndex = 0;
            // 
            // FichePersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 504);
            this.Controls.Add(this.groupBox1);
            this.Name = "FichePersonnel";
            this.Text = "FichePersonnel";
            this.Load += new System.EventHandler(this.FichePersonnel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialiteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox textBox_telephone;
        private System.Windows.Forms.ComboBox comboBox_specialite;
        private System.Windows.Forms.ComboBox comboBox_service;
        private System.Windows.Forms.TextBox textBox_lieuN;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateN;
        private System.Windows.Forms.TextBox textBox_adresse;
        private System.Windows.Forms.ComboBox comboBox_genre;
        private System.Windows.Forms.TextBox textBox_ancienete;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource personnelBindingSource;
        private ParamDataSet paramDataSet;
        private System.Windows.Forms.BindingSource specialiteBindingSource;
        private System.Windows.Forms.BindingSource serviceBindingSource;
    }
}