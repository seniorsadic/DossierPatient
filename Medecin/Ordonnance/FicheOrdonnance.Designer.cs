namespace Medecin.Ordonnance
{
    partial class FicheOrdonnance
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.medicamentordonnanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medecinDataSet = new Medecin.MedecinDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentordonnanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // medicamentordonnanceBindingSource
            // 
            this.medicamentordonnanceBindingSource.DataMember = "medicamentordonnance";
            this.medicamentordonnanceBindingSource.DataSource = this.medecinDataSet;
            // 
            // medecinDataSet
            // 
            this.medecinDataSet.DataSetName = "MedecinDataSet";
            this.medecinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Medicament";
            reportDataSource1.Value = this.medicamentordonnanceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Medecin.Consultations.Ordonnance.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // FicheOrdonnance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FicheOrdonnance";
            this.Text = "FicheOrdonnance";
            this.Load += new System.EventHandler(this.FicheOrdonnance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicamentordonnanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource medicamentordonnanceBindingSource;
        private MedecinDataSet medecinDataSet;
    }
}