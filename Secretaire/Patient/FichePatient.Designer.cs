namespace Secretaire.Patient
{
    partial class FichePatient
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxpre = new System.Windows.Forms.TextBox();
            this.bindingSourcePatient = new System.Windows.Forms.BindingSource(this.components);
            this.secretaireDataSet = new Secretaire.SecretaireDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerdn = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxsex = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxadr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxln = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxpro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxpoi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxtai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxgs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxnom = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretaireDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prénom";
            // 
            // textBoxpre
            // 
            this.textBoxpre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePatient, "prenom", true));
            this.textBoxpre.Location = new System.Drawing.Point(509, 25);
            this.textBoxpre.Name = "textBoxpre";
            this.textBoxpre.Size = new System.Drawing.Size(238, 26);
            this.textBoxpre.TabIndex = 1;
            // 
            // bindingSourcePatient
            // 
            this.bindingSourcePatient.DataMember = "patient";
            this.bindingSourcePatient.DataSource = this.secretaireDataSet;
            // 
            // secretaireDataSet
            // 
            this.secretaireDataSet.DataSetName = "SecretaireDataSet";
            this.secretaireDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dateTimePickerdn);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.comboBoxsex);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxadr);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxln);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxpro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxpoi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxtai);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxten);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxgs);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxnom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxpre);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 425);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePickerdn
            // 
            this.dateTimePickerdn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePatient, "dateNaissance", true));
            this.dateTimePickerdn.Location = new System.Drawing.Point(509, 188);
            this.dateTimePickerdn.Name = "dateTimePickerdn";
            this.dateTimePickerdn.Size = new System.Drawing.Size(238, 26);
            this.dateTimePickerdn.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(753, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "*";
            // 
            // comboBoxsex
            // 
            this.comboBoxsex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePatient, "sexe", true));
            this.comboBoxsex.FormattingEnabled = true;
            this.comboBoxsex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBoxsex.Location = new System.Drawing.Point(509, 122);
            this.comboBoxsex.Name = "comboBoxsex";
            this.comboBoxsex.Size = new System.Drawing.Size(238, 28);
            this.comboBoxsex.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(753, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(753, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(458, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Sexe";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(435, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Adresse";
            // 
            // textBoxadr
            // 
            this.textBoxadr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePatient, "adresse", true));
            this.textBoxadr.Location = new System.Drawing.Point(509, 156);
            this.textBoxadr.Multiline = true;
            this.textBoxadr.Name = "textBoxadr";
            this.textBoxadr.Size = new System.Drawing.Size(238, 26);
            this.textBoxadr.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Date de naissance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Lieu de naissance";
            // 
            // textBoxln
            // 
            this.textBoxln.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePatient, "lieuNaissance", true));
            this.textBoxln.Location = new System.Drawing.Point(509, 220);
            this.textBoxln.Name = "textBoxln";
            this.textBoxln.Size = new System.Drawing.Size(238, 26);
            this.textBoxln.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Profession";
            // 
            // textBoxpro
            // 
            this.textBoxpro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePatient, "profession", true));
            this.textBoxpro.Location = new System.Drawing.Point(509, 252);
            this.textBoxpro.Name = "textBoxpro";
            this.textBoxpro.Size = new System.Drawing.Size(238, 26);
            this.textBoxpro.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Poids";
            // 
            // textBoxpoi
            // 
            this.textBoxpoi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePatient, "poids", true));
            this.textBoxpoi.Location = new System.Drawing.Point(509, 284);
            this.textBoxpoi.Name = "textBoxpoi";
            this.textBoxpoi.Size = new System.Drawing.Size(238, 26);
            this.textBoxpoi.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Taille";
            // 
            // textBoxtai
            // 
            this.textBoxtai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePatient, "taille", true));
            this.textBoxtai.Location = new System.Drawing.Point(509, 316);
            this.textBoxtai.Name = "textBoxtai";
            this.textBoxtai.Size = new System.Drawing.Size(238, 26);
            this.textBoxtai.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tension";
            // 
            // textBoxten
            // 
            this.textBoxten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePatient, "tension", true));
            this.textBoxten.Location = new System.Drawing.Point(509, 348);
            this.textBoxten.Name = "textBoxten";
            this.textBoxten.Size = new System.Drawing.Size(238, 26);
            this.textBoxten.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Groupe sanguin";
            // 
            // textBoxgs
            // 
            this.textBoxgs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePatient, "groupeSanguin", true));
            this.textBoxgs.Location = new System.Drawing.Point(509, 380);
            this.textBoxgs.Name = "textBoxgs";
            this.textBoxgs.Size = new System.Drawing.Size(238, 26);
            this.textBoxgs.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age";
            // 
            // textBoxage
            // 
            this.textBoxage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePatient, "age", true));
            this.textBoxage.Location = new System.Drawing.Point(509, 89);
            this.textBoxage.Name = "textBoxage";
            this.textBoxage.Size = new System.Drawing.Size(238, 26);
            this.textBoxage.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // textBoxnom
            // 
            this.textBoxnom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePatient, "nom", true));
            this.textBoxnom.Location = new System.Drawing.Point(509, 57);
            this.textBoxnom.Name = "textBoxnom";
            this.textBoxnom.Size = new System.Drawing.Size(238, 26);
            this.textBoxnom.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Secretaire.Properties.Resources.button1_Image;
            this.button2.Location = new System.Drawing.Point(589, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 56);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Secretaire.Properties.Resources.button2_Image;
            this.button1.Location = new System.Drawing.Point(671, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 56);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FichePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 514);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FichePatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FichePatient";
            this.Load += new System.EventHandler(this.FichePatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretaireDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxpre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerdn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxsex;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxadr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxln;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxpro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxpoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxtai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxgs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxnom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bindingSourcePatient;
        private SecretaireDataSet secretaireDataSet;
    }
}