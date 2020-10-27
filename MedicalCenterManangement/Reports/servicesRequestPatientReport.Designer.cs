namespace MedicalCenterManangement.Reports
{
    partial class servicesRequestPatientReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getServicesRequestByVisitID_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getHeaderInformation_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.getServicesRequestByVisitID_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getHeaderInformation_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getServicesRequestByVisitID_ResultBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.getHeaderInformation_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MedicalCenterManangement.Reports.servicesRequestPatientReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(971, 558);
            this.reportViewer1.TabIndex = 0;
            // 
            // getServicesRequestByVisitID_ResultBindingSource
            // 
            this.getServicesRequestByVisitID_ResultBindingSource.DataSource = typeof(MedicalCenterManangement.DataModeView.getServicesRequestByVisitID_Result);
            // 
            // getHeaderInformation_ResultBindingSource
            // 
            this.getHeaderInformation_ResultBindingSource.DataSource = typeof(MedicalCenterManangement.DataModeView.getHeaderInformation_Result);
            // 
            // servicesRequestPatientReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 558);
            this.Controls.Add(this.reportViewer1);
            this.Name = "servicesRequestPatientReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "servicesRequestPatientReport";
            this.Load += new System.EventHandler(this.servicesRequestPatientReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getServicesRequestByVisitID_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getHeaderInformation_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getServicesRequestByVisitID_ResultBindingSource;
        private System.Windows.Forms.BindingSource getHeaderInformation_ResultBindingSource;
    }
}