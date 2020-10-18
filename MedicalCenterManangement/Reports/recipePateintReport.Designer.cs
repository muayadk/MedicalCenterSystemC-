namespace MedicalCenterManangement.Reports
{
    partial class recipePateintReport
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
            this.getRecipeByVisitID_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getHeaderInformation_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.getRecipeByVisitID_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getHeaderInformation_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getRecipeByVisitID_ResultBindingSource;
            reportDataSource2.Name = "DataSet3";
            reportDataSource2.Value = this.getHeaderInformation_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MedicalCenterManangement.Reports.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(925, 541);
            this.reportViewer1.TabIndex = 0;
            // 
            // getRecipeByVisitID_ResultBindingSource
            // 
            this.getRecipeByVisitID_ResultBindingSource.DataSource = typeof(MedicalCenterManangement.DataModeView.getRecipeByVisitID_Result);
            // 
            // getHeaderInformation_ResultBindingSource
            // 
            this.getHeaderInformation_ResultBindingSource.DataSource = typeof(MedicalCenterManangement.DataModeView.getHeaderInformation_Result);
            // 
            // recipePateintReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 541);
            this.Controls.Add(this.reportViewer1);
            this.Name = "recipePateintReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "recipePateintReport";
            this.Load += new System.EventHandler(this.recipePateintReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getRecipeByVisitID_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getHeaderInformation_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getRecipeByVisitID_ResultBindingSource;
        private System.Windows.Forms.BindingSource getHeaderInformation_ResultBindingSource;
    }
}