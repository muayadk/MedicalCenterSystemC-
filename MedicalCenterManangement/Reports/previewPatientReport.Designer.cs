namespace MedicalCenterManangement.Reports
{
    partial class previewPatientReport
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
            this.getPreviewPatientByVistIDResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getHeaderInformationResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.getPreviewPatientByVistIDResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getHeaderInformationResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getPreviewPatientByVistIDResultBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.getHeaderInformationResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MedicalCenterManangement.Reports.previewPateintReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(870, 524);
            this.reportViewer1.TabIndex = 0;
            // 
            // getPreviewPatientByVistIDResultBindingSource
            // 
            this.getPreviewPatientByVistIDResultBindingSource.DataSource = typeof(MedicalCenterManangement.DataModeView.getPreviewPatientByVistID_Result);
            // 
            // getHeaderInformationResultBindingSource
            // 
            this.getHeaderInformationResultBindingSource.DataSource = typeof(MedicalCenterManangement.DataModeView.getHeaderInformation_Result);
            // 
            // previewPatientReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 524);
            this.Controls.Add(this.reportViewer1);
            this.Name = "previewPatientReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "previewPatientReport";
            this.Load += new System.EventHandler(this.previewPatientReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getPreviewPatientByVistIDResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getHeaderInformationResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getPreviewPatientByVistIDResultBindingSource;
        private System.Windows.Forms.BindingSource getHeaderInformationResultBindingSource;
    }
}