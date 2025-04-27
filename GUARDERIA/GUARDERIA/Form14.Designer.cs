namespace GUARDERIA
{
    partial class Form14
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
            this.datTUTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datTUTOR = new GUARDERIA.DatTUTOR();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gUARDERIADataSet9 = new GUARDERIA.GUARDERIADataSet9();
            this.tUTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tUTORTableAdapter = new GUARDERIA.GUARDERIADataSet9TableAdapters.TUTORTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datTUTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datTUTOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUARDERIADataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUTORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datTUTORBindingSource
            // 
            this.datTUTORBindingSource.DataSource = this.datTUTOR;
            this.datTUTORBindingSource.Position = 0;
            // 
            // datTUTOR
            // 
            this.datTUTOR.DataSetName = "DatTUTOR";
            this.datTUTOR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataStutor";
            reportDataSource1.Value = this.tUTORBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUARDERIA.RepTUTOR.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // gUARDERIADataSet9
            // 
            this.gUARDERIADataSet9.DataSetName = "GUARDERIADataSet9";
            this.gUARDERIADataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tUTORBindingSource
            // 
            this.tUTORBindingSource.DataMember = "TUTOR";
            this.tUTORBindingSource.DataSource = this.gUARDERIADataSet9;
            // 
            // tUTORTableAdapter
            // 
            this.tUTORTableAdapter.ClearBeforeFill = true;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form14";
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datTUTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datTUTOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUARDERIADataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUTORBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource datTUTORBindingSource;
        private DatTUTOR datTUTOR;
        private GUARDERIADataSet9 gUARDERIADataSet9;
        private System.Windows.Forms.BindingSource tUTORBindingSource;
        private GUARDERIADataSet9TableAdapters.TUTORTableAdapter tUTORTableAdapter;
    }
}