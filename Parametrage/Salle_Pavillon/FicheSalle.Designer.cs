namespace Parametrage.Salle_Pavillon
{
    partial class FicheSalle
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
            this.comboBox_typesalle = new System.Windows.Forms.ComboBox();
            this.salleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paramDataSet = new Parametrage.ParamDataSet();
            this.typedesalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_prix = new System.Windows.Forms.TextBox();
            this.comboBox_service = new System.Windows.Forms.ComboBox();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_dispo = new System.Windows.Forms.TextBox();
            this.textBox_capacite = new System.Windows.Forms.TextBox();
            this.textBox_numSalle = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typedesalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.comboBox_typesalle);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_prix);
            this.groupBox1.Controls.Add(this.comboBox_service);
            this.groupBox1.Controls.Add(this.textBox_dispo);
            this.groupBox1.Controls.Add(this.textBox_capacite);
            this.groupBox1.Controls.Add(this.textBox_numSalle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 435);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // comboBox_typesalle
            // 
            this.comboBox_typesalle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typedesalleBindingSource, "nomType", true));
            this.comboBox_typesalle.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.typedesalleBindingSource, "idTypeDeSalle", true));
            this.comboBox_typesalle.DataSource = this.typedesalleBindingSource;
            this.comboBox_typesalle.DisplayMember = "nomType";
            this.comboBox_typesalle.FormattingEnabled = true;
            this.comboBox_typesalle.Location = new System.Drawing.Point(242, 68);
            this.comboBox_typesalle.Name = "comboBox_typesalle";
            this.comboBox_typesalle.Size = new System.Drawing.Size(179, 21);
            this.comboBox_typesalle.TabIndex = 21;
            this.comboBox_typesalle.ValueMember = "idTypeDeSalle";
            // 
            // salleBindingSource
            // 
            this.salleBindingSource.DataMember = "Salle";
            this.salleBindingSource.DataSource = this.paramDataSet;
            // 
            // paramDataSet
            // 
            this.paramDataSet.DataSetName = "ParamDataSet";
            this.paramDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typedesalleBindingSource
            // 
            this.typedesalleBindingSource.DataMember = "typedesalle";
            this.typedesalleBindingSource.DataSource = this.paramDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 29);
            this.button2.TabIndex = 20;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 387);
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
            this.label8.Location = new System.Drawing.Point(137, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Prix / jour";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Disponibilité";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Capacité";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Numéro salle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Service";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Type de salle";
            // 
            // textBox_prix
            // 
            this.textBox_prix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salleBindingSource, "prixParJour", true));
            this.textBox_prix.Location = new System.Drawing.Point(242, 316);
            this.textBox_prix.Name = "textBox_prix";
            this.textBox_prix.Size = new System.Drawing.Size(179, 20);
            this.textBox_prix.TabIndex = 9;
            // 
            // comboBox_service
            // 
            this.comboBox_service.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typedesalleBindingSource, "nomType", true));
            this.comboBox_service.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salleBindingSource, "idSalle", true));
            this.comboBox_service.DataSource = this.serviceBindingSource;
            this.comboBox_service.DisplayMember = "nomService";
            this.comboBox_service.FormattingEnabled = true;
            this.comboBox_service.Location = new System.Drawing.Point(242, 108);
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
            // textBox_dispo
            // 
            this.textBox_dispo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salleBindingSource, "disponibilite", true));
            this.textBox_dispo.Location = new System.Drawing.Point(242, 261);
            this.textBox_dispo.Name = "textBox_dispo";
            this.textBox_dispo.Size = new System.Drawing.Size(179, 20);
            this.textBox_dispo.TabIndex = 6;
            // 
            // textBox_capacite
            // 
            this.textBox_capacite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salleBindingSource, "capacite", true));
            this.textBox_capacite.Location = new System.Drawing.Point(242, 209);
            this.textBox_capacite.Name = "textBox_capacite";
            this.textBox_capacite.Size = new System.Drawing.Size(179, 20);
            this.textBox_capacite.TabIndex = 4;
            // 
            // textBox_numSalle
            // 
            this.textBox_numSalle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salleBindingSource, "numeroSalle", true));
            this.textBox_numSalle.Location = new System.Drawing.Point(242, 161);
            this.textBox_numSalle.Name = "textBox_numSalle";
            this.textBox_numSalle.Size = new System.Drawing.Size(179, 20);
            this.textBox_numSalle.TabIndex = 2;
            // 
            // FicheSalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 435);
            this.Controls.Add(this.groupBox1);
            this.Name = "FicheSalle";
            this.Text = "FicheSalle";
            this.Load += new System.EventHandler(this.FicheSalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typedesalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_prix;
        private System.Windows.Forms.ComboBox comboBox_service;
        private System.Windows.Forms.TextBox textBox_dispo;
        private System.Windows.Forms.TextBox textBox_capacite;
        private System.Windows.Forms.TextBox textBox_numSalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource salleBindingSource;
        private ParamDataSet paramDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.BindingSource typedesalleBindingSource;
        private System.Windows.Forms.ComboBox comboBox_typesalle;
    }
}